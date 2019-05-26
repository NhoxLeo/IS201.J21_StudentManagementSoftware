using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DatabaseAccess
    {
        private string serverName;
        private string databaseName;
        private string userName;
        private string passWord;

        public string ServerName { get => serverName; set => serverName = value; }
        public string DatabaseName { get => databaseName; set => databaseName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        protected MySqlConnection mySQLConnection = null;

        public DatabaseAccess()
        {
            this.serverName = "remotemysql.com";
            this.databaseName = "AGQbqYyMIL";
            this.userName = "AGQbqYyMIL";
            this.passWord = "nEc0CIMxB0";
        }
        public DatabaseAccess(string _servrName, string _databaseName, string _userName,string _passWord)
        {
            this.serverName = _servrName;
            this.databaseName = _databaseName;
            this.userName = _userName;
            this.passWord = _passWord;
        }

        public bool ConnectToDatabase()
        {
            if (mySQLConnection == null)
            {
                if (String.IsNullOrEmpty(this.databaseName))
                    return false;

                string conStr = string.Format("Server={0}; Port=3306; database={1}; UID={2}; password={3}", serverName, databaseName, userName, passWord);
                string connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUAN_LI_HOC_VIEN;Integrated Security=True";
                mySQLConnection = new MySqlConnection(conStr);
                mySQLConnection.Open();

                if (mySQLConnection.State == ConnectionState.Open)
                {
                    return true;
                }
            }
            return false;
        }

        public void Close()
        {
            mySQLConnection.Close();
        }
    }
}
