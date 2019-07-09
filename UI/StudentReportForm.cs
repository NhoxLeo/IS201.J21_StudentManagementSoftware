﻿using System;
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

            TotalFee = (250 * signupDTOs.Count).ToString();
            //StudentInfoReport1.SetDataSource();
            ((TextObject)StudentInfoReport1.Section4.ReportObjects["txtMoney"]).Text = "Tổng số tiền đã đóng (USD): " + TotalFee;
            //((TextObject)StudentInfoReport1.Section4.ReportObjects["txtMoney"]).Text = "Tổng số tiền đã đóng (USD): " + TotalFee;
            //if (StudentInfoReport1!=null)                StudentInfoReport1.SetParameterValue("txtMoney",new TextBox() { Text = "asd"});
        }
    }
}
