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
        public AddMarkForm()
        {
            InitializeComponent();
        }
        void LoadComboBoxStudentAndClass()
        {

            TestDAL testDAL = new TestDAL();
            testDAL.ConnectToDatabase();
            List<TestDTO> testDTOs = testDAL.GetAllTest();
            comboBoxListClassId.DataSource = testDTOs;
            comboBoxListClassId.DisplayMember = "TestName";
            comboBoxListClassId.ValueMember = "TestId";

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
            markDAL.InsertMark(((StudentDTO)comboBoxListDtudentId.SelectedItem).StudentId,((TestDTO)comboBoxListClassId.SelectedItem).ClassId,float.Parse(textBoxMark.Text));
        }

        private void comboBoxListDtudentId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxListClassId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
