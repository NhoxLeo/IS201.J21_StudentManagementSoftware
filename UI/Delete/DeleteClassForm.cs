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
    public partial class DeleteClassForm : Form
    {
        public DeleteClassForm()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ClassDTO currentObject = (ClassDTO)dgvListClass.CurrentRow.DataBoundItem;
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            try
            {

                if(classDAL.DeleteClass(currentObject.ClassId))
                {
                    MessageBox.Show("Xoá lớp thành công!!!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Xoá lớp thất bại!!!");
            }
        }
    }
}
