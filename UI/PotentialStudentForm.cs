using DTO;
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
    public partial class PotentialStudentForm : Form
    {
        public PotentialStudentForm()
        {
            InitializeComponent();
            InitPotentialStudentData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPotentialStudentForm f = new AddPotentialStudentForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
            EditInforPotentialForm f = new EditInforPotentialForm(currentObject);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dgvListPotentialStudent.SelectedRows.Count > 0)
            {
                PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
                potentialStudentDAL.ConnectToDatabase();
                PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
                if (potentialStudentDAL.DeletePotentialStudent(currentObject.PotentialStudentId))
                {
                    potentialStudentDAL = new PotentialStudentDAL();
                    potentialStudentDAL.ConnectToDatabase();
                    dgvListPotentialStudent.DataSource = potentialStudentDAL.GetAllPotentialStudent();
                    dgvListPotentialStudent.Update();
                    dgvListPotentialStudent.Refresh();
                }
            }
            //DeletePotentialStudentForm f = new DeletePotentialStudentForm();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //print
        }

        private void dtgvListPotentialStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void InitPotentialStudentData()
        {
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            List<PotentialStudentDTO> potentialStudentDTOs = potentialStudentDAL.GetAllPotentialStudent();
            dgvListPotentialStudent.DataSource = potentialStudentDTOs;
        }
    }
}
