using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class PotentialStudentDAL:DatabaseAccess
    {
        public List<PotentialStudentDTO> GetAllPotentialStudent()
        {
            List<PotentialStudentDTO> listPotentialStudent = new List<PotentialStudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM POTENTIAL_STUDENT ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string potentialstudentId = reader.GetString(0);
                string potentialstudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                PotentialStudentDTO potentialstudent = new PotentialStudentDTO(potentialstudentId, potentialstudentName, mark, phone, dateCount, status);
                listPotentialStudent.Add(potentialstudent);
            }

            reader.Close();
            this.Close();
            return listPotentialStudent;
        }

        public List<PotentialStudentDTO> GetAllPotentialStudent(string potentialstudent_Id)
        {
            List<PotentialStudentDTO> listPotentialStudent = new List<PotentialStudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM POTENTIAL_STUDENT where POTENTIAL_STUDENT_ID = " + potentialstudent_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string potentialstudentId = reader.GetString(0);
                string potentialstudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                PotentialStudentDTO potentialstudent = new PotentialStudentDTO(potentialstudentId, potentialstudentName, mark, phone, dateCount, status);
                listPotentialStudent.Add(potentialstudent);
            }

            reader.Close();
            this.Close();
            return listPotentialStudent;
        }

        public PotentialStudentDTO GetPotentialStudent(string id)
        {
            PotentialStudentDTO potentialstudent;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM POTENTIAL_STUDENT WHERE POTENTIAL_STUDENT_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string potentialstudentId = reader.GetString(0);
                string potentialstudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                potentialstudent = new PotentialStudentDTO(potentialstudentId, potentialstudentName, mark, phone, dateCount, status);
                return potentialstudent;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertPotentialStudent(PotentialStudentDTO potentialstudent)
        {
            this.ConnectToDatabase();

            string Query = "insert into POTENTIAL_STUDENT values('" + potentialstudent.PotentialStudentId + "','" + potentialstudent.PotentialStudentName + "','" + potentialstudent.Mark + "','" + potentialstudent.Phone + "','" + potentialstudent.DateCount + "','" + potentialstudent.Status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertPotentialStudent(string potentialstudentId, string potentialstudentName, float mark, string phone, int dateCount, string status)
        {
            this.ConnectToDatabase();

            string Query = "insert into POTENTIAL_STUDENT(POTENTIAL_STUDENT_ID,POTENTIAL_STUDENT_NAME,MARK,PHONE,DATE_COUNT,STATUS) values('" + potentialstudentId + "','" + potentialstudentName + "','" + mark + "','" + phone + "','" + dateCount + "','" + status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdatePotentialStudent(PotentialStudentDTO potentialstudent)
        {
            this.ConnectToDatabase();

            string Query = "update POTENTIAL_STUDENT set POTENTIAL_STUDENT_ID='" + potentialstudent.PotentialStudentId + "',POTENTIAL_STUDENT_NAME = '" + potentialstudent.PotentialStudentName + "',MARK = '" + potentialstudent.Mark + "',PHONE = '" + potentialstudent.Phone + "',DATE_COUNT = '" + potentialstudent.DateCount + "',STATUS = '" + potentialstudent.Status + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
