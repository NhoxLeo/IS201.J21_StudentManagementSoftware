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
            PontentialStudentDAL studentDAL = new PontentialStudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOfficalStudentForm f = new AddOfficalStudentForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
            EditOfficalStudentForm f = new EditOfficalStudentForm(currentObject);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvListStudent.SelectedRows.Count > 0)
            {
                PontentialStudentDAL potentialStudentDAL = new PontentialStudentDAL();
                potentialStudentDAL.ConnectToDatabase();
                StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
                if (potentialStudentDAL.DeleteStudent(currentObject.StudentId))
                {
                    potentialStudentDAL = new PontentialStudentDAL();
                    potentialStudentDAL.ConnectToDatabase();
                    dgvListStudent.DataSource = potentialStudentDAL.GetAllStudent();
                    dgvListStudent.Update();
                    dgvListStudent.Refresh();
                }
            }
            //DeleteOfficalStudenForm f = new DeleteOfficalStudenForm();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //AddOfficalStudentForm f = new AddOfficalStudentForm();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
