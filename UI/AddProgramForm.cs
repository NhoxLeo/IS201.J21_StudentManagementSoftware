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

namespace UI
{
    public partial class AddProgramForm : Form
    {
        public AddProgramForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramDAL programDAL = new ProgramDAL();
                int level = Int32.Parse(Level.Text);
                int fee = Int32.Parse(Fee.Text);
                if (ID.Text != "" && name.Text != "" && Level.Text != "" && Fee.Text != "")
                {
                    if (programDAL.InsertProgram(ID.Text, name.Text, level, fee))
                    {
                        MessageBox.Show("Thêm chương trình học thành công!!!");
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm chương trình học không thành công, vui lòng nhập đủ thông tin!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
