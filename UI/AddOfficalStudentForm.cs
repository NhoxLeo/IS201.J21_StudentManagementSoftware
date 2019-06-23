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
        string ID_CHAR = "ST";
        public AddOfficalStudentForm()
        {
            InitializeComponent();
            PontentialStudentDAL studentDAL = new PontentialStudentDAL();
            studentDAL.ConnectToDatabase();
            textboxStudentID.Text = ID_CHAR + (studentDAL.GetAllStudent().Count + 1).ToString();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            PontentialStudentDAL studentDAL = new PontentialStudentDAL();
            studentDAL.ConnectToDatabase();
            if(studentDAL.InsertStudent(textboxStudentID.Text, textboxStudentName.Text, textboxStudentMail.Text, textboxStudentAddress.Text, textboxStudentPhoneNumber.Text, birthDateTimePicker.Value))
            {
                MessageBox.Show("Success");
                this.Close();
            }
        }

        private void textboxStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
