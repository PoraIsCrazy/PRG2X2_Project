using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Project_App
{
    class CallData
    {
        //Connection to database
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4VSO7EL\SQLEXPRESS; Initial Catalog = PRG_282_Project; Integrated Security = SSPI");
        SqlCommand cmd;
        string queryString;

        public DataTable StudentInfo()
        {
            string query = @"SELECT * FROM Student_Information";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable MouduleInfo()
        {
            string query = @"SELECT * FROM Module_Information";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
