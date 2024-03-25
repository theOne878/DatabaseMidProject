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
    public partial class Lookup : Form
    {
        public Lookup()
        {
            InitializeComponent();
            DisplayLookupData();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageAssessment manageAssessment = new ManageAssessment();
            manageAssessment.Show();
        }
        private void DisplayLookupData()
        {
            try
            {
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT LookUpId, Name, Category FROM Lookup";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input data from the user
                string name = textBox1.Text;
                string category = textBox2.Text;

                // Check if the same data already exists
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT COUNT(*) FROM Lookup WHERE Name = @Name AND Category = @Category";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Category", category);

                    connection.Open();
                    int existingCount = (int)command.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("The same data already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method without adding duplicate data
                    }
                }

                // If the data does not already exist, proceed with insertion
                string insertQuery = "INSERT INTO Lookup (Name, Category) VALUES (@Name, @Category)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Category", category);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the newly added data
                        DisplayLookupData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    selectedId = Convert.ToInt32(selectedRow.Cells["LookupId"].Value);
                }
                else
                {
                    MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get input data from the user
                string name = textBox1.Text; // Assuming textBoxName is for name
                string category = textBox2.Text; // Assuming textBoxCategory is for category

                // Check if the updated data already exists (excluding the current ID)
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string selectQuery = "SELECT COUNT(*) FROM Lookup WHERE Name = @Name AND Category = @Category AND LookupId != @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@Name", name);
                    selectCommand.Parameters.AddWithValue("@Category", category);
                    selectCommand.Parameters.AddWithValue("@ID", selectedId);

                    connection.Open();
                    int duplicateCount = (int)selectCommand.ExecuteScalar();

                    if (duplicateCount > 0)
                    {
                        MessageBox.Show("The updated record already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method without updating if duplicate data found
                    }
                }

                // If no duplicate data found, proceed with updating
                string updateQuery = "UPDATE Lookup SET Name = @Name, Category = @Category WHERE LookupId = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@ID", selectedId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the updated data
                        DisplayLookupData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    selectedId = Convert.ToInt32(selectedRow.Cells["LookupId"].Value);
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Delete the associated records from the Student table
                DeleteAssociatedStudentRecords(selectedId);

                // Proceed with deleting the record from the Lookup table
                string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
                string deleteQuery = "DELETE FROM Lookup WHERE LookupId = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@ID", selectedId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect the updated data
                        DisplayLookupData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to delete associated records from the Student table based on Status
        private void DeleteAssociatedStudentRecords(int lookupId)
        {
            string connectionString = "Data Source=THEONE;Initial Catalog=ProjectB;Integrated Security=True";
            string deleteQuery = "DELETE FROM Student WHERE Status = @Status";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Status", lookupId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
