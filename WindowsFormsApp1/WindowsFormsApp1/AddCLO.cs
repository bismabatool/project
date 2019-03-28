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
    public partial class AddCLO : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public AddCLO()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId !=-1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update Clo set Name='" + txtcloname.Text.ToString() + "',DateUpdated='" + DateTime.Now + "' where Id='"+Class1.stuId+"'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into Clo(Name,DateCreated,DateUpdated) values('" + txtcloname.Text.ToString() + "','" + DateTime.Now + "','" + DateTime.Now + "') ";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
                
            }
            this.Hide();
            ManageCLOs addnew = new ManageCLOs();
            addnew.Show();

        }

        private void AddCLO_Load(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {

                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from Clo WHERE Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtcloname.Text = read["Name"].ToString();

                }
                newcon1.Close();
            }
        }
    }
}
