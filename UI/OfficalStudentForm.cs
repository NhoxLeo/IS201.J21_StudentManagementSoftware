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
    public partial class OfficalStudentForm : Form
    {
        public OfficalStudentForm()
        {
            InitializeComponent();
            InitOfficialStudentData();
        }
        void InitOfficialStudentData()
        {
            StudentDAL studentDAL = new StudentDAL();
            studentDAL.ConnectToDatabase();
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dgvListStudent.DataSource = studentDTOs;
        }
    }
}
