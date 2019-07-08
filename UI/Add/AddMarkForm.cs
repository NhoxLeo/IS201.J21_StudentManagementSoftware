using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace UI
{
    public partial class AddMarkForm : Form
    {
        string StudentId;
        public AddMarkForm()
        {
            InitializeComponent();
        }
        public AddMarkForm(StudentDTO _studentDTO)
        {
            InitializeComponent();
            StudentId = _studentDTO.StudentId;
            LoadComboBoxTest();
            textBoxStudent.Text = _studentDTO.StudentName;
        }
        void LoadComboBoxTest()
        {
            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            comboBoxListTestId.DataSource = testDTOs;
            comboBoxListTestId.DisplayMember = "TestName";
            comboBoxListTestId.ValueMember = "TestId";

            //StudentDAL studentDAL = new StudentDAL();
            //studentDAL.ConnectToDatabase();
            //List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            //comboBoxListDtudentId.DataSource = studentDTOs;
            //comboBoxListDtudentId.DisplayMember = "StudentName";
            //comboBoxListDtudentId.ValueMember = "StudentId";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MarkDAL markDAL = new MarkDAL();
            markDAL.ConnectToDatabase();
            markDAL.InsertMark(StudentId, ((TestDTO)comboBoxListTestId.SelectedItem).TestId, float.Parse(textboxMark.Text));
        }

        private void comboBoxListDtudentId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxListClassId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
