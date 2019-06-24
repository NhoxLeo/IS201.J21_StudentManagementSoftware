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
    public partial class EditClassForm : Form
    {
        public EditClassForm()
        {
            InitializeComponent();
        }
        public EditClassForm(ClassDTO classDTO)
        {
            InitializeComponent();
            textboxClassID.Text = classDTO.ClassId;
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            ClassDTO classDTO = new ClassDTO(textboxClassID.Text, textboxClassName.Text, textboxTeacher.Text, textboxStartingHour.Text, startDate.Value, endDate.Value, textboxProgram.Text);
            classDAL.UpdateClass(classDTO);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
