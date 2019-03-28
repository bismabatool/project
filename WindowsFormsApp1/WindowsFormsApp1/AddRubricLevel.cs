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
    public partial class AddRubricLevel : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public AddRubricLevel()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Class1.stuId != -1)
            {
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu = "UPDATE RubricLevel SET RubricId='" + Convert.ToInt32(comboBoxrubricid.Text) + "',Details='" + txtrubriclvldet.Text.ToString() + "', MeasurementLevel = '" + txtmeasulvl.Text.ToString() + "'  WHERE Id='" + Class1.stuId + "'";
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
                string qu = "insert into RubricLevel(RubricId,Details,MeasurementLevel) values('" + Convert.ToInt32(comboBoxrubricid.Text) + "','" + txtrubriclvldet.Text.ToString() + "','" + txtmeasulvl.Text.ToString() + "')";
                SqlCommand newcom = new SqlCommand(qu, newcon);
                newcom.ExecuteNonQuery();
                newcon.Close();

            }
            
            this.Hide();
            ManageRubricLevel newf = new ManageRubricLevel();
            newf.Show();
        }

        private void AddRubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            if (Class1.stuId != -1)
            {
                btnadd.Text = "Edit";
                SqlConnection newcon1 = new SqlConnection(con);
                newcon1.Open();
                string qu1 = "select * from RubricLevel where Id='" + Class1.stuId + "'";
                SqlCommand sqlCommand = new SqlCommand(qu1, newcon1);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    comboBoxrubricid.SelectedValue = read["RubricId"].ToString();
                    txtrubriclvldet.Text = read["Details"].ToString();
                    txtmeasulvl.Text = read["MeasurementLevel"].ToString();

                }
                newcon1.Close();
            }
        }
    }
}
