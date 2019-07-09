using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class MarkDAL : DatabaseAccess
    {
        public List<MarkDTO> GetAllMark()
        {
            List<MarkDTO> listMark = new List<MarkDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM MARK ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string testId = reader.GetString(1);
                float grade = reader.GetFloat(2);

                MarkDTO mark = new MarkDTO(studentId, testId, grade);
                listMark.Add(mark);
            }

            reader.Close();
            this.Close();
            return listMark;
        }

        public List<MarkDTO> GetAllMark(string _studentId)
        {
            List<MarkDTO> listMark = new List<MarkDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM MARK where STUDENT_ID = " + _studentId;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentId = reader.GetString(0);
                string testId = reader.GetString(1);
                float grade = reader.GetFloat(2);

                MarkDTO mark = new MarkDTO(studentId, testId, grade);
                listMark.Add(mark);
            }

            reader.Close();
            this.Close();
            return listMark;
        }

        public bool InsertMark(MarkDTO mark)
        {
            this.ConnectToDatabase();

            string Query = "insert into MARK values('" + mark.StudentId + "','" + mark.TestId + "','" + mark.Grade + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool InsertMark(string studentId, string testId, float grade)
        {
            this.ConnectToDatabase();

            string Query = "insert into MARK(STUDENT_ID,TEST_ID,GRADE) values('" + studentId + "','" + testId + "','" + grade + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateMark(MarkDTO mark)
        {
            this.ConnectToDatabase();

            string Query = "update MARK set STUDENT_ID='" + mark.StudentId + "',TEST_ID = '" + mark.TestId + "',GRADE = '" + mark.Grade + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
