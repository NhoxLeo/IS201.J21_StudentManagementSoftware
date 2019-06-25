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
    public partial class DeleteStudentToClassForm : Form
    {
    
        string classId;
        public DeleteStudentToClassForm()
        {
            InitializeComponent();
            InitOfficialStudentData();
        }
        public DeleteStudentToClassForm(string _classId)
        {
            InitializeComponent();
            InitOfficialStudentData();
            classId = _classId;
           
            
        }
        public DeleteStudentToClassForm(string _classId,String nameClass)
        {
            InitializeComponent();
            InitOfficialStudentData();
            classId = _classId;
            lb3.Text = "Xoá học viên khỏi lớp: " + nameClass;                     
            SignupDAL studentDAL = new SignupDAL();
            studentDAL.ConnectToDatabase();
            List<SignupDTO> studentDTOs = studentDAL.GetAllSignupClass(nameClass);
            dgvListStudent.DataSource = studentDTOs;
            DataGridViewCheckBoxColumn deleteConfirm = new DataGridViewCheckBoxColumn() { HeaderText = "Delete" };
            dgvListStudent.Columns.Add(deleteConfirm);
        }
        void InitOfficialStudentData()
        {
            
            
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
