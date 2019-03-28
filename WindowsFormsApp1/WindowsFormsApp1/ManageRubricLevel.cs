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
    public partial class ManageRubricLevel : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public ManageRubricLevel()
        {
            InitializeComponent();
        }

        private void ManageRubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);

        }

        private void clorecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RubricLevelRecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(RubricLevelRecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddRubricLevel cl = new AddRubricLevel();
                cl.Show();
            }
            if (RubricLevelRecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int rId = Convert.ToInt32(RubricLevelRecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + RubricLevelRecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from RubricLevel where Id  = '" + rId + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);
                }

            }
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
            AddRubricLevel addnew = new AddRubricLevel();
            addnew.Show();

        }
    }
}
