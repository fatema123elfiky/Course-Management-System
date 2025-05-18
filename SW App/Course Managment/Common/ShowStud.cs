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
    public partial class ShowStud : Form
    {
        instructorFrom form;
        public ShowStud(instructorFrom form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ShowStud_Load(object sender, EventArgs e)
        {
          
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crsManagementDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.crsManagementDataSet.STUDENT);

        }

        private void TopFive_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            connection.Open();

            //validation//

            if (string.IsNullOrEmpty(CrsIDText.Text.Trim()))
            {
                MessageBox.Show("You have to enter the course ID");
                return;
            }

            int CrsID;
            if (!int.TryParse(CrsIDText.Text.Trim(), out CrsID))
            {
                MessageBox.Show("Please enter a number for the course ID");
                return;
            }

            SqlCommand validation = new SqlCommand("SELECT COUNT(*) FROM COURSE WHERE CID = @cid", connection);
            validation.Parameters.AddWithValue("@cid", CrsID);



            int course = (int)validation.ExecuteScalar();
            if (course == 0)
            {
                MessageBox.Show("Course does not exist.");
                return;
            }


            // get the top 5 students with the highest grades for a specific course
            string query = "SELECT TOP 5 SID, SNAME, GRADE FROM ENROLL_IN INNER JOIN STUDENT ON ENROLL_IN.SID = STUDENT.SID WHERE CID = @cid ORDER BY GRADE DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@cid", CrsID);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void GradeFilter_Click(object sender, EventArgs e)
        {
           
            //validation//
            if (string.IsNullOrEmpty(GradeText.Text)){
                MessageBox.Show("The grade field is empty !!");
                return;
            }
            // //

            string query = "SELECT * FROM STUDENT WHERE" +
                "SID IN (SELECT SID FROM ENROLL_IN WHERE GRADE ='" + GradeText.Text + "');";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource=table;
        }
    }
}
