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

namespace Course_Managment.Student.Upd_del
{
    public partial class UpdStud : Form
    {
        Student previous;
        int id;
        public UpdStud(Student Form, int id)
        {
            InitializeComponent();
            previous = Form;
            this.id = id;
        }

        private void Update_Click(object sender, EventArgs e){
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand validation = new SqlCommand();
            
            cmd.Connection = con;
            validation.Connection = con;

            con.Open();

            //validation part//
            if (string.IsNullOrEmpty(NameText.Text.Trim())||
                string.IsNullOrEmpty(EmailText.Text.Trim())||
                string.IsNullOrEmpty(PasswordText.Text.Trim())){
                
                MessageBox.Show("There are empty fields !!");
                return;
            }

          
            // //

            cmd.CommandText="Update STUDENT SET SNAME = '"+
                NameText.Text + "', SEMAIL = '"+EmailText.Text+
                "', SPASSWORD = '"+PasswordText.Text+"' WHERE SID = '"
                + id+"';";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your info is updated !!");


        }

        private void GoBack_Click(object sender, EventArgs e){
            previous.Show();
            this.Close();
        }

        private void UpdStud_Load(object sender, EventArgs e)
        {
           
        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM STUDENT WHERE SID = '" + id
                 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
