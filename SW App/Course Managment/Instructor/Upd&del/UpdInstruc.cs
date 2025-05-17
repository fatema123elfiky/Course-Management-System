
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



namespace Course_Managment.Instructor.Upd_del

{
    
    public partial class UpdInstruc : Form
    {
        

        private readonly string connectionString = @"Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        
       
        public UpdInstruc()
        {

            InitializeComponent();
           
            btnUpdateName.Click += btnUpdateName_Click;
            btnUpdateEmail.Click += btnUpdateEmail_Click;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // btnBack.Click += BtnBack_Click;
        }

        private void UpdInstruc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsManagementDataSet.INSTRUCTOR' table. You can move, or remove it, as needed.
           // this.iNSTRUCTORTableAdapter1.Fill(this.crsManagementDataSet.INSTRUCTOR);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Password");

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            //comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredId = txtid.Text.Trim();
            if (string.IsNullOrEmpty(enteredId))
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM INSTRUCTOR WHERE IID = @IID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IID", enteredId);

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
                        MessageBox.Show("ID not found.");
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
                case "Name":
                    panel2.Visible = true;
                    break;
                case "Email":
                    panel3.Visible = true;
                    break;
                case "Password":
                    panel4.Visible = true;
                    break;
            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            UpdateField("INAME", txtOldName.Text.Trim(), txtNewName.Text.Trim());
           

        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            UpdateField("IEMAIL", txtOldEmail.Text.Trim(), txtNewEmail.Text.Trim());
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdateField("IPASSWORD", txtOldPassword.Text.Trim(), txtNewPassword.Text.Trim());
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

                    string checkQuery = $"SELECT COUNT(*) FROM INSTRUCTOR WHERE IID = @id AND {columnName} = @oldValue";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    checkCmd.Parameters.AddWithValue("@oldValue", oldValue);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("Old value does not match.");
                        return;
                    }

                    string updateQuery = $"UPDATE INSTRUCTOR SET {columnName} = @newValue WHERE IID = @id";
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

      

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.iNSTRUCTORTableAdapter1.Fill(this.crsManagementDataSet.INSTRUCTOR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dah el baccccccccccccccccccccccccccccckkkkkkkk
        }
    }
     
    }
