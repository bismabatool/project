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
    public partial class ManageRubrics : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public ManageRubrics()
        {
            InitializeComponent();
        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRubric addnew = new AddRubric();
            addnew.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProjectB addnew = new ProjectB();
            addnew.Show();
        }

        private void ManageRubrics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rubricrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.stuId = Convert.ToInt32(rubricrecord.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddRubric cl = new AddRubric();
                cl.Show();
            }
            if (rubricrecord.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int rId = Convert.ToInt32(rubricrecord.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Are you sure to perform this action!?" + rubricrecord.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection newconn = new SqlConnection(con);
                    newconn.Open();
                    SqlCommand command = new SqlCommand("delete from Rubric where Id  = '" + rId + "'", newconn);
                    command.ExecuteNonQuery();
                    newconn.Close();
                    this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
                }

            }
        }
    }
}
