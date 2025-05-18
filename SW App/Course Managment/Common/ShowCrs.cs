using Course_Managment.Instructor;
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

namespace Course_Managment.Common
{
    public partial class ShowCrs : Form
    {
        Form form;
        public ShowCrs(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ShowCrs_Load(object sender, EventArgs e)
        {
           
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsManagementDataSet.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.crsManagementDataSet.COURSE);

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void HighRegisteration_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT CID, SEMESTER, COUNT(SID) AS Number_Of_Students FROM ENROLL_IN GROUP BY CID, SEMESTER ORDER BY Number_Of_Students DESC", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void FilterCat_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand validation = new SqlCommand();
            validation.Connection = connection;
            cmd.Connection = connection;
            connection.Open();

            //validation//

            if (string.IsNullOrEmpty(CatValue.Text.Trim())){
                MessageBox.Show("The category field is empty !!");
                return;
            }

            validation.CommandText = "SELECT COUNT(*) FROM COURSE WHERE CATEGORY = '" + CatValue.Text + "'";
            int categories = (int)validation.ExecuteScalar();

            if (categories == 0)
            {
                MessageBox.Show("Category does not exist.");
                return;
            }

            //
            string query = "SELECT * FROM COURSE WHERE CATEGORY = '" + CatValue.Text
                + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
    }
}
