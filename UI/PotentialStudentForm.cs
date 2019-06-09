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

        private void label2_Click(object sender, EventArgs e)
        {

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
            EditInforPotentialForm f = new EditInforPotentialForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletePotentialStudentForm f = new DeletePotentialStudentForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void dtgvListPotentialStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void InitPotentialStudentData()
        {
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            //potentialStudentDAL.InsertPotentialStudent("RST1","Alex",8.0f,"0012295831",12,"Unpassed");
            List<PotentialStudentDTO> potentialStudentDTOs = potentialStudentDAL.GetAllPotentialStudent();
            dtgvListPotentialStudent.DataSource = potentialStudentDTOs;
        }
    }
}
