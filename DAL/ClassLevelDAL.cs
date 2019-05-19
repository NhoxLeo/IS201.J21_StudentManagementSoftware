using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ClassLevelDAL:DatabaseAccess
    {
        public List<ClassLevelDTO> GetAllClassLevel()
        {
            List<ClassLevelDTO> listClassLevel = new List<ClassLevelDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSLEVEL ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classlevelId = reader.GetString(0);
                string classlevelName = reader.GetString(1);

                ClassLevelDTO classlevel = new ClassLevelDTO(classlevelId, classlevelName);
                listClassLevel.Add(classlevel);
            }

            reader.Close();
            this.Close();
            return listClassLevel;
        }

        public List<ClassLevelDTO> GetAllClassLevel(string classlevel_Id)
        {
            List<ClassLevelDTO> listClassLevel = new List<ClassLevelDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSLEVEL where CLASSLEVEL_ID = " + classlevel_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classlevelId = reader.GetString(0);
                string classlevelName = reader.GetString(1);

                ClassLevelDTO classlevel = new ClassLevelDTO(classlevelId, classlevelName);
                listClassLevel.Add(classlevel);
            }

            reader.Close();
            this.Close();
            return listClassLevel;
        }

        public ClassLevelDTO GetClassLevel(string id)
        {
            ClassLevelDTO classlevel;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSLEVEL WHERE CLASSLEVEL_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classlevelId = reader.GetString(0);
                string classlevelName = reader.GetString(1);

                classlevel = new ClassLevelDTO(classlevelId, classlevelName);
                return classlevel;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertClassLevel(ClassLevelDTO classlevel)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASSLEVEL values('" + classlevel.ClassLevelId + "','" + classlevel.ClassLevelName + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertClassLevel(string classlevelId, string classlevelName)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASSLEVEL(CLASSLEVEL_ID,CLASSLEVEL_NAME) values('" + classlevelId + "','" + classlevelName + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateClassLevel(ClassLevelDTO classlevel)
        {
            this.ConnectToDatabase();

            string Query = "update CLASSLEVEL set CLASSLEVEL_ID='" + classlevel.ClassLevelId + "',CLASSLEVEL_NAME = '" + classlevel.ClassLevelName + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
