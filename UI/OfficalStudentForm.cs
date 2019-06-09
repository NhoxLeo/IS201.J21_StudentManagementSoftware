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
            //studentDAL.InsertStudent("ST1","Adam","adam@gmail.com","NewYork","001242343",new DateTime(2019,1,12));
            List<StudentDTO> studentDTOs = studentDAL.GetAllStudent();
            dtgvListPotentialStudent.DataSource = studentDTOs;
        }
    }
}
