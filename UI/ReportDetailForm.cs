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
            int totalFee = programDAL.GetProgram(_class.ProgramId).Fee * signupDTOs.Count;
        }

        //public ReportDetailForm(string ID)
        //{
        //    InitializeComponent();
        //    MarkDAL markDAL = new MarkDAL();
        //    markDAL.ConnectToDatabase();
        //    List<MarkDTO> markDTOs = markDAL.GetAllMark(ID);
        //    dgvReport.DataSource = markDTOs;
        //    StudentDAL studentDAL = new StudentDAL();
        //    studentDAL.ConnectToDatabase();
        //    string name = studentDAL.GetStudent(ID).StudentName;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
