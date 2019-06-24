using System;
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
        public MenuForm()
        {
            InitializeComponent();

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
            f.ShowDialog();
            this.Show();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            ClassForm f = new ClassForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show();
        }

    }
}
