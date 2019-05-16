using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BillDAL : DatabaseAccess
    {
        public List<BillDTO> GetAllBill()
        {
            List<BillDTO> listBill = new List<BillDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM BILL ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string billId = reader.GetString(0);
                int billPayment = reader.GetInt32(1);

                BillDTO bill = new BillDTO(billId, billPayment);
                listBill.Add(bill);
            }

            reader.Close();
            this.Close();
            return listBill;
        }

        public List<BillDTO> GetAllBill(int board_Id)
        {
            List<BillDTO> listBill = new List<BillDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM BILL where BOARD_ID = " + board_Id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string billId = reader.GetString(0);
                int billPayment = reader.GetInt32(1);

                BillDTO bill = new BillDTO(billId,billPayment);
                listBill.Add(bill);
            }

            reader.Close();
            this.Close();
            return listBill;
        }

        public BillDTO GetBill(int id)
        {
            BillDTO bill;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM BILL WHERE BILL_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string billId = reader.GetString(0);
                int billPayment = reader.GetInt32(1);


                bill = new BillDTO(billId, billPayment);
                return bill;
            }

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertBill(BillDTO bill)
        {
            this.ConnectToDatabase();

            string Query = "insert into BILL values('" + bill.BillId + "','" + bill.BillPayment + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool InsertBill(string billId , int billPayment)
        {
            this.ConnectToDatabase();

            string Query = "insert into BILL(BILL_ID,BILL_PAYMENT) values('" + billId + "','" + billPayment + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool UpdateBill(BillDTO bill)
        {
            this.ConnectToDatabase();

            string Query = "update BILL set BILL_ID='" + bill.BillId + "',BILL_PAYMENT = '" + bill.BillPayment + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
