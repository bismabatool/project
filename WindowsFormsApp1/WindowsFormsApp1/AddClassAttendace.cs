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
    public partial class AddClassAttendace : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public AddClassAttendace()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClassAttendance back = new ClassAttendance();
            back.Show();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update ClassAttendance set AttendanceDate='" + dateTimePicker1.Value.Date + "' where Id='" + Class1.stuId + "'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into ClassAttendance(AttendanceDate) values('"+dateTimePicker1.Value.Date+"')";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
            this.Hide();
            ClassAttendance back = new ClassAttendance();
            back.Show();
        }

        private void AddClassAttendace_Load(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {

                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from ClassAttendance WHERE Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    dateTimePicker1.Value = Convert.ToDateTime(read["AttendanceDate"]);
                    
                }
                newcon1.Close();
            }
        }
    }
}
