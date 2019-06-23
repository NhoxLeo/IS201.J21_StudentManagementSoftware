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
    public partial class DeletePotentialStudentForm : Form
    {
        public DeletePotentialStudentForm()
        {
            InitializeComponent();
            InitPotentialStudentData();
        }
        void InitPotentialStudentData()
        {
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            List<PotentialStudentDTO> potentialStudentDTOs = potentialStudentDAL.GetAllPotentialStudent();
            dgvListPotentialStudent.DataSource = potentialStudentDTOs;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            potentialStudentDAL.DeletePotentialStudent(currentObject.PotentialStudentId);
        }
    }
}
