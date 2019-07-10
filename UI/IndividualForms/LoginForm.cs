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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Show();
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;

            UserDAL userDAL = new UserDAL();
            userDAL.ConnectToDatabase();

            UserDTO mainUser = userDAL.GetUser(userName);

            if(mainUser == null) MessageBox.Show("Không có tài khoản!");
            else
            {
                if (passWord == mainUser.Password)
                {
                    Program.UserDepartment = mainUser.Department;
                    MenuForm f = new MenuForm(this);
                    f.Show();
                    this.Hide();
                }
                else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ResetUser()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegisterAccForm f = new RegisterAccForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
