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
    public partial class EditProgramForm : Form
    {
        public EditProgramForm(ProgramDTO programDTO)
        {
            InitializeComponent();
            ID.Text = programDTO.ProgramId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            int level = Int32.Parse(Level.Text);
            int fee = Int32.Parse(Fee.Text);
            ProgramDTO programDTO = new ProgramDTO(ID.Text, Name.Text, level, fee);
            programDAL.UpdateProgram(programDTO);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
