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
        }
        void LoadDataGridTest()
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            dgvListTest.DataSource = testDTOs;
        }

        private void btAddClass_Click(object sender, EventArgs e)
        {
            AddTestForm f = new AddTestForm();
            f.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTestForm f = new EditTestForm();
            f.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TestDTO currentObject = (TestDTO)dgvListTest.CurrentRow.DataBoundItem;
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            testDAL.DeleteSignup(currentObject.TestId);

        }
    }
}
