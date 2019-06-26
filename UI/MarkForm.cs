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
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent();
            LoadDataGridViewMark();
        }
        void LoadDataGridViewMark()
        {
            MarkDAL markDAL = new MarkDAL();
            markDAL.ConnectToDatabase();
            List<MarkDTO> markDTO = markDAL.GetAllMark();
            dgvListMark.DataSource = markDTO;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MarkDAL markDAL = new MarkDAL();
            markDAL.ConnectToDatabase();
            MarkDTO currentObject = (MarkDTO)dgvListMark.CurrentRow.DataBoundItem;
            EditMarkForm  f = new EditMarkForm();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MarkDAL markDAL = new MarkDAL();
            markDAL.ConnectToDatabase();
            MarkDTO currentObject = (MarkDTO)dgvListMark.CurrentRow.DataBoundItem;
            markDAL.DeleteMark(currentObject.StudentId,currentObject.TestId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
