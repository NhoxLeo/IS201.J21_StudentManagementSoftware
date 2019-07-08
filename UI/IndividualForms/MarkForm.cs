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
    public partial class MarkForm : Form
    {
        public MarkForm()
        {
            InitializeComponent();
        }
        public MarkForm(StudentDTO _studentDTO)
        {
            InitializeComponent();

        }
    }
}
