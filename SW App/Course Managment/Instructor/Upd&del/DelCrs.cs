using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Course_Managment.Instructor.Upd_del
{
    public partial class DelCrs : Form
    {
        instructorFrom previous;
        public DelCrs(instructorFrom previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string cidInput = textBox1.Text.Trim();

            // 1. Check for empty input
            if (string.IsNullOrEmpty(cidInput))
            {
                MessageBox.Show("Course ID field cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Check for valid numeric input
            if (!int.TryParse(cidInput, out int crsId))
            {
                MessageBox.Show("Please enter a valid numeric Course ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 3. Check if the course exists
                    string checkQuery = "SELECT COUNT(*) FROM COURSE WHERE CID = @CID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@CID", crsId);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("No course found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 4. Confirm before deleting
                    DialogResult confirmResult = MessageBox.Show(
                        "Are you sure you want to delete this course?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult != DialogResult.Yes)
                        return;

                    // 5. Delete course
                    string deleteQuery = "DELETE FROM COURSE WHERE CID = @CID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@CID", crsId);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DelCrs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CrsManagementDataSet.COURSE' table. You can move, or remove it, as needed.
            //this.cOURSETableAdapter.Fill(this.CrsManagementDataSet.COURSE);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.cOURSETableAdapter.Fill(this.CrsManagementDataSet.COURSE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }
    }
}



