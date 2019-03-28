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
    public partial class ManageCLOs : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public ManageCLOs()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB addnew = new ProjectB();
            addnew.Show();
        }

        private void btnaddclo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCLO addnew = new AddCLO();
            addnew.Show();
        }

        private void ManageCLOs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet.Clo);

        }

        private void clorecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clorecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(clorecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddCLO cl = new AddCLO();
                cl.Show();
            }
            if (clorecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int cloId = Convert.ToInt32(clorecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + clorecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from Rubric where CloId  = '" + cloId + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    newconn.Open();
                    SqlCommand command1 = new SqlCommand("delete from Clo where Id  = '" + cloId + "'", newconn);
                    command1.ExecuteNonQuery();

                    newconn.Close();
                    this.cloTableAdapter.Fill(this.projectBDataSet.Clo);
                }

            }
        }
    }
}
