using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ProgramDAL : DatabaseAccess
    {
        public List<ProgramDTO> GetAllProgram()
        {
            List<ProgramDTO> listProgram = new List<ProgramDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM PROGRAM ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string programId = reader.GetString(0);
                string classId = reader.GetString(1);
                int level = reader.GetInt32(2);
                int fee = reader.GetInt32(3);

                ProgramDTO program = new ProgramDTO(programId, classId, level, fee);
                listProgram.Add(program);
            }

            reader.Close();
            this.Close();
            return listProgram;
        }

        public List<ProgramDTO> GetAllProgram(string board_Id)
        {
            List<ProgramDTO> listProgram = new List<ProgramDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM PROGRAM where PROGRAM_ID = " + board_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string programId = reader.GetString(0);
                string classId = reader.GetString(1);
                int level = reader.GetInt32(2);
                int fee = reader.GetInt32(3);

                ProgramDTO program = new ProgramDTO(programId, classId, level, fee);
                listProgram.Add(program);
            }

            reader.Close();
            this.Close();
            return listProgram;
        }

        public ProgramDTO GetProgram(string id)
        {
            ProgramDTO program;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM PROGRAM WHERE PROGRAM_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string programId = reader.GetString(0);
                string classId = reader.GetString(1);
                int level = reader.GetInt32(2);
                int fee = reader.GetInt32(3);

                program = new ProgramDTO(programId, classId, level, fee);
                return program;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertProgram(ProgramDTO program)
        {
            this.ConnectToDatabase();

            string Query = "insert into PROGRAM values('" + program.ProgramId + "','" + program.ProgramName + "','" + program.Level + "','" + program.Fee + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertProgram(string programId, string programName, int level, int fee)
        {
            this.ConnectToDatabase();

            string Query = "insert into PROGRAM(PROGRAM_ID,PROGRAM_NAME,LEVEL,FEE) values('" + programId + "','" + programName + "','" + level + "','" + fee + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateProgram(ProgramDTO program)
        {
            this.ConnectToDatabase();

            string Query = "update PROGRAM set PROGRAM_ID='" + program.ProgramId + "',PROGRAM_NAME = '" + program.ProgramName + "',LEVEL = '" + program.Level + "',FEE = '" + program.Fee + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
