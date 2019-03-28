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
    public partial class ManageAssessment : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public ManageAssessment()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB back = new ProjectB();
            back.Show();

        }

        private void ManageAssessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);

        }

        private void btnaddclo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAssessment addnew = new AddAssessment();
            addnew.Show();
        }

        private void Assessmentrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Assessmentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(Assessmentrecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddAssessment cl = new AddAssessment();
                cl.Show();
            }
            if (Assessmentrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int Id = Convert.ToInt32(Assessmentrecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + Assessmentrecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from AssessmentComponent where AssessmentId  = '" + Id + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    newconn.Open();
                    SqlCommand command1 = new SqlCommand("delete from Assessment where Id  = '" + Id + "'", newconn);
                    command1.ExecuteNonQuery();

                    newconn.Close();
                    this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);
                }

            }
        }
    }
}
