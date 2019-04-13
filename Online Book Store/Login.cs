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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.ForeColor = Color.LightBlue;
            btnLogin.FlatAppearance.BorderColor = Color.LightBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderColor = Color.White;
        }

        private void lbSignUp_MouseEnter(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.LightBlue;
        }

        private void lbSignUp_MouseLeave(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.White;
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            FormSignUp fsn = new FormSignUp();
            fsn.ShowDialog();
            fsn = null;
            Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
