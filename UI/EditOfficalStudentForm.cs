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
            try
            {
               StudentDTO studentDTO = new StudentDTO(textboxStudentID.Text, textboxStudentName.Text, textboxStudentMail.Text, textboxStudentAddress.Text, textboxStudentPhoneNumber.Text, birthDateTimePicker.Value);
               if( studentDAL.UpdateStudent(studentDTO))
                {
                    MessageBox.Show("Thay đổi thông tin học viên thành công!!!");
                    this.Close();
                    OfficalStudentForm f = new OfficalStudentForm();
                    f.Show();
                }
            }
            catch
            {
                MessageBox.Show("Thay đổi thất bại, kiểm tra lại thông tin!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficalStudentForm f = new OfficalStudentForm();
            f.Show();
        }
    }
}
