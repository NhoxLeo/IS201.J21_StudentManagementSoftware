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
            this.Close();
          
            PotentialStudentForm f = new PotentialStudentForm();
            f.Show();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
            PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            // string idd = currentObject.PotentialStudentId;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc xoá học viên:" + currentObject.PotentialStudentId,"",MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
                {
                
                potentialStudentDAL.DeletePotentialStudent(currentObject.PotentialStudentId);
                
                MessageBox.Show("Xoá học viên thành công!!!");
                this.Close();
                DeletePotentialStudentForm f = new DeletePotentialStudentForm();
                f.Show();

            }
            else if(dialogResult==DialogResult.No)
            {

            }
        }
    }
}
