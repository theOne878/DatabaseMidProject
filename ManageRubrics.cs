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
    public partial class ManageRubrics : Form
    {
        public ManageRubrics()
        {
            InitializeComponent();
            DisplayRubricData();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ManageRubrics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet2.Clo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DisplayRubricData()
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT Id, Details, CloId FROM Rubric";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing data in the DataGridView
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        // Retrieve data from the reader
                        int rubricId = (int)reader["Id"];
                        
                        string details = reader["Details"].ToString();
                        int cloId = (int)reader["CloId"];

                        // Add the data to the DataGridView
                        dataGridView1.Rows.Add(rubricId, details, cloId);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        // In your form load event or constructor
        private void Form_Load(object sender, EventArgs e)
        {
            // Bind ComboBox to Clo data source
            comboBox1.DisplayMember = "Name"; // Display the Clo names
            comboBox1.ValueMember = "Id";     // Store the CloIds
            
        }

        // Function to retrieve Clo data (replace this with your actual data retrieval method)
        


        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected CloId from the ComboBox
            int selectedCloId = 0;
            if (comboBox1.SelectedItem != null)
            {
                DataRowView rowView = comboBox1.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    selectedCloId = Convert.ToInt32(rowView["Id"]);
                }
            }

            // Get the details entered by the user
            string details = textBox2.Text.Trim(); // Trim any leading or trailing whitespace

            // Check if details are provided
            if (string.IsNullOrWhiteSpace(details))
            {
                MessageBox.Show("Please enter details for the rubric.");
                return;
            }

            // Get the Rubric Id from the textbox
            int rubricId;
            if (!int.TryParse(textBox1.Text, out rubricId))
            {
                MessageBox.Show("Please enter a valid integer for Rubric Id.");
                return;
            }

            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Insert into the Rubric table with the selected CloId and other details
                    string insertQuery = "INSERT INTO Rubric (Id, CloId, Details) VALUES (@Id, @CloId, @Details)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", rubricId);
                        command.Parameters.AddWithValue("@CloId", selectedCloId);
                        command.Parameters.AddWithValue("@Details", details);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rubric added successfully and assigned to CloId: " + selectedCloId);
                            // Refresh the DataGridView to display the updated data
                            DisplayRubricData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add rubric.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the Rubric Id from the textbox
            int rubricId;
            if (!int.TryParse(textBox1.Text, out rubricId))
            {
                MessageBox.Show("Please enter a valid integer for Rubric Id.");
                return;
            }

            // Get the selected CloId from the ComboBox
            int selectedCloId = 0;
            if (comboBox1.SelectedItem != null)
            {
                DataRowView rowView = comboBox1.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    selectedCloId = Convert.ToInt32(rowView["Id"]);
                }
            }

            // Get the details entered by the user
            string details = textBox2.Text.Trim(); // Trim any leading or trailing whitespace

            // Check if details are provided
            if (string.IsNullOrWhiteSpace(details))
            {
                MessageBox.Show("Please enter details for the rubric.");
                return;
            }

            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the CloId and Details for the specified RubricId
                    string updateQuery = "UPDATE Rubric SET CloId = @CloId, Details = @Details WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CloId", selectedCloId);
                        command.Parameters.AddWithValue("@Details", details); // Use the details entered by the user
                        command.Parameters.AddWithValue("@Id", rubricId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("CloId and Details updated successfully for RubricId: " + rubricId);
                            // Refresh the DataGridView to display the updated data
                            DisplayRubricData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update CloId and Details for rubric.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void SoftDeleteRubric(int rubricId)
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";

                // Delete associated records from AssessmentComponent table
                string deleteAssessmentComponentQuery = "DELETE FROM AssessmentComponent WHERE RubricId = @RubricId";

                // Delete associated records from RubricLevel table
                string deleteRubricLevelQuery = "DELETE FROM RubricLevel WHERE RubricId = @RubricId";

                // Delete Rubric record
                string deleteRubricQuery = "DELETE FROM Rubric WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete associated records from AssessmentComponent table
                    SqlCommand deleteAssessmentComponentCommand = new SqlCommand(deleteAssessmentComponentQuery, connection);
                    deleteAssessmentComponentCommand.Parameters.AddWithValue("@RubricId", rubricId);
                    deleteAssessmentComponentCommand.ExecuteNonQuery();

                    // Delete associated records from RubricLevel table
                    SqlCommand deleteRubricLevelCommand = new SqlCommand(deleteRubricLevelQuery, connection);
                    deleteRubricLevelCommand.Parameters.AddWithValue("@RubricId", rubricId);
                    deleteRubricLevelCommand.ExecuteNonQuery();

                    // Delete Rubric record
                    SqlCommand deleteRubricCommand = new SqlCommand(deleteRubricQuery, connection);
                    deleteRubricCommand.Parameters.AddWithValue("@Id", rubricId);
                    int rowsAffected = deleteRubricCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rubric deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayRubricData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete rubric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of the RubricLevel form
            RubricLevel rubricLevelForm = new RubricLevel();

            // Show the RubricLevel form
            rubricLevelForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Prompt the user to enter the Rubric ID
            string rubricIdInput = textBox1.Text;

            // Check if the input is empty or not a valid integer
            if (string.IsNullOrWhiteSpace(rubricIdInput) || !int.TryParse(rubricIdInput, out int rubricId))
            {
                MessageBox.Show("Please enter a valid Rubric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the function to delete the Rubric
            SoftDeleteRubric(rubricId);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessment manageAssessment = new ManageAssessment();
            manageAssessment.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComponent addComponent = new AddComponent();
            addComponent.Show();
        }
    }
}
