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
        string PREFIX_TEST_ID = "TS";
        public AddTestForm()
        {
            InitializeComponent();
            InitClassData();
        }
        void InitClassData()
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            cbClassId.DataSource = classDTOs;
            cbClassId.DisplayMember = "ClassName";
            cbClassId.ValueMember = "ClassId";
        }

        private void cbClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTestId.Text = PREFIX_TEST_ID + ((ClassDTO)cbClassId.SelectedItem).ClassId.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            try
            {
                if (testDAL.InsertTest(txtTestId.Text, ((ClassDTO)cbClassId.SelectedItem).ClassId, testDate.Value, txtTestHour.Text))
                {
                    MessageBox.Show("Thêm kì thi thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm kì thi thất bại!");
            }
            
        }
    }
}
