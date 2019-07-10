using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class UserDAL : DatabaseAccess
    {
        public bool InsertUser(UserDTO user)
        {
            this.ConnectToDatabase();
            string Query = "insert into USER(USER_ID, USER_NAME, PASSWORD,DEPARTMENT) values('" + user.UserId + "','" + user.UserName + "','" + user.Password + "','" + user.Department + "');";
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);
            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
        public bool InsertUser(string userId, string userName, string password,string department)
        {
            this.ConnectToDatabase();

            string Query = "insert into USER(USER_ID,USER_NAME,PASSWORD,DEPARTMENT) values('" + userId + "','" + userName + "','" + password + "','" + department + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
        public List<UserDTO> GetAllUser()
        {
            List<UserDTO> listUser = new List<UserDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USER ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string UserId = reader.GetString(0);
                string UserName = reader.GetString(1);
                string UserPassword = reader.GetString(2);
                string Department = reader.GetString(3);

                UserDTO User = new UserDTO(UserId, UserName, UserPassword, Department);
                listUser.Add(User);
            }

            reader.Close();
            this.Close();
            return listUser;
        }
        public UserDTO GetUser(string _username)
        {
            UserDTO listUser = new UserDTO("","","","");

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USER where USER_NAME = '" + _username + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string UserId = reader.GetString(0);
                string UserName = reader.GetString(1);
                string UserPassword = reader.GetString(2);
                string Department = reader.GetString(3);

                UserDTO User = new UserDTO(UserId, UserName, UserPassword, Department);
                listUser = User;
            }

            reader.Close();
            this.Close();
            return listUser;
        }
    }
}
