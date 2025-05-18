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
