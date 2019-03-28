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
    public partial class AddAssessment : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public AddAssessment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txttotalmarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update Assessment set Title='" + txtassestitle.Text.ToString() + "',TotalMarks='" + Convert.ToInt32(txttotalmarks.Text) + "',TotalWeightage='" + Convert.ToInt32(txttotalweigh.Text) + "' where Id='" + Class1.stuId + "'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into Assessment(Title,DateCreated,TotalMarks,TotalWeightage) values('" + txtassestitle.Text.ToString() + "','" + DateTime.Now + "','" + Convert.ToInt32(txttotalmarks.Text) + "','" + Convert.ToInt32(txttotalweigh.Text) + "')";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
            this.Hide();
            ManageAssessment addn = new ManageAssessment();
            addn.Show();
              
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageAssessment addn = new ManageAssessment();
            addn.Show();
        }

        private void AddAssessment_Load(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {

                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from Assessment WHERE Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtassestitle.Text = read["Title"].ToString();
                    txttotalmarks.Text = read["TotalMarks"].ToString();
                    txttotalweigh.Text = read["TotalWeightage"].ToString();
                }
                newcon1.Close();
            }
        }
    }
}
