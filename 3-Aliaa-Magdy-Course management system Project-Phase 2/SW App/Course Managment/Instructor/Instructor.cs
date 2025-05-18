using Course_Managment.Common;
using Course_Managment.Instructor.Adds;
using Course_Managment.Instructor.Upd_del;
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
        Login previous;
        public instructorFrom(Login previous, int instID)
        {
            InitializeComponent();
            this.instID = instID;
            this.previous = previous;
        }

        private void addInstBtn_Click(object sender, EventArgs e)
        {
            Instructor.addInstructor inst = new Instructor.addInstructor(this);
            this.Hide();
            inst.ShowDialog();
        }

        private void addStudBtn_Click(object sender, EventArgs e)
        {
            Instructor.addStudent stud = new Instructor.addStudent(this);
            this.Hide();
            stud.ShowDialog();
        }

        private void showcrs_Click(object sender, EventArgs e)
        {
            ShowCrs showCrs = new ShowCrs(this);
            this.Hide();
            showCrs.Show();
        }

        private void showstud_Click(object sender, EventArgs e)
        {
            ShowStud showStud = new ShowStud(this);
            this.Hide();
            showStud.Show();
        }

  


        private void addCrs_Click(object sender, EventArgs e)
        {
            AddCrs addCrs = new AddCrs(this);//missed parameter
            this.Hide();
            addCrs.Show();
        }

        private void UpdCrs_Click(object sender, EventArgs e)
        {
           Upd_del.UpdCrs updCrs = new Upd_del.UpdCrs(this);// missed parameter
            this.Hide();
            updCrs.Show();
        }

        private void delCrs_Click(object sender, EventArgs e)
        {
            DelCrs delCrs = new DelCrs(this);//missed parameter
            this.Hide();
            delCrs.Show();
        }

        private void UpdInstruc_Click(object sender, EventArgs e)
        {
            UpdInstruc updInstruc = new UpdInstruc(this);
            this.Hide();
            updInstruc.Show();
        }

        private void addGrade_Click(object sender, EventArgs e)
        {
            AddGrade addGrade = new AddGrade(this);
            this.Hide(); 
            addGrade.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
           
            previous.Show();
            this.Close();

        }
    }
}
