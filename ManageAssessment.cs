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
    public partial class ManageAssessment : Form
    {
        public ManageAssessment()
        {
            InitializeComponent();
            DisplayAssessmentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT COUNT(*) FROM Assessment WHERE Title = @Title AND TotalMarks = @TotalMarks AND TotalWeightage = @TotalWeightage";
                string insertQuery = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) " +
                                     "VALUES (@Title, @DateCreated, @TotalMarks, @TotalWeightage)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the same data already exists in the database
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@Title", textBox1.Text); // Assuming textBox1 is for Title
                    selectCommand.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text)); // Assuming textBox2 is for TotalMarks
                    selectCommand.Parameters.AddWithValue("@TotalWeightage", int.Parse(textBox3.Text)); // Assuming textBox3 is for TotalWeightage

                    int existingRecordsCount = (int)selectCommand.ExecuteScalar();

                    if (existingRecordsCount > 0)
                    {
                        MessageBox.Show("The same assessment already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method without adding duplicate data
                    }

                    // Insert the new assessment if it doesn't already exist
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Title", textBox1.Text); // Assuming textBox1 is for Title
                    insertCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now); // Current date and time
                    insertCommand.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text)); // Assuming textBox2 is for TotalMarks
                    insertCommand.Parameters.AddWithValue("@TotalWeightage", int.Parse(textBox3.Text)); // Assuming textBox3 is for TotalWeightage

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the newly added assessment
                        DisplayAssessmentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add assessment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Total Marks and Total Weightage must be integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void DisplayAssessmentData()
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT ID, Title, DateCreated, TotalMarks, TotalWeightage FROM Assessment";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing columns
                    dataGridView1.Columns.Clear();

                    // Set AutoGenerateColumns to false to manually add columns
                    dataGridView1.AutoGenerateColumns = false;

                    // Add columns to the DataGridView and specify their properties
                    dataGridView1.Columns.Add("ID", "ID");
                    dataGridView1.Columns["ID"].DataPropertyName = "ID"; // Match with the DataTable column name

                    dataGridView1.Columns.Add("Title", "Title");
                    dataGridView1.Columns["Title"].DataPropertyName = "Title";

                    dataGridView1.Columns.Add("DateCreated", "Date Created");
                    dataGridView1.Columns["DateCreated"].DataPropertyName = "DateCreated";

                    dataGridView1.Columns.Add("TotalMarks", "Total Marks");
                    dataGridView1.Columns["TotalMarks"].DataPropertyName = "TotalMarks";

                    dataGridView1.Columns.Add("TotalWeightage", "Total Weightage");
                    dataGridView1.Columns["TotalWeightage"].DataPropertyName = "TotalWeightage";

                    // Set the DataGridView DataSource to the filled DataTable
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected ID from the DataGridView
                int selectedId = 0; // Assuming the ID is an integer
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Please select an assessment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";

                // Delete related rows in AssessmentComponent table
                string deleteAssessmentComponentQuery = "DELETE FROM AssessmentComponent WHERE AssessmentId = @AssessmentId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Delete related rows in AssessmentComponent table
                    SqlCommand deleteAssessmentComponentCommand = new SqlCommand(deleteAssessmentComponentQuery, connection);
                    deleteAssessmentComponentCommand.Parameters.AddWithValue("@AssessmentId", selectedId);

                    connection.Open();
                    deleteAssessmentComponentCommand.ExecuteNonQuery();

                    // Delete the row in the Assessment table
                    string deleteQuery = "DELETE FROM Assessment WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@ID", selectedId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the updated data
                        DisplayAssessmentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete assessment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                // Retrieve the selected ID from the DataGridView
                int selectedId = 0; // Assuming the ID is an integer
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Please select an assessment to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT COUNT(*) FROM Assessment WHERE Title = @Title AND TotalMarks = @TotalMarks AND TotalWeightage = @TotalWeightage";
                string updateQuery = "UPDATE Assessment SET Title = @Title, TotalMarks = @TotalMarks, " +
                                     "TotalWeightage = @TotalWeightage WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the updated title already exists (excluding the current ID)
                    SqlCommand checkCommand = new SqlCommand(selectQuery, connection);
                    checkCommand.Parameters.AddWithValue("@Title", textBox1.Text); // Assuming textBox1 is for Title
                    checkCommand.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                    checkCommand.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
                    checkCommand.Parameters.AddWithValue("@ID", selectedId);
                    int duplicateCount = (int)checkCommand.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("An assessment with the same title already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    // If title is unique, proceed with update
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Title", textBox1.Text); // Assuming textBox1 is for Title
                    updateCommand.Parameters.AddWithValue("@TotalMarks", int.Parse(textBox2.Text)); // Assuming textBox2 is for TotalMarks
                    updateCommand.Parameters.AddWithValue("@TotalWeightage", int.Parse(textBox3.Text)); // Assuming textBox3 is for TotalWeightage
                    updateCommand.Parameters.AddWithValue("@ID", selectedId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Assessment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the updated assessment
                        DisplayAssessmentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update assessment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Total Marks and Total Weightage must be integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessment form1 = new ManageAssessment();

            // Show the new instance of Form1
            form1.Show();

            // Close the current form
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComponent form2 = new AddComponent();

            // Show Form2 as a dialog (modal)
            form2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageRubrics manageRubricsForm = new ManageRubrics();

            // Display the ManageRubrics form
            manageRubricsForm.Show();
        }

        private void ManageAssessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet11.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet11.Assessment);

        }
      
    }
}
