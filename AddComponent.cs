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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class AddComponent : Form
    {
        

        public AddComponent()
        {
            InitializeComponent();
            DisplayAssessmentComponentData();
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT Id FROM rubric";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items in the combobox
                    comboBox2.Items.Clear();

                    while (reader.Read())
                    {
                        // Add each RubricId to the combobox
                        comboBox2.Items.Add(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessment form1 = new ManageAssessment();

            // Show Form1
            form1.Show();

            // Hide the current form (Form2)
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = 0; 
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
                else
                {
                    MessageBox.Show("Please select an assessment component to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT COUNT(*) FROM AssessmentComponent WHERE Name = @Name AND RubricId = @RubricId AND TotalMarks = @TotalMarks AND AssessmentId = @AssessmentId";
                string updateQuery = "UPDATE AssessmentComponent SET Name = @Name, RubricId = @RubricId, TotalMarks = @TotalMarks, " +
                                     "AssessmentId = @AssessmentId, DateUpdated = @DateUpdated WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand checkCommand = new SqlCommand(selectQuery, connection);
                    checkCommand.Parameters.AddWithValue("@Name", textBox1.Text); 
                    checkCommand.Parameters.AddWithValue("@RubricId", int.Parse(comboBox2.Text));
                    checkCommand.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text)); 
                    checkCommand.Parameters.AddWithValue("@AssessmentId", int.Parse(comboBox1.Text)); 
                    checkCommand.Parameters.AddWithValue("@Id", selectedId);
                    int duplicateCount = (int)checkCommand.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("An assessment component with the same data already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Name", textBox1.Text); 
                    updateCommand.Parameters.AddWithValue("@RubricId", int.Parse(comboBox2.Text)); 
                    updateCommand.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text)); 
                    updateCommand.Parameters.AddWithValue("@AssessmentId", int.Parse(comboBox1.Text)); 
                    updateCommand.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@Id", selectedId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment component updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayAssessmentComponentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update assessment component!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("RubricId, Total Marks, and AssessmentId must be integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = 0; 
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
                else
                {
                    MessageBox.Show("Please select an assessment component to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string deleteQuery = "DELETE FROM AssessmentComponent WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Id", selectedId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment component deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the updated data
                        DisplayAssessmentComponentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete assessment component!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DisplayAssessmentComponentData()
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM AssessmentComponent";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing columns
                    dataGridView1.Columns.Clear();

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet10.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet10.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet9.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter1.Fill(this.projectBDataSet9.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet8.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet8.Rubric);
            // TODO: This line of code loads data into the 'projectBDataSet1.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet1.Assessment);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubricLevel rubricLevelForm = new RubricLevel();

            // Show the RubricLevel form
            rubricLevelForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get input data from the user
            string name = textBox1.Text.ToLower(); // Convert name to lowercase
            int rubricId;
            if (!int.TryParse(comboBox2.Text, out rubricId))
            {
                MessageBox.Show("Please enter a valid integer for Rubric ID.");
                return;
            }
            int totalMarks;
            if (!int.TryParse(textBox2.Text, out totalMarks))
            {
                MessageBox.Show("Please enter a valid integer for Total Marks.");
                return;
            }
            DateTime dateUpdated = DateTime.Now;
            int assessmentId;
            if (!int.TryParse(comboBox1.Text, out assessmentId))
            {
                MessageBox.Show("Please enter a valid integer for Assessment ID.");
                return;
            }

            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string query = "IF NOT EXISTS (SELECT 1 FROM AssessmentComponent WHERE Name = @Name AND RubricId = @RubricId AND TotalMarks = @TotalMarks AND AssessmentId = @AssessmentId) " +
                               "BEGIN " +
                               "INSERT INTO AssessmentComponent (Name, RubricId, TotalMarks,DateCreated, DateUpdated, AssessmentId) VALUES (@Name, @RubricId, @TotalMarks, GETDATE(),@DateUpdated, @AssessmentId) " +
                               "END";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@RubricId", rubricId);
                    command.Parameters.AddWithValue("@TotalMarks", totalMarks);
                    command.Parameters.AddWithValue("@DateUpdated", dateUpdated);
                    command.Parameters.AddWithValue("@AssessmentId", assessmentId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment Component added successfully.");
                        // Refresh the display of AssessmentComponent data
                        DisplayAssessmentComponentData();
                    }
                    else
                    {
                        MessageBox.Show("Assessment Component with the given details already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
