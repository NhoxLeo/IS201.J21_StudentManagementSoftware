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
                string _classId = reader.GetString(0);
                string _className = reader.GetString(1);
                int _classCount = reader.GetInt32(2);

                ClassDTO _class = new ClassDTO(_classId, _className, _classCount);
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
                string _classId = reader.GetString(0);
                string _className = reader.GetString(1);
                int _classCount = reader.GetInt32(2);

                ClassDTO _class = new ClassDTO(_classId, _className, _classCount);
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
                string _classId = reader.GetString(0);
                string _className = reader.GetString(1);
                int _classCount = reader.GetInt32(2);

                _class = new ClassDTO(_classId, _className, _classCount);
                return _class;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertClass(ClassDTO _class)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASS values('" + _class.ClassId + "','" + _class.ClassName + "','" + _class.ClassCount + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertClass(string _classId, string _className, int _classCount)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASS(CLASS_ID,CLASS_NAME,CLASS_COUNT) values('" + _classId + "','" + _className + "','" + _classCount + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateClass(ClassDTO _class)
        {
            this.ConnectToDatabase();

            string Query = "update CLASS set CLASS_ID='" + _class.ClassId + "',CLASS_NAME = '" + _class.ClassName + "',CLASS_COUNT = '" + _class.ClassCount + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
