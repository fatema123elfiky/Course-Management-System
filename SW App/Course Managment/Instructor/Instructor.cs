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
        public instructorFrom()
        {
            InitializeComponent();
        }

        private void addInstBtn_Click(object sender, EventArgs e)
        {
            Instructor.addInstructor inst = new Instructor.addInstructor();
            inst.ShowDialog();
        }
    }
}
