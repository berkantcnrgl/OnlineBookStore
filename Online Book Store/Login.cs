using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public partial class FormLogin : Form
    {
        Database database = Database.DatabaseObj();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(0,190,190);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Hide();
            FormSignUp fsn = new FormSignUp();
            fsn.ShowDialog();
            fsn = null;
            Show();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if(database.passwordControl(txtUsername.Text,txtPassword.Text))
            //{
            Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
            main = null;
            Show();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            //}
        }
    }
}
