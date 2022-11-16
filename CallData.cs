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
        public string InsertStudentData(StudentGetSet student)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Student_Information(Student Number, Student Name, Student Surname, DOB, Gender, Phone, Address, Module Code)
                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}','{7}')", student.SNumber1, student.Name1, student.Surname1, student.DOB1, student.Gender1, student.Number1, student.Address1
                    );
                cmd = new SqlCommand(queryString, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                queryStateMessage = string.Format("Inserted Successful");
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
        public string InsertModuleData(ModuleGetSet module)
        {
            string queryStateMessage = "";
            try
            {
                queryString = string.Format(
                    @"INSERT INTO Module_Information(Module Code, Module Name, Module Description)
                    VALUES ('{0}', '{1}', '{2}')", module.Code1, module.Name1, module.Description1
                    );
                cmd = new SqlCommand(queryString, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                queryStateMessage = string.Format("Inserted Successful");
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
        public string UpdateStudentData(StudentGetSet student)
        {
            string queryStateMessage = "";
            try
            {
                string number = student.SNumber1;
                string firstName = student.Name1;
                string lastName = student.Surname1;
                DateTime birth = student.DOB1;
                string gender = student.Gender1;             
                string contact = student.Number1;
                string address = student.Address1;
                

                queryString = string.Format(
                    @"UPDATE  Student_Information
                   SET Student Number = @number, Student Name = @firstName, Student Surname=@lastName,DOB=@birth,Gender=@gender,Phone=@contact,Address=@address  Where Student Number =@number"
                );
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
        public string UpdateModuleData(ModuleGetSet module)
        {
            string queryStateMessage = "";
            try
            {
                string code = module.Code1;
                string Name = module.Name1;
                string description = module.Description1;
                


                queryString = string.Format(
                    @"UPDATE  Module_Information
                   SET Module Code = @code, Module Name = @Name, Student Surname=@lastName Where Module Code =@code"
                );
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
         public string RemoveModuleData(ModuleGetSet module)
        {
            string queryStateMessage = "";
            try
            {
                string code = module.Code1;
                string Name = module.Name1;
                string description = module.Description1;



                queryString = string.Format("DELETE FROM Module_Information WHERE Module Code =" + code
                ); 
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }
        public string RemoveStudentData(StudentGetSet student)
        {
            string queryStateMessage = "";
            try
            {
                string number = student.SNumber1;




                queryString = string.Format("DELETE FROM Student_Information WHERE Module Code =" + number
                );
            }
            catch (Exception e)
            {
                queryStateMessage = string.Format("An error occured and the data could not be processsed:\n{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return queryStateMessage;
        }

    }
}

