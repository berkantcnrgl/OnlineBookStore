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
        private static Database databaseObject = Database.DatabaseObj();
        internal static Database DatabaseObject
        {
            get
            {
                return databaseObject;
            }
            set
            {
                databaseObject = value;
            }
        }
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
            Customer loginedCustomer = new Customer();
            Customer customer = databaseObject.GetCustomer(txtUsername.Text, txtPassword.Text);
            if (customer != null)
            {
                this.Hide();
                loginedCustomer = customer;
                Logger.logger("Login");
                MainForm mainform = new MainForm(customer);
                mainform.ShowDialog();
                mainform = null;
                GC.Collect();
                txtUsername.Clear();
                txtPassword.Clear();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış !", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
