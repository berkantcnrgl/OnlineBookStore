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
    public partial class UserProfileForm : Form
    {
        Customer cst = null;

        public UserProfileForm(Customer currentCustomer)
        {
            InitializeComponent();
            cst = currentCustomer;
            txtName.Text = cst.Name;
            txtSurname.Text = cst.Surname;
            txtAddress.Text = cst.Address;
            txtEmail.Text = cst.Email;
            txtUsername.Text = cst.Username;
            txtPassword.Text = cst.Password;
        }
    }
}
