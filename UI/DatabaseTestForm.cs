using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UI
{
    public partial class DatabaseTestForm : Form
    {
        public DatabaseTestForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query = textBox.Text;
            if (query == "")
            {
                MessageBox.Show("yo type some manageble query please!");
                return;
            }
            string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=testing";
            MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);

            MySqlCommand commandDb = new MySqlCommand(query, databaseConnection);
            commandDb.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDb.ExecuteReader();
                if (myReader.HasRows)
                {
                    MessageBox.Show("See ur Results:");
                    while (myReader.Read())
                    {
                        Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("Query Exed");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error" + e.Message);
            }
        }
    }
}
