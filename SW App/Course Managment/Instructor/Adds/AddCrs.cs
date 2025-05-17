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

namespace Course_Managment.Instructor.Adds
{
    public partial class AddCrs : Form
    {
        
        public AddCrs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Determine ISHIDDEN value based on radio button
            bool isHidden = radioButton1.Checked;

            using (SqlConnection connect = new SqlConnection(@"Data Source=(local);Initial Catalog=CrsManagement; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                try
                {
                    connect.Open();

                    // Check for existing CRSNAME
                    string checkQuery = "SELECT COUNT(*) FROM COURSE WHERE CRSNAME = @crsname";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@crsname", textBox1.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("A course with this name already exists.");
                            return;
                        }
                    }

                    // Insert the new course
                    string query = "INSERT INTO COURSE (CRSNAME, CATEGORY, EXAMNAME, ISHIDDEN) VALUES (@crsname, @category, @examname, @ishidden)";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@crsname", textBox1.Text);
                        command.Parameters.AddWithValue("@category", textBox2.Text);
                        command.Parameters.AddWithValue("@examname", textBox3.Text);
                        command.Parameters.AddWithValue("@ishidden", isHidden);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Course inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddCrs_Load(object sender, EventArgs e)
        {
            
            // this.cOURSETableAdapter.Fill(this.CrsManagementDataSet.COURSE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cOURSETableAdapter.Fill(this.CrsManagementDataSet.COURSE);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Logic for when radioButton1 (Hide) is selected
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Logic for when radioButton2 (Show) is selected
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

