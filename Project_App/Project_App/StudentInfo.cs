using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            StudentGetSet student = new StudentGetSet();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = student.GetStudent();
            dataGridViewStudent.DataSource = bindingSource;
        }
    }
}
