using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ReserveReserveStudentDAL:DatabaseAccess
    {
        public List<ReserveStudentDTO> GetAllReserveStudent()
        {
            List<ReserveStudentDTO> listReserveStudent = new List<ReserveStudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM RESERVE_STUDENT ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string reservestudentId = reader.GetString(0);
                string reservestudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                ReserveStudentDTO reservestudent = new ReserveStudentDTO(reservestudentId, reservestudentName, mark, phone, dateCount, status);
                listReserveStudent.Add(reservestudent);
            }

            reader.Close();
            this.Close();
            return listReserveStudent;
        }

        public List<ReserveStudentDTO> GetAllReserveStudent(string reservestudent_Id)
        {
            List<ReserveStudentDTO> listReserveStudent = new List<ReserveStudentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM RESERVE_STUDENT where RESERVE_STUDENT_ID = " + reservestudent_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string reservestudentId = reader.GetString(0);
                string reservestudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                ReserveStudentDTO reservestudent = new ReserveStudentDTO(reservestudentId, reservestudentName, mark, phone, dateCount, status);
                listReserveStudent.Add(reservestudent);
            }

            reader.Close();
            this.Close();
            return listReserveStudent;
        }

        public ReserveStudentDTO GetReserveStudent(string id)
        {
            ReserveStudentDTO reservestudent;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM RESERVE_STUDENT WHERE RESERVE_STUDENT_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string reservestudentId = reader.GetString(0);
                string reservestudentName = reader.GetString(1);
                float mark = reader.GetFloat(2);
                string phone = reader.GetString(3);
                int dateCount = reader.GetInt32(4);
                string status = reader.GetString(5);

                reservestudent = new ReserveStudentDTO(reservestudentId, reservestudentName, mark, phone, dateCount, status);
                return reservestudent;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertReserveStudent(ReserveStudentDTO reservestudent)
        {
            this.ConnectToDatabase();

            string Query = "insert into RESERVE_STUDENT values('" + reservestudent.ReserveStudentId + "','" + reservestudent.ReserveStudentName + "','" + reservestudent.Mark + "','" + reservestudent.Phone + "','" + reservestudent.DateCount + "','" + reservestudent.Status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertReserveStudent(string reservestudentId, string reservestudentName, float mark, string phone, int dateCount, string status)
        {
            this.ConnectToDatabase();

            string Query = "insert into RESERVE_STUDENT(RESERVE_STUDENT_ID,RESERVE_STUDENT_NAME,MARK,PHONE,DATE_COUNT,STATUS) values('" + reservestudentId + "','" + reservestudentName + "','" + mark + "','" + phone + "','" + dateCount + "','" + status + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateReserveStudent(ReserveStudentDTO reservestudent)
        {
            this.ConnectToDatabase();

            string Query = "update RESERVE_STUDENT set RESERVE_STUDENT_ID='" + reservestudent.ReserveStudentId + "',RESERVE_STUDENT_NAME = '" + reservestudent.ReserveStudentName + "',MARK = '" + reservestudent.Mark + "',PHONE = '" + reservestudent.Phone + "',DATE_COUNT = '" + reservestudent.DateCount + "',STATUS = '" + reservestudent.Status + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
