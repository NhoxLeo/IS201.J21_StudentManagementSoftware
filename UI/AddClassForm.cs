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
    public partial class AddClassForm : Form
    {
        string ID_CHAR = "CL";
        int ID_NUMBER;
        public AddClassForm()
        {
            InitializeComponent();
            LoadComboBoxProgram();
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            ID_NUMBER = classDAL.GetAllClass().Count + 1;
            textboxClassID.Text = ID_CHAR + (ID_NUMBER).ToString();
        }
        void LoadComboBoxProgram()
        {
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            List<ProgramDTO> programDTOs = programDAL.GetAllProgram();
            comboBoxProgram.DataSource = programDTOs;
            comboBoxProgram.DisplayMember = "ProgramName";
            comboBoxProgram.ValueMember = "ProgramId";
        }
        private void btConfim_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();

            if(classDAL.InsertClass(textboxClassID.Text, textboxClassName.Text, textboxTeacher.Text, textboxStartingHour.Text, startDate.Value, endDate.Value, ((ProgramDTO)comboBoxProgram.SelectedItem).ProgramId.ToString()))
            {
                MessageBox.Show("Success");
                this.Close();
            }
        }

        private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_CHAR = ((ProgramDTO)comboBoxProgram.SelectedItem).ProgramId.ToString();
            textboxClassID.Text = ID_CHAR + (ID_NUMBER).ToString();
        }
    }
}
