using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class SignupDAL:DatabaseAccess
    {
        public List<SignupDTO> GetAllSignup()
        {
            List<SignupDTO> listSignup = new List<SignupDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM SIGNUP ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string classId = reader.GetString(1);
                string status = reader.GetString(2);

                SignupDTO signup = new SignupDTO(studentId, classId, status);
                listSignup.Add(signup);
            }

            reader.Close();
            this.Close();
            return listSignup;
        }

        public List<SignupDTO> GetAllSignup(string _studentId)
        {
            List<SignupDTO> listSignup = new List<SignupDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM SIGNUP where STUDENT_ID = " + _studentId;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string classId = reader.GetString(1);
                string status = reader.GetString(2);

                SignupDTO signup = new SignupDTO(studentId, classId, status);
                listSignup.Add(signup);
            }

            reader.Close();
            this.Close();
            return listSignup;
        }

        public bool InsertSignup(SignupDTO signup)
        {
            this.ConnectToDatabase();

            string Query = "insert into SIGNUP values('" + signup.StudentId + "','" + signup.ClassId + "','" + signup.Status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool InsertSignup(string studentId, string testId, string status)
        {
            this.ConnectToDatabase();

            string Query = "insert into SIGNUP(STUDENT_ID,CLASS_ID,STATUS) values('" + studentId + "','" + testId + "','" + status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateSignup(SignupDTO signup)
        {
            this.ConnectToDatabase();

            string Query = "update SIGNUP set STUDENT_ID='" + signup.StudentId + "',CLASS_ID = '" + signup.ClassId + "',STATUS = '" + signup.Status + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
