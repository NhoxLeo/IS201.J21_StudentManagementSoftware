using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (Login(userName, passWord))
            {
                MenuForm f = new MenuForm();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");

            }
        }
        bool Login(string userName, string passWord)
        {
            return LoginDAL.Instance.Login(userName, passWord);
        }
        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
