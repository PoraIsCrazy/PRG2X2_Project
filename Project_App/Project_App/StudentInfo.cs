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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StudentGetSet call = new StudentGetSet();
            string gender = "";
            call.Name1 = txtName.Text;
            call.Surname1 = txtSurname.Text;
            call.SNumber1 = txtStudentNumber.Text;
            call.Number1 = txtPhone.Text;
            call.Address1 = txtAddress.Text;
            if (radioMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                if (radioFemale.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }
            }
            call.Gender1 = gender;
            call.DOB1 = dateOfBirth.Value;
            dataGridViewStudent.Refresh();
        }
    }
}
