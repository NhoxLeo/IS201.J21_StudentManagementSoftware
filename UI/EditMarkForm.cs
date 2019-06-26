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
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();
            LoadComboBoxStudentAndClass();
        }
        public EditMarkForm(string _studnentId,string _testId)
        {
            InitializeComponent();
            LoadComboBoxStudentAndClass();
        }
        void LoadComboBoxStudentAndClass()
        {

            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            comboBoxListTestId.DataSource = testDTOs;
            comboBoxListTestId.DisplayMember = "TestName";
            comboBoxListTestId.ValueMember = "TestId";

            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            comboBoxListDtudentId.DataSource = studentDTOs;
            comboBoxListDtudentId.DisplayMember = "StudentName";
            comboBoxListDtudentId.ValueMember = "StudentId";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MarkDAL markDAL = new MarkDAL();
            markDAL.ConnectToDatabase();
            markDAL.InsertMark(((StudentDTO)comboBoxListDtudentId.SelectedItem).StudentId, ((TestDTO)comboBoxListTestId.SelectedItem).ClassId, float.Parse(textBoxMark.Text));
        }
    }
}
