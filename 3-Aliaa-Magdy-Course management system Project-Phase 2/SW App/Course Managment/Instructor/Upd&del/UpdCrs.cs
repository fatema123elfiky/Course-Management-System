using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Course_Managment.Instructor.Upd_del
{
    public partial class UpdCrs : Form
    {
        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=CrsManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        instructorFrom previous;
        public UpdCrs(instructorFrom previous)
        {
            
            InitializeComponent();

            btnUpdateExamName.Click += btnUpdateExamName_Click;
            btnUpdateCourseName.Click += btnUpdateCourseName_Click;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            button1.Click += button1_Click;
            //button2.Click += button2_Click;
            this.previous = previous;
        }

        private void UpdCrs_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Exam Name");
            comboBox1.Items.Add("Course Name");
            comboBox1.Items.Add("Category");

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredId = txtid.Text.Trim();
            if (string.IsNullOrEmpty(enteredId))
            {
                MessageBox.Show("Please enter a Course ID.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM COURSE WHERE CID = @CID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CID", enteredId);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        panel1.Visible = true;
                        panel2.Visible = false;
                        panel3.Visible = false;
                        panel4.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Course ID not found.");
                        panel1.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Exam Name":
                    panel2.Visible = true;
                    break;
                case "Course Name":
                    panel3.Visible = true;
                    break;
                case "Category":
                    panel4.Visible = true;
                    break;
            }
        }

        private void btnUpdateExamName_Click(object sender, EventArgs e)
        {
            UpdateField("EXAMNAME", txtOldExamName.Text.Trim(), txtNewExamName.Text.Trim());
        }

        private void btnUpdateCourseName_Click(object sender, EventArgs e)
        {
            UpdateField("CRSNAME", txtOldCourseName.Text.Trim(), txtNewCourseName.Text.Trim());
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateField("CATEGORY", txtOldCategory.Text.Trim(), txtNewCategory.Text.Trim());
        }

        private void UpdateField(string columnName, string oldValue, string newValue)
        {
            string id = txtid.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(oldValue) || string.IsNullOrEmpty(newValue))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string checkQuery = $"SELECT COUNT(*) FROM COURSE WHERE CID = @id AND {columnName} = @oldValue";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    checkCmd.Parameters.AddWithValue("@oldValue", oldValue);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("Old value does not match.");
                        return;
                    }

                    string updateQuery = $"UPDATE COURSE SET {columnName} = @newValue WHERE CID = @id";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@newValue", newValue);
                    updateCmd.Parameters.AddWithValue("@id", id);

                    int rows = updateCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Update successful.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                }
            }
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                 this.cOURSETableAdapter.Fill(this.crsManagementDataSet.COURSE);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.cOURSETableAdapter.Fill(this.crsManagementDataSet.COURSE);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }
    }
}
