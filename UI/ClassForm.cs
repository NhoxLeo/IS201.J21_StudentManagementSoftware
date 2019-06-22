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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
            InitClassData();
        }
        void InitClassData()
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            dgvListClass.DataSource = classDTOs;
        }

        private void btAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm f = new AddClassForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClassDTO currentObject = (ClassDTO)dgvListClass.CurrentRow.DataBoundItem;
            EditClassForm f = new EditClassForm(currentObject);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClassForm f = new DeleteClassForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //EditClassForm f = new EditClassForm();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
