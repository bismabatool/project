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
    public partial class AddAssessmentComponents : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public AddAssessmentComponents()
        {
            InitializeComponent();
        }

        private void AddAssessmentComponents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);

            if (Class1.stuId != -1)
            {
                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from AssessmentComponent where Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtcompname.Text = read["Name"].ToString();
                    comboBoxRubricid.SelectedValue = read["RubricId"].ToString();
                    txttotalmarks.Text = read["TotalMarks"].ToString();
                    comboBoxAssessId.Text = read["AssessmentId"].ToString();

                }
                newcon1.Close();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update AssessmentComponent set Name='" + txtcompname.Text.ToString() + "',RubricId='" + Convert.ToInt32(comboBoxRubricid.Text) + "',TotalMarks='" + Convert.ToInt32(txttotalmarks.Text) + "',DateUpdated='" + DateTime.Now + "',AssessmentId='" + Convert.ToInt32(comboBoxAssessId.SelectedValue) + "' where Id='" + Class1.stuId + "'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + txtcompname.Text.ToString() + "','" + Convert.ToInt32(comboBoxRubricid.Text) + "','" + Convert.ToInt32(txttotalmarks.Text) + "','" + DateTime.Now + "','" + DateTime.Now + "','" + Convert.ToInt32(comboBoxAssessId.SelectedValue) + "')";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
            this.Hide();
            ManageAssessmentComponent newf = new ManageAssessmentComponent();
            newf.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageAssessmentComponent newf = new ManageAssessmentComponent();
            newf.Show();
        }


    }
}

