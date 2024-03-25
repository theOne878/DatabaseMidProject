using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
            DisplayStudentResultData();
        }

        private void StudentResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet14.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet14.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet13.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet13.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet12.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet12.Student);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessment manageAssessment = new ManageAssessment();
            manageAssessment.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayStudentResultData()
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT * FROM StudentResult";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);

                    // Clear existing columns
                    dataGridView1.Columns.Clear();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
