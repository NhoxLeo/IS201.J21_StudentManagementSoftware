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
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            classDAL.InsertClass(textboxClassID.Text, textboxClassName.Text, textboxTeacher.Text, textboxStartingHour.Text, startDate.Value,endDate.Value,textboxProgram.Text);
        }
    }
}
