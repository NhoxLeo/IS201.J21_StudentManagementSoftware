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
    public partial class RegisterAccForm : Form
    {
        public RegisterAccForm()
        {
            InitializeComponent();
            comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDAL userDAL = new UserDAL();
            userDAL.ConnectToDatabase();
            try
            {
                UserDTO userDTO = new UserDTO(tbID.Text, tbName.Text, tbPwd.Text, comboBoxDepartment.SelectedItem.ToString());
                if (userDAL.InsertUser(userDTO))
                {
                    MessageBox.Show("Thêm tài khoản thành công!!!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm tài khoản thất bại, vui lòng kiểm tra lại dữ liệu!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
