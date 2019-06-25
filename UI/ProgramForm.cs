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

namespace UI
{
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
            InitProgramData();
        }
        void InitProgramData()
        {
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            List<ProgramDTO> programDTOs = programDAL.GetAllProgram();
            dgvListProgram.DataSource = programDTOs;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProgramForm f = new AddProgramForm();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramDTO currentObject = (ProgramDTO)dgvListProgram.CurrentRow.DataBoundItem;
            EditProgramForm f = new EditProgramForm(currentObject);
            f.ShowDialog();
        }
    }
}
