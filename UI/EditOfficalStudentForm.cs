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
    public partial class EditOfficalStudentForm : Form
    {
        public EditOfficalStudentForm()
        {
            InitializeComponent();
        }
        public EditOfficalStudentForm(StudentDTO _studentDTO)
        {
            InitializeComponent();
            textboxStudentID.Text = _studentDTO.StudentId;
            textboxStudentAddress.Text = _studentDTO.StudentAddress;
            textboxStudentMail.Text = _studentDTO.StudentMail;
            textboxStudentName.Text = _studentDTO.StudentName;
            textboxStudentPhoneNumber.Text = _studentDTO.StudentPhone;
            birthDateTimePicker.Value = _studentDTO.StudentBirthDate;
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            StudentDTO studentDTO = new StudentDTO(textboxStudentID.Text, textboxStudentName.Text, textboxStudentMail.Text, textboxStudentAddress.Text, textboxStudentPhoneNumber.Text, birthDateTimePicker.Value);
            studentDAL.UpdateStudent(studentDTO);
        }
    }
}
