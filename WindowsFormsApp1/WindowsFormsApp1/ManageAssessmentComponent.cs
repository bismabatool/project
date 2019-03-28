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
    public partial class ManageAssessmentComponent : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public ManageAssessmentComponent()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB backto = new ProjectB();
            backto.Show();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAssessmentComponents addnew = new AddAssessmentComponents();
            addnew.Show();
        }

        private void ManageAssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);

        }

        private void studentrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AssessmentComponentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(AssessmentComponentrecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddAssessmentComponents registerStudent = new AddAssessmentComponents();
                registerStudent.Show();
            }
            if (AssessmentComponentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int Id = Convert.ToInt32(AssessmentComponentrecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + AssessmentComponentrecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from AssessmentComponent where Id  = '" + Id + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);
                }



            }
        }
    }
}
