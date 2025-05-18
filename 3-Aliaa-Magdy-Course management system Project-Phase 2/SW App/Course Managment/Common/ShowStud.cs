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
            //this.sTUDENTTableAdapter.Fill(this.crsManagementDataSet.STUDENT);
            dataGridView1.DataSource = crsManagementDataSet.STUDENT;
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

            string CrsID = CrsIDText.Text.Trim();

            SqlCommand validation = new SqlCommand("SELECT COUNT(*) FROM COURSE WHERE CID = @cid", connection);
            validation.Parameters.AddWithValue("@cid", CrsID);



            int course = (int)validation.ExecuteScalar();
            if (course == 0)
            {
                MessageBox.Show("Course does not exist.");
                return;
            }


            // get the top 5 students with the highest grades for a specific course
            //string query = "SELECT TOP 5 SID, SNAME, GRADE FROM ENROLL_IN INNER JOIN STUDENT ON ENROLL_IN.SID = STUDENT.SID WHERE CID = @cid ORDER BY GRADE DESC";
            //string query = "SELECT (*) FROM STUDENT WHERE SID IN (SELECT TOP 5 SID FROM ENROLL_IN WHERE CID =  @cid ORDER BY GRADE DESC)";
            string query = "SELECT * FROM STUDENT WHERE SID IN (" +
               "SELECT TOP 5 SID FROM ENROLL_IN WHERE CID = '" + CrsIDText.Text.Trim() + "' ORDER BY GRADE DESC)";
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
            if (string.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("The CrsID field is empty !!");
                return;
            }
            // //

            string query = "SELECT * FROM STUDENT WHERE " +
                "SID IN (SELECT SID FROM ENROLL_IN WHERE GRADE ='" + GradeText.Text + "' AND CID ='"+textBox1.Text+ "');";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource=table;
        }
    }
}
