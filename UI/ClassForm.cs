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
        public string nameClass;
        public ClassForm()
        {
            InitializeComponent();
            InitClassData();
            getNameClass();
        }
        
        void InitClassData()
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            List<ClassDTO> classDTOs = classDAL.GetAllClass();
            dgvListClass.DataSource = classDTOs;
            DataGridViewButtonColumn addConfirm = new DataGridViewButtonColumn() { HeaderText = "Thông tin lớp",Text = "Add" };
            dgvListClass.Columns.Add(addConfirm);
           
        }
        void MyButtonHandler(object sender, EventArgs e)
        {
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
            if (this.dgvListClass.SelectedRows.Count > 0)
            {
                ClassDAL classDAL = new ClassDAL();
                classDAL.ConnectToDatabase();
                ClassDTO currentObject = (ClassDTO)dgvListClass.CurrentRow.DataBoundItem;
                if(classDAL.DeleteClass(currentObject.ClassId))
                {
                    classDAL = new ClassDAL();
                    classDAL.ConnectToDatabase();
                    dgvListClass.DataSource = classDAL.GetAllClass();
                    dgvListClass.Update();
                    dgvListClass.Refresh();
                }
            }
            //DeleteClassForm f = new DeleteClassForm();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            MessageBox.Show("In thành công");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClassForm_Shown(object sender, EventArgs e)
        {
            dgvListClass.Update();
            dgvListClass.Refresh();
        }

        private void btnAddStudentToClass_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            ClassDTO currentObject = (ClassDTO)dgvListClass.CurrentRow.DataBoundItem;
            AddStudentToClassForm f = new AddStudentToClassForm(currentObject.ClassId);
            nameClass = currentObject.ClassId.ToUpperInvariant();
            DialogResult dialogRe = MessageBox.Show("Bạn muốn thêm học sinh vào lớp: " + nameClass, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogRe == DialogResult.Yes)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
          public string getNameClass()
          {
             return nameClass;
          }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvListClass.Height + 750, this.dgvListClass.Width + 650);
            dgvListClass.DrawToBitmap(bmp, new Rectangle(0, 0, dgvListClass.Width, dgvListClass.Height));
            e.Graphics.DrawImage(bmp, 0, 120);
            e.Graphics.DrawString("TRUNG TÂM ANH NGỮ A&Z", new Font("Verdana", 25, FontStyle.Bold), Brushes.Red, new Point(150, 30));
            e.Graphics.DrawString("DANH SÁCH LỚP HỌC CỦA TRUNG TÂM", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(120, 70));
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            ClassDTO currentObject = (ClassDTO)dgvListClass.CurrentRow.DataBoundItem;
            DeleteStudentClassForm f = new DeleteStudentClassForm(currentObject.ClassId);
            nameClass = currentObject.ClassId.ToUpperInvariant();
            DialogResult dialogRe = MessageBox.Show("Bạn muốn xoá học viên khỏi lớp: " + nameClass, "Thông báo", MessageBoxButtons.YesNo);
            if (dialogRe == DialogResult.Yes)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
