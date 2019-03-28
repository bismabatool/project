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
    public partial class ClassAttendance : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public ClassAttendance()
        {
            InitializeComponent();
        }

        private void ClassAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet.ClassAttendance);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClassAttendanceRecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(ClassAttendanceRecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddClassAttendace cl = new AddClassAttendace();
                cl.Show();
            }
            if (ClassAttendanceRecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int Id = Convert.ToInt32(ClassAttendanceRecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + ClassAttendanceRecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from StudentAttendance where AttendanceId = '" + Id + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    newconn.Open();
                    SqlCommand command1 = new SqlCommand("delete from ClassAttendance where Id  = '" + Id + "'", newconn);
                    command1.ExecuteNonQuery();

                    newconn.Close();
                    this.classAttendanceTableAdapter.Fill(this.projectBDataSet.ClassAttendance);
                }

            }
        }

        private void btnaddAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClassAttendace cl = new AddClassAttendace();
            cl.Show();
        }

        private void btnmarkAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkStudentAttendance mark = new MarkStudentAttendance();
            mark.Show();
        }
    }
}
