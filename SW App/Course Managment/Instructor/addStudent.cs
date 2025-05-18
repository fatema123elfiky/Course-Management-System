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

namespace Course_Managment.Instructor
{
    public partial class addStudent : Form
    {

        //Student previous;
        public addStudent()
        {
            InitializeComponent();
           // previous = Form;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Resetting the Errors
            this.emailErrorProvider.Clear();
            this.nameErrorProvider.Clear();
            // Get Inputs
            string name = this.nameEntry.Text.Trim();
            string email = this.emailEntry.Text.Trim();
            string pass = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f";
            // Validating the Inputs
            if (string.IsNullOrWhiteSpace(name))
            {
                nameErrorProvider.SetError(nameEntry, "Name is required");
                return;
            }
            if (name.Length < 3)
            {
                nameErrorProvider.SetError(nameEntry, "Name must be at least 3 characters");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                emailErrorProvider.SetError(emailEntry, "Email is required");
                return;
            }
            if (email.Length < 10)
            {
                emailErrorProvider.SetError(emailEntry, "Email must be at least 10 characters");
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                emailErrorProvider.SetError(emailEntry, "Please enter a valid email address");
                return;
            }

            // Sending the Data to the Database
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True;"))
                {
                    con.Open();
                    // Inserting into the Instructor Table
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO STUDENT(SNAME, SEMAIL, SPASSWORD) VALUES(@name, @email, @pass);", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Successfully Added New Student");
                        //this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add New Student");
                        nameEntry.Clear();
                        emailEntry.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            try
            {
                this.sTUDENTTableAdapter.Fill(this.crsManagementDataSet.STUDENT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            // TODO: This line of code loads data into the 'crsManagementDataSet.STUDENT' table. You can move, or remove it, as needed.
            // this.sTUDENTTableAdapter.Fill(this.crsManagementDataSet.STUDENT);
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AcceptButton = this.addButton;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.Fill(this.crsManagementDataSet.STUDENT);
        }

        private void Back_Click(object sender, EventArgs e)
        {
           // previous.Show();
            this.Close();
        }
       
    }


}
