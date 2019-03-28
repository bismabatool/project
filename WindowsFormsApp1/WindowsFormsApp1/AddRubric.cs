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
    public partial class AddRubric : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";

        public AddRubric()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                MessageBox.Show(comboBox1.SelectedValue.ToString());
                newcon1.Open();
                string qu = "UPDATE Rubric SET Details='" + txtRubric.Text.ToString() + "',CloId='" + Convert.ToInt32(comboBox1.SelectedValue.ToString()) + "' WHERE Id='" + Class1.stuId + "'";
                SqlCommand newcom = new SqlCommand(qu, newcon1);
                newcom.ExecuteNonQuery();
                newcon1.Close();
                Class1.stuId = -1;
                btnadd.Text = "Add";
            }
            else
            {
                SqlConnection newcon = new SqlConnection(con);
                newcon.Open();
                string qu = "insert into Rubric(Details,CloId) values('" + txtRubric.Text.ToString() + "','" + Convert.ToInt32(comboBox1.SelectedValue) + "')";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();
            }
            this.Hide();
            ManageRubrics addnew = new ManageRubrics();
            addnew.Show();

        }

        private void AddRubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet.Clo);

            if (Class1.stuId != -1)
            {
                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from Rubric where Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    txtRubric.Text = read["Details"].ToString();
                    comboBox1.SelectedValue = read["Name"].ToString();

                }
                newcon1.Close();
            }
        }
    }
}
