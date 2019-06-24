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
            PontentialStudentDAL studentDAL = new PontentialStudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StudentDTO currentObject = (StudentDTO)dgvListStudent.CurrentRow.DataBoundItem;
            PontentialStudentDAL potentialStudentDAL = new PontentialStudentDAL();
            potentialStudentDAL.ConnectToDatabase();
            potentialStudentDAL.DeleteStudent(currentObject.StudentId);
        }
    }
}
