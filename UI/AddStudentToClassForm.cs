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
    public partial class AddStudentToClassForm : Form
    {
        string classId;
        public AddStudentToClassForm()
        {
            InitializeComponent();
            InitOfficialStudentData();
        }
        public AddStudentToClassForm(string _classId)
        {
            InitializeComponent();
            InitOfficialStudentData();
            classId = _classId;
        
        }
        public AddStudentToClassForm(string _classId,String nameClass)
        {
            InitializeComponent();
            InitOfficialStudentData();
            classId = _classId;
            //Set nameclass vào text
            label3.Text ="Thêm học viên vào lớp: "+ nameClass;

        }
        void InitOfficialStudentData()
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
            DataGridViewCheckBoxColumn addConfirm = new DataGridViewCheckBoxColumn() { HeaderText = "Add"};
            dgvListStudent.Columns.Add(addConfirm);
           
           
           
        }


        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvListStudent.Rows)
            {
                if ((Convert.ToBoolean(item.Cells[0].Value) == true))
                {
                    string studentId = item.Cells[1].Value.ToString();
                    SignupDAL signupDAL = new SignupDAL();
                    signupDAL.ConnectToDatabase();
                    if (signupDAL.InsertSignup(studentId, classId, "Joined"))
                    {
                        MessageBox.Show("Success");
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
