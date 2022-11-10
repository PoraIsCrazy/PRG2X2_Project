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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> passwords = new List<string>();

        //This checks for the Log in details
        private void btnLogin_Click(object sender, EventArgs e)
        {
                if (users.Contains(txtName.Text) && passwords.Contains(txtPassword.Text) && Array.IndexOf(users.ToArray(), txtName.Text)
                == Array.IndexOf(passwords.ToArray(), txtPassword.Text))
                {
                //Log in

                //this.Hide();

                MessageBox.Show("Correct");
                }
                else
                {
                    MessageBox.Show("User name and/or password is incorrect!");
                }          
        }
        //This loads the text File
        private void frmLogin_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formRegister = new frmRegister();
            formRegister.Show();
            this.Hide();
        }

        private void chkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkbxShowPass.Checked ? '\0' : '*';
        }
    }
}
