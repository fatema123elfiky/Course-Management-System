using Course_Managment.Common;
using Course_Managment.Student.Adds;
using Course_Managment.Student.Upd_del;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Managment.Student
{
    public partial class Student : Form
    {
        int studId;
        Login previous;
        public Student(Login previous, int studId)
        {
            InitializeComponent();
            this.studId = studId;
            this.previous = previous;
        }

        private void ADDENROLL_Click(object sender, EventArgs e)
        {
            AddEnroll addEnroll = new AddEnroll(this,studId);
            this.Hide();
            addEnroll.Show();
        }

        private void DELENROLL_Click(object sender, EventArgs e)
        {
            DelEnroll delEnroll = new DelEnroll (this);
            this.Hide();
            delEnroll.Show();
        }

       

        private void shwcrs_Click(object sender, EventArgs e)
        {
            ShowCrs showCrs = new ShowCrs(this);
            this.Hide();
            showCrs.Show();
        }

        private void UPDSTUD_Click(object sender, EventArgs e)
        {
            UpdStud updStud = new UpdStud(this,studId);
            this.Hide();
            updStud.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
           
            previous.Show();
            this.Close();

        }
    }
}
