using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class TestDAL:DatabaseAccess
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
                DateTime testDate = reader.GetDateTime(1);

                TestDTO test = new TestDTO(testId, testDate);
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
                DateTime testDate = reader.GetDateTime(1);

                TestDTO test = new TestDTO(testId, testDate);
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
                DateTime testDate = reader.GetDateTime(1);


                test = new TestDTO(testId, testDate);
                return test;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertTest(TestDTO test)
        {
            this.ConnectToDatabase();

            string Query = "insert into TEST values('" + test.TestId + "','" + test.TestDate + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertTest(string testId, DateTime testDate)
        {
            this.ConnectToDatabase();

            string Query = "insert into TEST(TEST_ID,TEST_DATE) values('" + testId + "','" + testDate + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateTest(TestDTO test)
        {
            this.ConnectToDatabase();

            string Query = "update TEST set TEST_ID='" + test.TestId + "',TEST_DATE = '" + test.TestDate + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
