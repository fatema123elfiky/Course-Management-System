using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Managment.Instructor
{
    public partial class instructorFrom : Form
    {
        int instID;
        public instructorFrom(int instID)
        {
            InitializeComponent();
            this.instID = instID;
        }

        private void addInstBtn_Click(object sender, EventArgs e)
        {
            Instructor.addInstructor inst = new Instructor.addInstructor();
            inst.ShowDialog();
        }

        private void addStudBtn_Click(object sender, EventArgs e)
        {
            Instructor.addStudent stud = new Instructor.addStudent();
            stud.ShowDialog();
        }

        private void showcrs_Click(object sender, EventArgs e)
        {

        }

        private void showstud_Click(object sender, EventArgs e)
        {

        }

  


        private void addCrs_Click(object sender, EventArgs e)
        {

        }

        private void UpdCrs_Click(object sender, EventArgs e)
        {

        }

        private void delCrs_Click(object sender, EventArgs e)
        {

        }

        private void UpdInstruc_Click(object sender, EventArgs e)
        {

        }

        private void addGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
