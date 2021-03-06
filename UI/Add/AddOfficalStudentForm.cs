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

namespace UI
{
    public partial class AddOfficalStudentForm : Form
    {
        string ID_CHAR = "ST";
        public AddOfficalStudentForm()
        {
            InitializeComponent();
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            textboxStudentID.Text = ID_CHAR + (studentDAL.GetAllStudent().Count + 1).ToString();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            try
            {
                if ((studentDAL.InsertStudent(textboxStudentID.Text, textboxStudentName.Text, textboxStudentMail.Text, textboxStudentAddress.Text, textboxStudentPhoneNumber.Text, birthDateTimePicker.Value))
                    &&textboxStudentName.Text!="")
                {
                    MessageBox.Show("Thêm học viên thành công!!!");
                    this.Close();
                    OfficalStudentForm f = new OfficalStudentForm();
                    f.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm học viên thất bại, vui lòng kiểm tra lại dữ liệu!!!");
            }
        }

        private void textboxStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficalStudentForm f = new OfficalStudentForm();
            f.Show();
        }
    }
}
