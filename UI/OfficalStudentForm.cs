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
            DeleteOfficalStudenForm f = new DeleteOfficalStudenForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
