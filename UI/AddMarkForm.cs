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
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            comboBoxListClassId.DataSource = classDTOs;
            comboBoxListClassId.DisplayMember = "ClassName";
            comboBoxListClassId.ValueMember = "ClassId";

            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            comboBoxListDtudentId.DataSource = studentDTOs;
            comboBoxListDtudentId.DisplayMember = "StudentName";
            comboBoxListDtudentId.ValueMember = "StudentId";
        }
    }
}
