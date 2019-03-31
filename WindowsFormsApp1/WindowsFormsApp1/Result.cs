using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class Result : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public Result()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet.StudentResult);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB addnew = new ProjectB();
            addnew.Show();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluateStudent ab = new EvaluateStudent();
            ab.Show();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream("Result.pdf", FileMode.Create));
            document.Open();
            connection.Open();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int studentId = Convert.ToInt32(row.Cells[0].Value);
                int assessmentComponentId = Convert.ToInt32(row.Cells[1].Value);
                int RubeicMeasurementId = Convert.ToInt32(row.Cells[2].Value);
                string query = "Select Student.RegistrationNumber as regNo, CONCAT(Student.FirstName,' ', Student.LastName) as Name," +
                    " AssessmentComponent.Name as Component, AssessmentComponent.TotalMarks as Total," +
                    " RubricLevel.Details as Rubric,RubricLevel.MeasurementLevel as stdLevel,RubricLevel.RubricId as RubricId" +
                    " from Student JOIN StudentResult ON StudentResult.StudentId=Student.Id JOIN AssessmentComponent ON " +
                    "StudentResult.AssessmentComponentId=AssessmentComponent.Id Join RubricLevel ON StudentResult.RubricMeasurementId=RubricLevel.Id WHERE " +
                    "StudentResult.StudentId='" + Convert.ToInt32(studentId) + "' AND StudentResult.AssessmentComponentId='" + Convert.ToInt32(assessmentComponentId) + "' AND " +
                    "StudentResult.RubricMeasurementId='" + Convert.ToInt32(RubeicMeasurementId) + "'";
                SqlCommand resultCommand = new SqlCommand(query, connection);
                SqlDataReader reader = resultCommand.ExecuteReader();
                string Name = "", Reg = "", Component = "", Rubric = "", MeasurementLevel = "";
                int Total = 0;
                int rb_Id = 0;
                while (reader.Read())
                {
                    Name = reader["Name"].ToString();
                    Reg = reader["regNo"].ToString();
                    Total = Convert.ToInt32(reader["Total"]);
                    Component = reader["Component"].ToString();
                    Rubric = reader["Rubric"].ToString();
                    MeasurementLevel = reader["stdLevel"].ToString();
                    rb_Id = Convert.ToInt32(reader["RubricId"]);
                }
                reader.Close();
                int ab = -1;
                SqlCommand q = new SqlCommand("Select MAX(MeasurementLevel) as ml From RubricLevel Where RubricId='" + Convert.ToInt32(rb_Id) + "'", connection);
                SqlDataReader dataReader = q.ExecuteReader();
                while (dataReader.Read())
                {
                    ab = Convert.ToInt32(dataReader["ml"]);
                }
                dataReader.Close();
                Paragraph para = new Paragraph("Name: " + Name.ToString() + "\nRegistration Number: " + Reg + "\n\n");
                PdfPTable table = new PdfPTable(5);
                string[] list = { "Component", "Rubric", "Component Marks", "Student Rubric Level", "Obtained Marks" };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(list[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                float obtain = (Convert.ToInt32(MeasurementLevel) / ab) * Total;
                string[] data = { Component, Rubric, Total.ToString(), MeasurementLevel, obtain.ToString() };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(data[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                document.Add(para);
                document.Add(table);
            }
            document.Close();
            MessageBox.Show("Student report card downloaded!");
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

