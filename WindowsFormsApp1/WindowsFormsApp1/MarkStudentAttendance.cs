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
    public partial class MarkStudentAttendance : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public MarkStudentAttendance()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClassAttendance bck = new ClassAttendance();
            bck.Show();
        }

        private void MarkStudentAttendance_Load(object sender, EventArgs e)
        {
            if (Class1.stuId!=-1 && Class1.atId != -1)
            {

                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from StudentAttendance WHERE  AttendanceId='"+Class1.atId+ "' AND StudentId='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    cmbAttendancedate.SelectedValue = (read["AttendanceId"]).ToString();
                    cmbStdreg.SelectedValue = (read["StudentId"]).ToString();
                    cmbAttendanceStatus.SelectedValue = (read["AttendanceStatus"]).ToString();

                }
                newcon1.Close();
            
            }
            // TODO: This line of code loads data into the 'projectBDataSet.Lookup' table. You can move, or remove it, as needed.
            this.lookupTableAdapter.Fill(this.projectBDataSet.Lookup);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            // TODO: This line of code loads data into the 'projectBDataSet.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet.ClassAttendance);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "update StudentAttendance set AttendanceId='" + Convert.ToInt32(cmbAttendancedate.ValueMember) + "',StudentId='" + Convert.ToInt32(cmbStdreg.ValueMember) + "',AttendanceStatus='" + Convert.ToInt32(cmbAttendanceStatus.ValueMember) + "' where  AttendanceId='" +Class1.atId + "' AND StudentId='" + Class1.stuId + "'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into StudentAttendance(AttendanceId,StudentId,AttendanceStatus) values('" + Convert.ToInt32(cmbAttendancedate.SelectedValue) + "','" + Convert.ToInt32(cmbStdreg.SelectedValue) + "','" + Convert.ToInt32(cmbAttendanceStatus.SelectedValue) + "')"; 
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
            this.Hide();
            StudentAttendance bck = new StudentAttendance();
            bck.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentAttendance bck = new StudentAttendance();
            bck.Show();
        }
    }
}
