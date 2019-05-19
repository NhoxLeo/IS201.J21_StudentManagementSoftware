using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ClassTypeDAL : DatabaseAccess
    {
        public List<ClassTypeDTO> GetAllClassType()
        {
            List<ClassTypeDTO> listClassType = new List<ClassTypeDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSTYPE ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classtypeId = reader.GetString(0);
                string classtypeName = reader.GetString(1);
                DateTime startDate = reader.GetDateTime(2);
                int startingHour = reader.GetInt32(4);

                ClassTypeDTO classtype = new ClassTypeDTO(classtypeId, classtypeName, startDate, startingHour);
                listClassType.Add(classtype);
            }

            reader.Close();
            this.Close();
            return listClassType;
        }

        public List<ClassTypeDTO> GetAllClassType(string classtype_Id)
        {
            List<ClassTypeDTO> listClassType = new List<ClassTypeDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSTYPE where CLASSTYPE_ID = " + classtype_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classtypeId = reader.GetString(0);
                string classtypeName = reader.GetString(1);
                DateTime startDate = reader.GetDateTime(2);
                int startingHour = reader.GetInt32(4);

                ClassTypeDTO classtype = new ClassTypeDTO(classtypeId, classtypeName, startDate, startingHour);
                listClassType.Add(classtype);
            }

            reader.Close();
            this.Close();
            return listClassType;
        }

        public ClassTypeDTO GetClassType(string id)
        {
            ClassTypeDTO classtype;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CLASSTYPE WHERE CLASSTYPE_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classtypeId = reader.GetString(0);
                string classtypeName = reader.GetString(1);
                DateTime startDate = reader.GetDateTime(2);
                int startingHour = reader.GetInt32(4);

                classtype = new ClassTypeDTO(classtypeId, classtypeName, startDate, startingHour);
                return classtype;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertClassType(ClassTypeDTO classtype)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASSTYPE values('" + classtype.ClassTypeId + "','" + classtype.ClassTypeName + "','" + classtype.StartDate + "','" + classtype.StartingHour + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertClassType(string classtypeId,string classtypeName,DateTime startDate,int startingHour)
        {
            this.ConnectToDatabase();

            string Query = "insert into CLASSTYPE(CLASSTYPE_ID,CLASSTYPE_NAME,START_DATE,STARTING_HOUR) values('" + classtypeId + "','" + classtypeName + "','" + startDate + "','" + startingHour + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateClassType(ClassTypeDTO classtype)
        {
            this.ConnectToDatabase();

            string Query = "update CLASSTYPE set CLASSTYPE_ID='" + classtype.ClassTypeId + "',CLASSTYPE_NAME = '" + classtype.ClassTypeName + "',START_DATE = '" + classtype.StartDate + "',STARTING_HOUR = '" + classtype.StartingHour + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
