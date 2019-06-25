using DAL;
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

namespace UI
{
    public partial class DeleteStudentClassForm : Form
    {
        string classId;
        public DeleteStudentClassForm()
        {
            InitializeComponent();
            InitOfficialStudentData();
        }
        public DeleteStudentClassForm(string _classId)
        {
            InitializeComponent();
            InitOfficialStudentData();
            classId = _classId;
        }
        void InitOfficialStudentData()
        {
            ClassForm f = new ClassForm();
            SignupDAL studentDAL = new SignupDAL();
            studentDAL.ConnectToDatabase();
            List<SignupDTO> studentDTOs = studentDAL.GetAllSignupClass("LS1");
            dgvListStudent.DataSource = studentDTOs;
            DataGridViewCheckBoxColumn deleteConfirm = new DataGridViewCheckBoxColumn() { HeaderText = "Delete" };
            dgvListStudent.Columns.Add(deleteConfirm);
            label3.Text = f.getNameClass(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvListStudent.Rows)
            {
                if ((Convert.ToBoolean(item.Cells[0].Value) == true))
                {
                    string studentId = item.Cells[1].Value.ToString();
                    SignupDAL signupDAL = new SignupDAL();
                    signupDAL.ConnectToDatabase();
                    if (signupDAL.DeleteSignup(studentId, classId, "Joined"))
                    {
                        MessageBox.Show(" Xoá thành công!!!");
                        this.Close();
                    }
                }
            }
        }
    }
}
