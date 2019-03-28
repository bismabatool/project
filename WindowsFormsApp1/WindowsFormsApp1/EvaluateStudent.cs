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
    public partial class EvaluateStudent : Form
    {
        const string con = "Data Source=SAMI-PC\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        public EvaluateStudent()
        {
            InitializeComponent();
        }

        private void EvaluateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            SqlConnection newcon = new SqlConnection(con);
            newcon.Open();
            string qu = "insert into StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) values('" +Convert.ToInt32(comboBoxStdId.Text)+ "','" + Convert.ToInt32(comboBoxAssessCompid.Text) + "','" + Convert.ToInt32(textBox1.Text) + "','" + DateTime.Now +"') ";
            SqlCommand newcom = new SqlCommand(qu, newcon);
            newcom.ExecuteNonQuery();
            newcon.Close();
        }
    }
}
