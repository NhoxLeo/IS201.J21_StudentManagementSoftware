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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            InitTestData();
        }
        void InitTestData()
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            dgvListTest.DataSource = testDTOs;

        }

        private void btAddTest_Click(object sender, EventArgs e)
        {
            AddTestForm f = new AddTestForm();
            this.Hide();
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTestForm f = new EditTestForm();
            this.Hide();
            f.Show();
        }
    }
}
