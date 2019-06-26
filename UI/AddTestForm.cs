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
    public partial class AddTestForm : Form
    {
        public AddTestForm()
        {
            InitializeComponent();
            LoadComboBoxTest();
        }
        void LoadComboBoxTest()
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            textboxTestId.Text ="TE" + (testDTOs.Count + 1).ToString();
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            comboBoxListClassId.DataSource = classDTOs;
            comboBoxListClassId.DisplayMember = "ClassName";
            comboBoxListClassId.ValueMember = "ClassId";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            testDAL.InsertTest(textboxTestId.Text,((ProgramDTO)comboBoxListClassId.SelectedItem).ProgramId.ToString(), dateTimePicker1.Value, textBox1.Text);
        }
    }
}
