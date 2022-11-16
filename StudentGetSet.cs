using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    class StudentGetSet
    {
        private string Name, Surname, SNumber, Gender, Address, Number;
        private DateTime DOB;
        public StudentGetSet()
        {

        }

        public StudentGetSet(string name, string surname, string sNumber, string gender, string address, string number, DateTime dOB)
        {
            Name = name;
            Surname = surname;
            SNumber = sNumber;
            Gender = gender;
            Address = address;
            Number = number;
            DOB = dOB;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string SNumber1 { get => SNumber; set => SNumber = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Number1 { get => Number; set => Number = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }

        public BindingSource GetStudent()
        {
            CallData call = new CallData();
            BindingSource binding = new BindingSource();
            binding.DataSource = call.StudentInfo();
            return binding;
        }
    }
}
