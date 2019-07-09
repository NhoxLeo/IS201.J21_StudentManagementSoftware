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
             string Query = "insert into USER(USER_ID, USER_NAME, PASSWORD,DEPARTMENTvalues('" + user.User_Id + "','" + user.User_name + "','" + user.Password + "','" + user.Department + "');";
             MySqlCommand command = new MySqlCommand(Query, mySQLConnection);
             command.ExecuteNonQuery();

             this.Close();
             return true;
         }
     }
}
