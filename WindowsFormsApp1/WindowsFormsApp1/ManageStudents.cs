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
    public partial class ManageStudents : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent addnew = new AddStudent();
            addnew.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB addnew = new ProjectB();
            addnew.Show();
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);


        }

        private void studentrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()=="Edit")
            {
                Class1.stuId = Convert.ToInt32(studentrecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddStudent registerStudent = new AddStudent();
                registerStudent.Show();
            }
            if (studentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int studentId = Convert.ToInt32(studentrecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + studentrecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from Student where Id  = '" + studentId + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    this.studentTableAdapter.Fill(this.projectBDataSet.Student);
                }



            }
        }
    }
}