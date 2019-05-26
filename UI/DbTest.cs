using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace UI
{
    public partial class DbTest : Form
    {
        DatabaseAccess databaseAccess;
        public DbTest()
        {
            InitializeComponent();
        }
        private void runQuery()
        {
            if (databaseAccess == null) databaseAccess = new DatabaseAccess("remotemysql.com","AGQbqYyMIL", "AGQbqYyMIL", "nEc0CIMxB0");
            databaseAccess.ServerName = "remotemysql.com";
            databaseAccess.DatabaseName = "AGQbqYyMIL";
            databaseAccess.UserName = "AGQbqYyMIL";
            databaseAccess.PassWord = "nEc0CIMxB0";
            if (!databaseAccess.ConnectToDatabase()) MessageBox.Show("Database connection not available...");
            else MessageBox.Show("Database connection success...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (databaseAccess != null) databaseAccess.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string billId = "BI001";
            int billPayment = 10;
            BillDTO billDTO = new BillDTO(billId, billPayment);
            string TableQuery = "insert into BILL values('" + billDTO.BillId + "','" + billDTO.BillPayment + "');";
            BillDAL billDAL = new BillDAL();
            billDAL.InsertBill(billDTO);
        }
    }
}
