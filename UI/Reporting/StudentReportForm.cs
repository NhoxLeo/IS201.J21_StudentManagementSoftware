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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace UI
{
    public partial class StudentReportForm : Form
    {
        public StudentReportForm()
        {
            InitializeComponent();
        }
        public StudentReportForm(StudentDTO _studentDTO)
        {
            InitializeComponent();

            string TotalFee ="";
            List<StudentDTO> a = new List<StudentDTO>();
            a.Add(_studentDTO);
            SignupDAL signupDAL = new SignupDAL();
            signupDAL.ConnectToDatabase();
            List<SignupDTO> signupDTOs = signupDAL.GetAllSignupStudent(_studentDTO.StudentId);


            //DataTable dt = new DataTable();
            //dt.Columns.Add("StudentId", typeof(string));
            //dt.Columns.Add("StudentName", typeof(string));
            //dt.Columns.Add("StudentMail", typeof(string));
            //dt.Columns.Add("StudentAddress", typeof(string));
            //dt.Columns.Add("StudentPhone", typeof(string));
            //dt.Columns.Add("StudentBirthDate", typeof(DateTime));
            //DataRow row = dt.NewRow();
            //row["StudentId"] = _studentDTO.StudentId;
            //row["StudentName"] = _studentDTO.StudentName;
            //row["StudentMail"] = _studentDTO.StudentMail;
            //row["StudentAddress"] = _studentDTO.StudentAddress;
            //row["StudentPhone"] = _studentDTO.StudentPhone;
            //row["StudentBirthDate"] = _studentDTO.StudentBirthDate;
            //dt.Rows.Add(row);
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            //StudentInfoReport1.SetDataSource(ds);

            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtId"]).Text = "Mã: " + _studentDTO.StudentId;
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtName"]).Text = "Tên: " + _studentDTO.StudentName;
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtMail"]).Text = "Địa chỉ mail: " + _studentDTO.StudentMail;
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtAddress"]).Text = "Địa chỉ: " + _studentDTO.StudentAddress;
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtPhone"]).Text = "Số điện thoại: " + _studentDTO.StudentPhone;
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtBirthDate"]).Text = "Ngày sinh: " + _studentDTO.StudentBirthDate.ToLongDateString();


            TotalFee = (250 * signupDTOs.Count).ToString();
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtMoney"]).Text = "Tổng số tiền đã đóng (USD): " + TotalFee;
            crystalReportViewerStudent.ReportSource = StudentInfoReport1;
            crystalReportViewerStudent.Refresh();
            crystalReportViewerStudent.RefreshReport();
        }
    }
}
