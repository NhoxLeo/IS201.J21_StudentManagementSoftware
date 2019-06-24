using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class PontentialStudentDAL : DatabaseAccess
    {
        public List<StudentDTO> GetAllStudent()
        {
            List<StudentDTO> listStudent = new List<StudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENT ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string studentMail = reader.GetString(2);
                string studentAddress = reader.GetString(3);
                string studentPhone = reader.GetString(4);
                DateTime studentBirthDate = reader.GetDateTime(5);

                StudentDTO student = new StudentDTO(studentId, studentName, studentMail, studentAddress, studentPhone, studentBirthDate);
                listStudent.Add(student);
            }

            reader.Close();
            this.Close();
            return listStudent;
        }

        public List<StudentDTO> GetAllStudent(string student_Id)
        {
            List<StudentDTO> listStudent = new List<StudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENT where STUDENT_ID = '" + student_Id + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string studentMail = reader.GetString(2);
                string studentAddress = reader.GetString(3);
                string studentPhone = reader.GetString(4);
                DateTime studentBirthDate = reader.GetDateTime(5);

                StudentDTO student = new StudentDTO(studentId, studentName, studentMail, studentAddress, studentPhone, studentBirthDate);
                listStudent.Add(student);
            }

            reader.Close();
            this.Close();
            return listStudent;
        }

        public StudentDTO GetStudent(string id)
        {
            StudentDTO student;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENT WHERE STUDENT_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string studentName = reader.GetString(1);
                string studentMail = reader.GetString(2);
                string studentAddress = reader.GetString(3);
                string studentPhone = reader.GetString(4);
                DateTime studentBirthDate = reader.GetDateTime(5);

                student = new StudentDTO(studentId, studentName, studentMail, studentAddress, studentPhone, studentBirthDate);
                return student;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertStudent(StudentDTO student)
        {
            this.ConnectToDatabase();

            string Query = "insert into STUDENT values('" + student.StudentId + "','" + student.StudentName + "','" + student.StudentMail + "','" + student.StudentAddress + "','" + student.StudentPhone + "','" + student.StudentBirthDate.ToString("yyyy'-'MM'-'dd") + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertStudent(string studentId, string studentName, string studentMail, string studentAddress, string studentPhone, DateTime studentBirthDate)
        {
            this.ConnectToDatabase();
            string Query = "insert into STUDENT(STUDENT_ID,STUDENT_NAME,MAIL,ADDRESS,PHONE,BIRTHDATE) values('" + studentId + "','" + studentName + "','" + studentMail + "','" + studentAddress + "','" + studentPhone + "','" + studentBirthDate.ToString("yyyy'-'MM'-'dd") + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateStudent(StudentDTO student)
        {
            this.ConnectToDatabase();

            string Query = "update STUDENT set STUDENT_ID='" + student.StudentId + "',STUDENT_NAME = '" + student.StudentName + "',MAIL = '" + student.StudentMail + "',ADDRESS = '" + student.StudentAddress + "',PHONE = '" + student.StudentPhone + "',BIRTHDATE = '" + student.StudentBirthDate + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
        public bool DeleteStudent(string id)
        {
            this.ConnectToDatabase();

            string Query = "DELETE FROM STUDENT WHERE STUDENT_ID='" + id + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
    }
}
