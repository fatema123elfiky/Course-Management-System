using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Course_Managment.Common
{
    public partial class ShowCrs : Form
    {
        public ShowCrs()
        {
            InitializeComponent();
        }

        private void ShowCrs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                using (SqlConnection conn = new SqlConnection("Data Source=ALY-EL-BADRY\\SQLEXPRESS;Initial Catalog=courseManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM COURSE WHERE CATEGORY = @category", conn);
                    cmd.Parameters.AddWithValue("@category", selectedCategory);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ShowCourses.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ALY-EL-BADRY\\SQLEXPRESS;Initial Catalog=courseManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM COURSE WHERE ISHIDDEN = 0", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ShowCourses.DataSource = dt;
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ALY-EL-BADRY\\SQLEXPRESS;Initial Catalog=courseManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT CATEGORY FROM COURSE", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["CATEGORY"].ToString());
                }

                conn.Close();
            }
        }

        private void ShowCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ALY-EL-BADRY\\SQLEXPRESS;Initial Catalog=courseManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM COURSE WHERE ISHIDDEN = 0", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ShowCourses.DataSource = dt;
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
