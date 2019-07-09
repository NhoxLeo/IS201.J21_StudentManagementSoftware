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
    public partial class OfficalStudentForm : Form
    {
        public OfficalStudentForm()
        {
            InitializeComponent();
            InitOfficialStudentData();
        }
        void InitOfficialStudentData()
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            AddOfficalStudentForm f = new AddOfficalStudentForm();
            this.Close();
            f.Show();
            //this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
            EditOfficalStudentForm f = new EditOfficalStudentForm(currentObject);
            this.Close();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            
                StudentDAL potentialStudentDAL = new StudentDAL();
            SignupDAL sgDAL = new SignupDAL();
                potentialStudentDAL.ConnectToDatabase();
                StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
            DialogResult rs = MessageBox.Show("Bạn muốn xoá học viên: " + currentObject.StudentId, "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                try
                {

                    if (sgDAL.DeleteSignupStudent(currentObject.StudentId) && potentialStudentDAL.DeleteStudent(currentObject.StudentId))
                    {
                        MessageBox.Show("Xoá học viên thành công!!!");
                        this.Close();
                        OfficalStudentForm f = new OfficalStudentForm();
                        f.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá học viên thất bại!!!");
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            MessageBox.Show("In thành công");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvListStudent.Height + 750, this.dgvListStudent.Width + 650);
            dgvListStudent.DrawToBitmap(bmp, new Rectangle(0, 0, dgvListStudent.Width, dgvListStudent.Height));
            e.Graphics.DrawImage(bmp, 0, 120);
            e.Graphics.DrawString("TRUNG TÂM ANH NGỮ G&M", new Font("Verdana", 25, FontStyle.Bold), Brushes.Red, new Point(150, 30));
            e.Graphics.DrawString("DANH SÁCH HỌC VIÊN CHÍNH THỨC", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(130, 70));
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            AddMarkForm f = new AddMarkForm((StudentDTO)dgvListStudent.CurrentRow.DataBoundItem);
            this.Close();
            f.Show();
        }

        private void btnEditMark_Click(object sender, EventArgs e)
        {
            EditMarkForm f = new EditMarkForm();
            this.Hide();
            f.Show();
        }
    }
}
