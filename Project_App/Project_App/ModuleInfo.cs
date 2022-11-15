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
    public partial class ModuleInfo : Form
    {
        public ModuleInfo()
        {
            InitializeComponent();
        }

        private void ModuleInfo_Load(object sender, EventArgs e)
        {
            ModuleGetSet module = new ModuleGetSet();
            BindingSource source = new BindingSource();
            source.DataSource = module.GetModule();
            dataGridViewModule.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ModuleGetSet module = new ModuleGetSet();
            module.Name1 = textBox1.Text;
            module.Code1 = txtModules.Text;
            module.Description1 = textBox2.Text;


            ModuleGetSet module2 = new ModuleGetSet();
            BindingSource source = new BindingSource();
            source.DataSource = module2.GetModule();
            dataGridViewModule.DataSource = source;
        }
    }
}
