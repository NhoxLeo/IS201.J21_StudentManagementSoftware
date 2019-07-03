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
            LoadComboBoxProgram();
        }
        public EditClassForm(ClassDTO classDTO)
        {
            InitializeComponent();
            textboxClassID.Text = classDTO.ClassId;
            LoadComboBoxProgram();
            AssignInfo(classDTO);
        }
        void LoadComboBoxProgram()
        {
            ProgramDAL programDAL = new ProgramDAL();
            programDAL.ConnectToDatabase();
            List<ProgramDTO> programDTOs = programDAL.GetAllProgram();
            comboBoxProgram.DataSource = programDTOs;
            comboBoxProgram.DisplayMember = "ProgramName";
            comboBoxProgram.ValueMember = "ProgramId";
        }
        void AssignInfo(ClassDTO _classDTO)
        {
            textboxClassID.Text = _classDTO.ClassId;
            textboxClassName.Text = _classDTO.ClassName;
            textboxStartingHour.Text = _classDTO.StartHour;
            startDate.Value = _classDTO.StartDate;
            endDate.Value = _classDTO.EndDate;
        }

        private void btConfim_Click(object sender, EventArgs e)
        {
            ClassDAL classDAL = new ClassDAL();
            classDAL.ConnectToDatabase();
            ClassDTO classDTO = new ClassDTO(textboxClassID.Text, textboxClassName.Text, textboxStartingHour.Text, startDate.Value, endDate.Value, ((ProgramDTO)comboBoxProgram.SelectedItem).ProgramId.ToString());
            try
            {
                if (classDAL.UpdateClass(classDTO))
                {
                    MessageBox.Show("Đổi lớp thành công!!!");
                    this.Close();
                    ClassForm f = new ClassForm();
                    f.Show();
                }
            }
            catch (Exception)

            {
                MessageBox.Show("Thay đổi thất bại!!!");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassForm f = new ClassForm();
            f.Show();
        }
    }
}
