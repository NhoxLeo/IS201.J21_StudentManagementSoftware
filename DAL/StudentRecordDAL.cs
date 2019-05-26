using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class StudentRecordDAL : DatabaseAccess
    {
        public List<StudentRecordDTO> GetAllStudentRecord()
        {
            List<StudentRecordDTO> listStudentRecord = new List<StudentRecordDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENTRECORD ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentrecordId = reader.GetString(0);
                int studentRecord = reader.GetInt32(1);

                StudentRecordDTO studentrecord = new StudentRecordDTO(studentrecordId, studentRecord);
                listStudentRecord.Add(studentrecord);
            }

            reader.Close();
            this.Close();
            return listStudentRecord;
        }

        public List<StudentRecordDTO> GetAllStudentRecord(string studentrecord_Id)
        {
            List<StudentRecordDTO> listStudentRecord = new List<StudentRecordDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENTRECORD where STUDENTRECORD_ID = " + studentrecord_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentrecordId = reader.GetString(0);
                int studentRecord = reader.GetInt32(1);

                StudentRecordDTO studentrecord = new StudentRecordDTO(studentrecordId, studentRecord);
                listStudentRecord.Add(studentrecord);
            }

            reader.Close();
            this.Close();
            return listStudentRecord;
        }

        public StudentRecordDTO GetStudentRecord(string id)
        {
            StudentRecordDTO studentrecord;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM STUDENTRECORD WHERE STUDENTRECORD_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentrecordId = reader.GetString(0);
                int studentRecord = reader.GetInt32(1);

                studentrecord = new StudentRecordDTO(studentrecordId, studentRecord);
                return studentrecord;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertStudentRecord(StudentRecordDTO studentrecord)
        {
            this.ConnectToDatabase();

            string Query = "insert into STUDENTRECORD values('" + studentrecord.StudentRecordId + "','" + studentrecord.StudentRecord + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertStudentRecord(string studentrecordId, int studentRecord)
        {
            this.ConnectToDatabase();

            string Query = "insert into STUDENTRECORD(STUDENTRECORD_ID,STUDENTRECORDS) values('" + studentrecordId + "','" + studentRecord + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateStudentRecord(StudentRecordDTO studentrecord)
        {
            this.ConnectToDatabase();

            string Query = "update STUDENTRECORD set STUDENTRECORD_ID='" + studentrecord.StudentRecordId + "',STUDENTRECORDS = '" + studentrecord.StudentRecord + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
