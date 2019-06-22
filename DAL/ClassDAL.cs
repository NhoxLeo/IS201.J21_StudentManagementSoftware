using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ClassDAL:DatabaseAccess
    {
        public List<ClassDTO> GetAllClass()
        {
            List<ClassDTO> listClass = new List<ClassDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASS ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classId = reader.GetString(0);
                string className = reader.GetString(1);
                string teacherId = reader.GetString(2);
                string startHour = reader.GetString(3);
                DateTime startDate = reader.GetDateTime(4);
                DateTime endDate = reader.GetDateTime(5);
                string programId = reader.GetString(6);

                ClassDTO _class = new ClassDTO(classId,className, teacherId, startHour, startDate, endDate, programId);
                listClass.Add(_class);
            }

            reader.Close();
            this.Close();
            return listClass;
        }

        public List<ClassDTO> GetAllClass(string _class_Id)
        {
            List<ClassDTO> listClass = new List<ClassDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASS where CLASS_ID = " + _class_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classId = reader.GetString(0);
                string className = reader.GetString(1);
                string teacherId = reader.GetString(2);
                string startHour = reader.GetString(3);
                DateTime startDate = reader.GetDateTime(4);
                DateTime endDate = reader.GetDateTime(5);
                string programId = reader.GetString(6);

                ClassDTO _class = new ClassDTO(classId, className, teacherId, startHour, startDate, endDate, programId);
                listClass.Add(_class);
            }

            reader.Close();
            this.Close();
            return listClass;
        }

        public ClassDTO GetClass(string id)
        {
            ClassDTO _class;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASS WHERE CLASS_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classId = reader.GetString(0);
                string className = reader.GetString(1);
                string teacherId = reader.GetString(2);
                string startHour = reader.GetString(3);
                DateTime startDate = reader.GetDateTime(4);
                DateTime endDate = reader.GetDateTime(5);
                string programId = reader.GetString(6);

                _class = new ClassDTO(classId, className, teacherId, startHour, startDate, endDate, programId);
                return _class;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertClass(ClassDTO _class)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASS values('" + _class.ClassId + "','" + _class.ClassName + "','" + _class.TeacherId + "','" + _class.StartHour + "','" + _class.StartDate.ToString("yyyy'-'MM'-'dd") + "','" + _class.EndDate.ToString("yyyy'-'MM'-'dd") + "','" + _class.ProgramId + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertClass(string classId, string className, string teacherId, string startHour, DateTime startDate, DateTime endDate, string programId)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASS(CLASS_ID,CLASS_NAME,TEACHER_ID,START_HOUR,START_DATE,END_DATE,PROGRAM_ID) values('" + classId + "','" + className + "','" + teacherId + "','" + startHour + "','" + startDate.ToString("yyyy'-'MM'-'dd") + "','" + endDate.ToString("yyyy'-'MM'-'dd") + "','" + programId + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateClass(ClassDTO _class)
        {
            this.ConnectToDatabase();

            string Query = "update CLASS set CLASS_ID='" + _class.ClassId + "',CLASS_NAME = '" + _class.ClassName + "',TEACHER_ID = '" + _class.TeacherId + "',START_HOUR = '" + _class.StartHour  +"',START_DATE = '" + _class.StartDate + "',END_DATE = '" + _class.EndDate + "',PROGRAM_ID = '" + _class.ProgramId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
        public bool DeleteClass(string classId)
        {
            this.ConnectToDatabase();

            string Query = "DELETE FROM CLASS WHERE CLASS_ID='" + classId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
    }
}
