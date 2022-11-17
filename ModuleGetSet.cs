using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    class ModuleGetSet
    {
        private string Number, Code, Name, Description;

        public ModuleGetSet()
        {

        }

        public ModuleGetSet(string number, string code, string name, string description)
        {
            Number = number;
            Code = code;
            Name = name;
            Description = description;
        }

        public string Number1 { get => Number; set => Number = value; }
        public string Code1 { get => Code; set => Code = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Description1 { get => Description; set => Description = value; }

        public BindingSource GetModule()
        {
            CallData call = new CallData();
            BindingSource binding = new BindingSource();
            binding.DataSource = call.MouduleInfo();
            return binding;
        }
    }
}
