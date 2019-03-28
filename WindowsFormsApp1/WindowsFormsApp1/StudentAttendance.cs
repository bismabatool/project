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
    public partial class StudentAttendance : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet.StudentAttendance);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB bck = new ProjectB();
            bck.Show();
        }

        private void btnaddclo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkStudentAttendance bck = new MarkStudentAttendance();
            bck.Show();
        }

        private void Attendancerecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Attendancerecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.atId = Convert.ToInt32(Attendancerecord.Rows[e.RowIndex].Cells[0].Value);
                Class1.stuId = Convert.ToInt32(Attendancerecord.Rows[e.RowIndex].Cells[1].Value);
                this.Hide();
                MarkStudentAttendance cl = new MarkStudentAttendance();
                cl.Show();
            }
            if (Attendancerecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int AId = Convert.ToInt32(Attendancerecord.Rows[e.RowIndex].Cells[0].Value);
                int SId = Convert.ToInt32(Attendancerecord.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + Attendancerecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from StudentAttendance where AttendanceId='"+AId+"' AND StudentId  = '" + SId + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    
                    this.studentAttendanceTableAdapter.Fill(this.projectBDataSet.StudentAttendance);
                }

            }
        }
    }
}
