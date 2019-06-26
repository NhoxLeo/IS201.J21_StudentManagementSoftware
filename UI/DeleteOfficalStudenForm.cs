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
    public partial class DeleteOfficalStudenForm : Form
    {
        public DeleteOfficalStudenForm()
        {
            InitializeComponent();
            InitStudentData();
        }
        void InitStudentData()
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
            StudentDAL potentialStudentDAL = new StudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            potentialStudentDAL.DeleteStudent(currentObject.StudentId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
