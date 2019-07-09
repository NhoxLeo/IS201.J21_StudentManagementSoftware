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
            //TextObject moneyText =
                ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtMoney"]).Text = "Tổng số tiền thu được: ";
            //if (StudentInfoReport1!=null)                StudentInfoReport1.SetParameterValue("txtMoney",new TextBox() { Text = "asd"});
            //crystalReportViewerStudent
            //StudentInfoReport1.ReportDefinition.Sections[3].ReportObjects[1].Text = "asd";
        }
    }
}
