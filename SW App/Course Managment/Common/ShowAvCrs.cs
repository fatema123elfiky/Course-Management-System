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
    public partial class ShowAvCrs : Form
    {
        Student.Student previous;
        public ShowAvCrs(Student.Student previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void ShowAvCrs_Load(object sender, EventArgs e)
        {
           
        }

        private void CatValue_TextChanged(object sender, EventArgs e)
        {

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

            if (string.IsNullOrEmpty(CatValue.Text.Trim()))
            {
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
                + "' AND ISHIDDEN = 0";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void HighRegisteration_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("WITH CourseCounts AS ( SELECT c.CID, COUNT(e.SID) AS NumStudents FROM ENROLL_IN e JOIN COURSE c ON e.CID = c.CID WHERE c.ISHIDDEN = 0 GROUP BY c.CID),MaxCount AS (SELECT MAX(NumStudents) AS MaxStudents FROM CourseCounts) SELECT c.* FROM COURSE c JOIN CourseCounts cc ON c.CID = cc.CID JOIN MaxCount mc ON cc.NumStudents = mc.MaxStudents WHERE c.ISHIDDEN = 0;", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsManagementDataSet.COURSE' table. You can move, or remove it, as needed.
            //this.cOURSETableAdapter.Fill(this.crsManagementDataSet.COURSE);
            /*  dataGridView1.DataSource = crsManagementDataSet.COURSE;
              this.cOURSETableAdapter.Fill(this.crsManagementDataSet.COURSE);*/
            string query = "SELECT * FROM COURSE WHERE ISHIDDEN = 0 ;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
            
        }
    }
}
