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
        public Student(int studId)
        {
            InitializeComponent();
            this.studId = studId;
        }
    }
}
