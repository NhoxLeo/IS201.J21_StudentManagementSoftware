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
    public partial class AddOfficalStudentForm : Form
    {
        public AddOfficalStudentForm()
        {
            InitializeComponent();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            studentDAL.InsertStudent(textboxStudentID.Text, textboxStudentName.Text, textboxStudentMail.Text, textboxStudentAddress.Text, textboxStudentPhoneNumber.Text, birthDateTimePicker.Value);
        }

    }
}
