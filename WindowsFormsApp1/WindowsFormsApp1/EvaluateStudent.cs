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

namespace WindowsFormsApp1
{
    public partial class EvaluateStudent : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public EvaluateStudent()
        {
            InitializeComponent();
        }

        private void EvaluateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);

            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

            btnresult.Text = "Update";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select * from StudentResult WHERE StudentId=" + Class1.stuId;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboBoxAssessCompid.SelectedValue = read["AssessmentComponentId"].ToString();
                comboBox1.SelectedValue = read["RubricMeasurementId"].ToString();
                comboBoxStdId.SelectedValue = read["StudentId"].ToString();
            }
            read.Close();
            connection.Close();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            if (btnresult.Text == "Update")
            {
                string updateQuery = "Update StudentResult set RubricMeasurementId='" + Convert.ToInt32(comboBox1.SelectedValue) + "'," +
                   "AssessmentComponentId='" + Convert.ToInt32(comboBoxAssessCompid.SelectedValue.ToString()) + "'" +
                   " Where StudentId='" + Convert.ToInt32(comboBoxStdId.SelectedValue) + "'";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) values('" + Convert.ToInt32(comboBoxStdId.Text) + "','" + Convert.ToInt32(comboBoxAssessCompid.Text) + "','" + Convert.ToInt32(comboBox1.Text) + "','" + DateTime.Now + "') ";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB addnew = new ProjectB();
            addnew.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Result addnew = new Result();
            addnew.Show();
        }
    }
}
