using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class TestDAL : DatabaseAccess
    {
        public List<TestDTO> GetAllTest()
        {
            List<TestDTO> listTest = new List<TestDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM TEST ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string testId = reader.GetString(0);
                string classId = reader.GetString(1);
                DateTime testDate = reader.GetDateTime(2);
                string testHour = reader.GetString(3);

                TestDTO test = new TestDTO(testId, classId, testDate, testHour);
                listTest.Add(test);
            }

            reader.Close();
            this.Close();
            return listTest;
        }

        public List<TestDTO> GetAllTest(string board_Id)
        {
            List<TestDTO> listTest = new List<TestDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM TEST where TEST_ID = " + board_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string testId = reader.GetString(0);
                string classId = reader.GetString(1);
                DateTime testDate = reader.GetDateTime(2);
                string testHour = reader.GetString(3);

                TestDTO test = new TestDTO(testId, classId, testDate, testHour);
                listTest.Add(test);
            }

            reader.Close();
            this.Close();
            return listTest;
        }

        public TestDTO GetTest(string id)
        {
            TestDTO test;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM TEST WHERE TEST_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string testId = reader.GetString(0);
                string classId = reader.GetString(1);
                DateTime testDate = reader.GetDateTime(2);
                string testHour = reader.GetString(3);

                test = new TestDTO(testId, classId, testDate, testHour);
                return test;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertTest(TestDTO test)
        {
            this.ConnectToDatabase();

            string Query = "insert into TEST values('" + test.TestId + "','" + test.ClassId + "','" + test.TestDate + "','" + test.TestHour + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertTest(string testId, string classId, DateTime testDate, string testHour)
        {
            this.ConnectToDatabase();

            string Query = "insert into TEST(TEST_ID,CLASS_ID,TEST_DATE,TEST_HOUR) values('" + testId + "','" + classId + "','" + testDate.ToString("yyyy'-'MM'-'dd") + "','" + testHour + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateTest(TestDTO test)
        {
            this.ConnectToDatabase();

            string Query = "update TEST set TEST_ID='" + test.TestId + "',CLASS_ID = '" + test.TestDate + "',TEST_DATE = '" + test.TestDate + "',TEST_HOUR = '" + test.TestDate + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
