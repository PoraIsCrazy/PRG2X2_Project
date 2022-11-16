using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        string name, password = "";

        List<string> users = new List<string>();
        List<string> passwords = new List<string>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var formLogIn = new frmLogin();
            formLogIn.ShowDialog();
            this.Close();
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                lblIncorrect.ForeColor = Color.Green;
                lblIncorrect.Text = "Passwords match!";
            }
            else if (txtPassword1.Text != txtPassword2.Text)
            {
                lblIncorrect.ForeColor = Color.Red;
                lblIncorrect.Text = "Passwords don't match!";
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            string line = "";
            StreamReader sr = new StreamReader("LogIn.txt");

            while ((line = sr.ReadLine()) != null)
            {
                string[] vs = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(vs[0]);
                passwords.Add(vs[1]);
            }
            sr.Close();
        }

        //This registers a new user and does excetion handeling
        private void btnEnter_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            password = txtPassword1.Text;

            Int32 length = users.Count;

            if (txtPassword1.Text == txtPassword2.Text)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("LogIn.txt");
                    for (int i = 0; i < length; i++)
                    {
                        sw.WriteLine(users[i] + " " + passwords[i]);
                    }
                    sw.WriteLine(name + " " + password);
                    sw.Close();


                }
                catch (Exception a)
                {
                    MessageBox.Show("Exception: " + a.Message);
                }

                //This Is where we open the student form
                this.Close();
            }
            else if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("Passwords don't match!");
            }
        }

        private void chkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword1.PasswordChar = chkbxShowPass.Checked ? '\0' : '*';
            txtPassword2.PasswordChar = chkbxShowPass.Checked ? '\0' : '*';
        }
    }
}
