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
using System.Security.Cryptography;

namespace Course_Managment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AcceptButton = this.loginButton;
        }
        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Resetting the errors
            emailErrorProvider.Clear();
            passwordErrorProvider.Clear();
            invalidCredsLabel.Text = string.Empty;
            // Getting the inputs
            string email = emailEntry.Text.Trim();
            string pass = passwordEntry.Text.Trim();
            // Validating the inputs
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

            if (string.IsNullOrWhiteSpace(pass))
            {
                passwordErrorProvider.SetError(passwordEntry, "Password is required");
                return;
            }

            if (pass.Length < 8)
            {
                passwordErrorProvider.SetError(passwordEntry, "Password must be at least 8 characters");
                return;
            }
            string hashedPass;
            // Hashing the password
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(pass);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                hashedPass = builder.ToString();
            }
            // Connecting to the Database
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True;"))
                {
                    con.Open();
                    // Checking for login in instuctors table
                    SqlCommand cmd = new SqlCommand(@"SELECT IID FROM INSTRUCTOR WHERE IEMAIL = @email AND IPASSWORD = @hashedPass;", con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@hashedPass", hashedPass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Successful Instructor Login
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            this.Hide();
                            var instructor = new Instructor.instructorFrom();
                            instructor.FormClosed += (s, args) => Application.Exit();
                            instructor.Show();
                            return;
                        }
                    }

                    // Checking for login in students table
                    cmd.CommandText = @"SELECT SID FROM STUDENT WHERE SEMAIL = @email AND SPASSWORD = @hashedPass;";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Student login successful
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            this.Hide();
                            var student = new Student.Student();
                            student.FormClosed += (s, args) => Application.Exit();
                            student.Show();
                            return;
                        }
                    }

                    invalidCredsLabel.Text = "Invalid Email or Password";
                }

                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
