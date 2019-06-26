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
    public partial class ReportDetailForm : Form
    {
        string TotalFee;
        public ReportDetailForm()
        {
            InitializeComponent();
        }
        public ReportDetailForm(ClassDTO _class)
        {
            InitializeComponent();
            SignupDAL signupDAL = new SignupDAL();
            signupDAL.ConnectToDatabase();
            List<SignupDTO> signupDTOs = signupDAL.GetAllSignupClass(_class.ClassId);
            dgvReport.DataSource = signupDTOs;
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            TotalFee = (programDAL.GetProgram(_class.ProgramId).Fee * signupDTOs.Count).ToString();
            labelType.Text = "Tổng số tiền thu được (USD): ";
            labelInfo.Text = TotalFee;
        }

        public ReportDetailForm(StudentDTO _student)
        {
            int fees = 0;
            InitializeComponent();

            List<StudentDTO> a = new List<StudentDTO>();
            a.Add(_student);
            dgvReport.DataSource = a;
            SignupDAL signupDAL = new SignupDAL();
            signupDAL.ConnectToDatabase();
            List<SignupDTO> signupDTOs = signupDAL.GetAllSignupStudent(_student.StudentId);

            TotalFee = (250 * signupDTOs.Count).ToString();
            labelType.Text = "Tổng số tiền đã đóng (USD): ";
            labelInfo.Text = TotalFee;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
