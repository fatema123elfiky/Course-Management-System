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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_Managment.Instructor.Adds
{
    public partial class AddGrade : Form
    {
        instructorFrom previous;
        public AddGrade(instructorFrom previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void AddGrade_Load(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            connection.Open();

            // Check if any of the required values are empty
            if (string.IsNullOrEmpty(this.SID.Text) ||
                string.IsNullOrEmpty(this.CrsID.Text) ||
                string.IsNullOrEmpty(this.Grade.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Set Variables
            string SID = this.SID.Text.Trim();
            string CrsID = this.CrsID.Text.Trim();
            //string Semester = this.Semester.Text.Trim();
            string Grade = this.Grade.Text.Trim();

            // SQL Command for validation
            SqlCommand validation = new SqlCommand();
            validation.Connection = connection;

            validation.Parameters.Add(new SqlParameter("@SID", SID));
            validation.Parameters.Add(new SqlParameter("@CrsID", CrsID));
            //validation.Parameters.Add(new SqlParameter("@Semester", Semester));
            validation.Parameters.Add(new SqlParameter("@Grade", Grade));


            // Validate SID
            validation.CommandText = "SELECT COUNT(*) FROM Student WHERE SID = @SID;";
            int student = (int)validation.ExecuteScalar();
            if (student == 0)
            {
                SIDErrorProvider.SetError(this.SID, "Student ID does not exist");
                return;
            }

            // Validate Course ID
            validation.CommandText = "SELECT COUNT(*) FROM Course WHERE CID = @CrsID;";
            int course = (int)validation.ExecuteScalar();
            if (course == 0)
            {
                CrsIDErrorProvider.SetError(this.CrsID, "Course ID does not exist");
                return;
            }

            

            // Validate Enrollment
            validation.CommandText = "SELECT COUNT(*) FROM ENROLL_IN WHERE SID = @SID AND CID = @CrsID ;";
            int enrollment = (int)validation.ExecuteScalar();
            if (enrollment == 0)
            {
                MessageBox.Show("Student is not enrolled in this course for the specified semester.");
                return;
            }

            // Validate Grade
            if (int.TryParse(Grade, out int gradeValue) && (gradeValue >= 0 && gradeValue <= 100))
            {
                SqlCommand command = new SqlCommand("UPDATE ENROLL_IN SET GRADE = @Grade WHERE SID = @SID AND CID = @CrsID ", connection);
                command.Parameters.Add(new SqlParameter("@SID", SID));
                command.Parameters.Add(new SqlParameter("@CrsID", CrsID));
                //command.Parameters.Add(new SqlParameter("@Semester", Semester));
                command.Parameters.Add(new SqlParameter("@Grade", Grade));
                command.ExecuteNonQuery();
            }
            else
            {
                GradeErrorProvider.SetError(this.Grade, "Grade must be a number between 0 and 100.");
                return;
            }
            connection.Close();
            MessageBox.Show("Grade is added !!");
            
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }
    }

}
