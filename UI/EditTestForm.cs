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
    public partial class EditTestForm : Form
    {
        TestDTO testDTO;
        public EditTestForm()
        {
            InitializeComponent();
        }
        public EditTestForm(TestDTO _testDTO)
        {
            InitializeComponent();
            TestdateTimePicker.Value = _testDTO.TestDate;
            startingHour.Text = _testDTO.TestHour;
            testDTO.ClassId = _testDTO.ClassId;
            testDTO.TestId = _testDTO.TestId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            testDTO.TestDate = TestdateTimePicker.Value;

            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            TestDTO tempTestDTO = new TestDTO(testDTO.TestId,testDTO.ClassId,TestdateTimePicker.Value,startingHour.Text);
            testDAL.UpdateTest(tempTestDTO);
        }
    }
}
