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
            this.Close();
            f.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sửa thôn tin học viên
            PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
            EditInforPotentialForm f = new EditInforPotentialForm(currentObject);
            this.Close();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //xoá học viên
            //if (this.dgvListPotentialStudent.SelectedRows.Count > 0)
            //{
            //    PotentialStudentDAL potentialStudentDAL = new PotentialStudentDAL();
            //    potentialStudentDAL.ConnectToDatabase();
            //    PotentialStudentDTO currentObject = (PotentialStudentDTO)dgvListPotentialStudent.CurrentRow.DataBoundItem;
            //    if (potentialStudentDAL.DeletePotentialStudent(currentObject.PotentialStudentId))
            //    {
            //        potentialStudentDAL = new PotentialStudentDAL();
            //        potentialStudentDAL.ConnectToDatabase();
            //        dgvListPotentialStudent.DataSource = potentialStudentDAL.GetAllPotentialStudent();
            //        dgvListPotentialStudent.Update();
            //        dgvListPotentialStudent.Refresh();
            //    }
            //}
            DeletePotentialStudentForm f = new DeletePotentialStudentForm();
            this.Close();
            f.Show();
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
            printDocument1.Print();
            MessageBox.Show("In thành công");
            
            
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvListPotentialStudent.Height+750, this.dgvListPotentialStudent.Width+650);
            dgvListPotentialStudent.DrawToBitmap(bmp, new Rectangle(0, 0, dgvListPotentialStudent.Width, dgvListPotentialStudent.Height));
            e.Graphics.DrawImage(bmp, 0, 120);
            e.Graphics.DrawString("TRUNG TÂM ANH NGỮ A&Z", new Font("Verdana", 25, FontStyle.Bold), Brushes.Red, new Point(150, 30));
            e.Graphics.DrawString("DANH SÁCH HỌC VIÊN TIỀM NĂNG", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(130, 70));
        }
    }
}
