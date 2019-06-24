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
    public partial class AddPotentialStudentForm : Form
    {
        string ID_CHAR = "TN";
        public AddPotentialStudentForm()
        {
            string time=DateTime.Now.ToString("yyMMddhmmsstt");
            InitializeComponent();
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            textboxPotentialStudentID.Text = ID_CHAR+ time ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btConfim_Click(object sender, EventArgs e)
        {
           
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            try
            {
                if (potentialStudentDAL.InsertPotentialStudent(textboxPotentialStudentID.Text, textboxPotentialStudentName.Text, int.Parse(textboxPotentialStudentInputScore.Text), textboxPotentialStudentPhoneNumber.Text, int.Parse(textboxPotentialStudentAppointmentCount.Text), dropboxStatus.Text,textboxPotentialStudentAddress.Text,dropboxPotentialStudentGender.Text))
                {
                    MessageBox.Show("Thêm học viên thành công!!!");
                    this.Hide();
                    PotentialStudentForm f = new PotentialStudentForm();
                    f.Show();
                   
                }
            }
            catch (Exception) {
                MessageBox.Show("Thất bại, Kiểm tra lại dữ liệu nhập vào!!!");
                    };
           
        }

        private void textboxPotentialStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
