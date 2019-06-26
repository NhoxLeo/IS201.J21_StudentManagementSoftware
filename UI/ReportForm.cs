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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        void LoadComboBoxClass()
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            comboBoxListClassIDs.DataSource = classDTOs;
            comboBoxListClassIDs.DisplayMember = "ClassName";
            comboBoxListClassIDs.ValueMember = "ClassId";
        }
        void LoadComboBoxStudent()
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> classDTOs = studentDAL.GetAllStudent();
            comboBoxListStudent.DataSource = classDTOs;
            comboBoxListStudent.DisplayMember = "StudentName";
            comboBoxListStudent.ValueMember = "StudentId";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            switch (s)
            {
                case "Báo cáo Thông tin Học viên":
                    LoadComboBoxStudent();
                    BaocaoTTHV.Show();
                    BaocaoKTLH.Hide();
                    BaocaoKQHT.Hide();
                    break;
                case "Báo cáo Kế toán Lớp học":
                    LoadComboBoxClass();
                    BaocaoTTHV.Hide();
                    BaocaoKTLH.Show();
                    BaocaoKQHT.Hide();
                    break;
                case "Báo cáo kết quả học tập":
                    BaocaoTTHV.Hide();
                    BaocaoKTLH.Hide();
                    BaocaoKQHT.Show();
                    break;
                default:
                    break;
            };
        }

        private void BaocaoKQHT_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = true;
            label5.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = false;
            label5.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            ReportDetailForm f/* = new ReportDetailForm()*/;
            switch (s)
            {
                case "":
                    MessageBox.Show("Vui lòng chọn loại báo cáo và nhập thông tin!");
                    break;
                case "Báo cáo Thông tin Học viên":
                    //
                    f = new ReportDetailForm((StudentDTO)comboBoxListStudent.SelectedItem);
                    f.Text = "Báo cáo Thông tin Học viên";
                    f.ShowDialog();
                    break;
                case "Báo cáo Kế toán Lớp học":
                    //
                    f = new ReportDetailForm((ClassDTO)comboBoxListClassIDs.SelectedItem);
                    //f = new ReportDetailForm();
                    f.Text = "Báo cáo Kế toán Lớp học";
                    f.ShowDialog();
                    break;
                case "Báo cáo kết quả học tập":
                    //
                    f = new ReportDetailForm();
                    f.Text = "Báo cáo kết quả học tập";
                    f.ShowDialog();
                    break;
                default: break;
            }
        }
    }
}
