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
        public AddPotentialStudentForm()
        {
            InitializeComponent();
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
            potentialStudentDAL.InsertPotentialStudent(textboxPotentialStudentID.Text, textboxPotentialStudentName.Text,int.Parse(textboxPotentialStudentInputScore.Text),textboxPotentialStudentPhoneNumber.Text, int.Parse(textboxPotentialStudentAppointmentCount.Text), dropboxStatus.ValueMember);
        }
    }
}
