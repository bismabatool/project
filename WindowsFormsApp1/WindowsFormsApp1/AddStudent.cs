using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update Student set FirstName='"+ txtfname.Text.ToString() +"',LastName='"+ txtlname.Text.ToString()+"' ,Contact='"+ txtcontact.Text.ToString() + "',Email='"+ txtemail.Text.ToString() + "',RegistrationNumber='" + txtregno.Text.ToString() + "' where Id='"+Class1.stuId+"'";
                SqlCommand newcom = new SqlCommand(qu,newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + txtfname.Text.ToString() + "','" + txtlname.Text.ToString() + "','" + txtcontact.Text.ToString() + "','" + txtemail.Text.ToString() + "','" + txtregno.Text.ToString() + "',5)";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
           

            this.Hide();
            ManageStudents addnew = new ManageStudents();
            addnew.Show();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {

                btnadd.Text = "Edit";
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string query = "select * from Student WHERE Id=" + Class1.stuId;
                SqlCommand sqlCommand = new SqlCommand(query, newcon);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtfname.Text = read["FirstName"].ToString();
                    txtlname.Text = read["LastName"].ToString();
                    txtemail.Text = read["Email"].ToString();
                    txtcontact.Text = read["Contact"].ToString();
                    txtregno.Text = read["RegistrationNumber"].ToString();
                }
                newcon.Close();

            }
        }
    }
}
