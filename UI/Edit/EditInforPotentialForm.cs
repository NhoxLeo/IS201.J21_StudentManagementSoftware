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
using UI;

namespace DTO
{
    public partial class EditInforPotentialForm : Form
    {
        public EditInforPotentialForm()
        {
            InitializeComponent();
        }
        public EditInforPotentialForm(PotentialStudentDTO _potentialStudentDTO)
        {
            InitializeComponent();
            textboxPotentialStudentID.Text = _potentialStudentDTO.PotentialStudentId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            PotentialStudentForm f = new PotentialStudentForm();
            f.Show();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            PotentialStudentDTO potentialStudentDTO = new PotentialStudentDTO(textboxPotentialStudentID.Text, textboxPotentialStudentName.Text, int.Parse(textboxPotentialStudentInputScore.Text), textboxPotentialStudentPhoneNumber.Text, int.Parse(textboxPotentialStudentAppointmentCount.Text), dropboxStatus.Text,textboxPotentialStudentAddress.Text,dropboxPotentialStudentGender.Text);
            try
            {
                if (potentialStudentDAL.UpdatePotentialStudent(potentialStudentDTO))
                {
                    MessageBox.Show("Sửa thông tin học viên thành công!!!");
                    this.Hide();
                    PotentialStudentForm f = new PotentialStudentForm();
                    f.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại, Kiểm tra lại dữ liệu nhập vào!!!");
            };

        }
    }
}
