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
using CrystalDecisions.CrystalReports.Engine;

namespace UI
{
    public partial class ClassReportForm : Form
    {
        public ClassReportForm()
        {
            InitializeComponent();
        }
        public ClassReportForm(ClassDTO _classDTO)
        {
            InitializeComponent();
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtClassId"]).Text = "Mã lớp: " + _classDTO.ClassId;
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtClassName"]).Text = "Tên lớp: " + _classDTO.ClassName;
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtStartHour"]).Text = "Giờ học: " + _classDTO.StartHour;
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtProgramId"]).Text = "Mã chương trình học: " + _classDTO.ProgramId;
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtStartDate"]).Text = "Ngày bắt đầu: " + _classDTO.StartDate.ToLongDateString();
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtEndDate"]).Text = "Ngày kết thúc: " + _classDTO.EndDate.ToLongDateString();

            SignupDAL signupDAL = new SignupDAL();
            signupDAL.ConnectToDatabase();
            List<SignupDTO> signupDTOs = signupDAL.GetAllSignupClass(_classDTO.ClassId);
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            string TotalFee = (programDAL.GetProgram(_classDTO.ProgramId).Fee * signupDTOs.Count).ToString();

            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtStudentCount"]).Text = "Tổng số học sinh: " + signupDTOs.Count.ToString();
            ((TextObject)ClassInfoReport1.Section4.ReportObjects["txtMoney"]).Text = "Tổng số tiền thu được (USD):  " + TotalFee;
        }
    }
}
