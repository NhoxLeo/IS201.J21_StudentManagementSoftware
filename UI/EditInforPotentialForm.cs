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

namespace DTO
{
    public partial class EditInforPotentialForm : Form
    {
        public EditInforPotentialForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            PotentialStudentDTO potentialStudentDTO = new PotentialStudentDTO(textboxPotentialStudentID.Text, textboxPotentialStudentName.Text, int.Parse(textboxPotentialStudentInputScore.Text), textboxPotentialStudentPhoneNumber.Text, int.Parse(textboxPotentialStudentAppointmentCount.Text), dropboxStatus.ValueMember);
            potentialStudentDAL.UpdatePotentialStudent(potentialStudentDTO);
        }
    }
}
