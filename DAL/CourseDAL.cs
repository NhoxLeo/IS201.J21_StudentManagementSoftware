using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class CourseDAL : DatabaseAccess
    {
        public List<CourseDTO> GetAllCourse()
        {
            List<CourseDTO> listCourse = new List<CourseDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COURSE ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string courseId = reader.GetString(0);
                DateTime courseYear = reader.GetDateTime(1);

                CourseDTO course = new CourseDTO(courseId, courseYear);
                listCourse.Add(course);
            }

            reader.Close();
            this.Close();
            return listCourse;
        }

        public List<CourseDTO> GetAllCourse(string course_Id)
        {
            List<CourseDTO> listCourse = new List<CourseDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COURSE where COURSE_ID = " + course_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string courseId = reader.GetString(0);
                DateTime courseYear = reader.GetDateTime(1);

                CourseDTO course = new CourseDTO(courseId, courseYear);
                listCourse.Add(course);
            }

            reader.Close();
            this.Close();
            return listCourse;
        }

        public CourseDTO GetCourse(string id)
        {
            CourseDTO course;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COURSE WHERE COURSE_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string courseId = reader.GetString(0);
                DateTime courseYear = reader.GetDateTime(1);

                course = new CourseDTO(courseId, courseYear);
                return course;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertCourse(CourseDTO course)
        {
            this.ConnectToDatabase();

            string Query = "insert into COURSE values('" + course.CourseId + "','" + course.CourseYear + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertCourse(string courseId, string courseYear)
        {
            this.ConnectToDatabase();

            string Query = "insert into COURSE(COURSE_ID,COURSE_YEAR) values('" + courseId + "','" + courseYear + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateCourse(CourseDTO course)
        {
            this.ConnectToDatabase();

            string Query = "update COURSE set COURSE_ID='" + course.CourseId + "',COURSE_YEAR = '" + course.CourseYear + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
