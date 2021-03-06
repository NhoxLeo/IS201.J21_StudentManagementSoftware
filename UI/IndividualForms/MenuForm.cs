﻿using System;
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
    public partial class MenuForm : Form
    {
        LoginForm loginForm;
        public MenuForm()
        {
            InitializeComponent();
        }
        public MenuForm(LoginForm _loginForm)
        {
            InitializeComponent();
            //_loginForm.Hide();
            loginForm = _loginForm;
            string a = Program.UserDepartment;
            switch (Program.UserDepartment)
            {
                case "Kế Toán":
                    btnClass.Hide();
                    btnOfficialStudent.Hide();
                    btnPotentialStudent.Hide();
                    btnPrograms.Hide();
                    btnTest.Hide();
                    break;
                case "Nhân Viên":
                    btnTest.Hide();
                    btnPrograms.Hide();
                    btnReport.Hide();
                    break;
                case "Quản Lí":
                    break;
            }
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            ProgramForm f = new ProgramForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonPotentialStudent_Click(object sender, EventArgs e)
        {
            PotentialStudentForm f = new PotentialStudentForm();
            this.Hide();
            f.Show();
            //this.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonOfficialStudent_Click(object sender, EventArgs e)
        {
            OfficalStudentForm f = new OfficalStudentForm();
            this.Hide();
            f.Show();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            ClassForm f = new ClassForm();
            this.Hide();
            f.Show();
          
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //if(loginForm!=null)
            //{
            //    loginForm.ResetUser();
            //    loginForm.Show();
            //}
            loginForm.ResetUser();
            loginForm.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestForm f = new TestForm();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
