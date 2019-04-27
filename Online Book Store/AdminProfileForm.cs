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
    public partial class AdminProfileForm : Form
    {
        DataSet dataset;
        int index;
        static TextBox[] customerTextArray;
        static TextBox[] bookTextArray;
        static TextBox[] magazineTextArray;
        static TextBox[] musicCDTextArray;

        public AdminProfileForm()
        {
            InitializeComponent();
            dataset = new DataSet();
            FormLogin.DatabaseObject.Refresh(dataset);
            dgvBooks.DataSource = dataset.Tables[0];
            dgvCustomers.DataSource = dataset.Tables[1];
            dgvMusicCds.DataSource = dataset.Tables[2];
            dgvMagazines.DataSource = dataset.Tables[3];
            dgvCustomers.SelectAll();
            customerTextArray = new TextBox[] { txtCustomerName, txtCustomerSurname, txtCustomerAddress, txtCustomerEmail, txtCustomerUsername, txtCustomerPassword };
            bookTextArray = new TextBox[] { txtBookName, txtBookPrice, txtBookIsbn, txtBookAuthor, txtBookPublisher, txtBookContent, txtBookPage, txtBookCategory };
            magazineTextArray = new TextBox[] { txtMagazineName, txtMagazinePrice, txtMagazineCategory, txtMagazineIsbn, txtMagazineIssue };
            musicCDTextArray = new TextBox[] { txtMusicCdName, txtMusicCdPrice, txtMusicCdIsbn, txtMusicCdReleaseDate, txtMusicCdSinger, txtMusicCdCategory, txtMusicCdContent };
            btnAddCustomer.Enabled = true;
            btnCustomerDelete.Enabled = false;
            btnCustomerUpdate.Enabled = false;
            btnAddBook.Enabled = false;
            btnBookUpdate.Enabled = false;
            btnBookDelete.Enabled = false;
            btnBookImageChange.Enabled = false;
            btnAddMagazine.Enabled = false;
            btnMagazineImage.Enabled = false;
            btnDeleteMagazine.Enabled = false;
            btnUpdateMagazine.Enabled = false;
            btnAddMusicCd.Enabled = false;
            btnDeleteMusicCd.Enabled = false;
            btnUpdateMusicCd.Enabled = false;
            btnMusicCdImage.Enabled = false;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnCustomerDelete.Enabled = true;
            btnCustomerUpdate.Enabled = true;
            DataGridViewRow row = dgvCustomers.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtCustomerName.Text = cells[1].Value.ToString().Trim();
            txtCustomerSurname.Text = cells[2].Value.ToString().Trim();
            txtCustomerAddress.Text = cells[3].Value.ToString().Trim();
            txtCustomerEmail.Text = cells[4].Value.ToString().Trim();
            txtCustomerUsername.Text = cells[5].Value.ToString().Trim();
            txtCustomerPassword.Text = cells[6].Value.ToString().Trim();
            if (Convert.ToInt32(cells[8].Value) == 1)
                cbIsAdmin.Checked = true;
            else
                cbIsAdmin.Checked = false;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddBook.Enabled = false;
            btnBookUpdate.Enabled = true;
            btnBookDelete.Enabled = true;
            btnBookImageChange.Enabled = false;
            if (index == dgvBooks.RowCount - 1)
            {
                pbBook.Image = null;
                btnAddBook.Enabled = true;
                btnBookUpdate.Enabled = false;
                btnBookDelete.Enabled = false;
                btnBookImageChange.Enabled = true;
            }
            DataGridViewRow row = dgvBooks.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtBookName.Text = cells[1].Value.ToString().Trim();
            txtBookPrice.Text = cells[2].Value.ToString().Trim();
            txtBookIsbn.Text = cells[3].Value.ToString().Trim();
            txtBookAuthor.Text = cells[4].Value.ToString().Trim();
            txtBookPublisher.Text = cells[5].Value.ToString().Trim();
            txtBookPage.Text = cells[6].Value.ToString().Trim();
            txtBookContent.Text = cells[7].Value.ToString().Trim();
            txtBookCategory.Text = cells[8].Value.ToString().Trim();
            if (index != dgvBooks.RowCount - 1)
            {
                try
                {
                    pbBook.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbBook.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbBook.Image = null;
                }
            }
        }

        private void dgvMagazines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddMagazine.Enabled = false;
            btnMagazineImage.Enabled = true;
            btnDeleteMagazine.Enabled = true;
            btnMagazineImage.Enabled = false;
            if (index == dgvMagazines.RowCount - 1)
            {
                pbMagazineImage.Image = null;
                btnAddMagazine.Enabled = true;
                btnDeleteMagazine.Enabled = false;
                btnUpdateMagazine.Enabled = false;
                btnMagazineImage.Enabled = true;
            }
            DataGridViewRow row = dgvMagazines.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtMagazineName.Text = cells[1].Value.ToString().Trim();
            txtMagazinePrice.Text = cells[2].Value.ToString().Trim();
            txtMagazineCategory.Text = cells[3].Value.ToString().Trim();
            txtMagazineIsbn.Text = cells[4].Value.ToString().Trim();
            txtMagazineIssue.Text = cells[5].Value.ToString().Trim();
            if (index != dgvMagazines.RowCount - 1)
            {
                try
                {
                    pbMagazineImage.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbMagazineImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbMagazineImage.Image = null;
                }
            }
        }

        private void dgvMusicCds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddMusicCd.Enabled = false;
            btnUpdateMusicCd.Enabled = true;
            btnDeleteMusicCd.Enabled = true;
            btnMusicCdImage.Enabled = false;
            if (index == dgvMusicCds.RowCount - 1)
            {
                pbMusicCdImage.Image = null;
                btnAddMusicCd.Enabled = true;
                btnUpdateMusicCd.Enabled = false;
                btnDeleteMusicCd.Enabled = false;
                btnMusicCdImage.Enabled = true;
            }
            DataGridViewRow row = dgvMusicCds.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtMusicCdName.Text = cells[1].Value.ToString();
            txtMusicCdPrice.Text = cells[2].Value.ToString();
            txtMusicCdIsbn.Text = cells[3].Value.ToString();
            txtMusicCdReleaseDate.Text = cells[4].Value.ToString();
            txtMusicCdSinger.Text = cells[5].Value.ToString();
            txtMusicCdCategory.Text = cells[6].Value.ToString();
            txtMusicCdContent.Text = cells[7].Value.ToString();
            if (index != dgvMusicCds.RowCount - 1)
            {
                try
                {
                    pbMusicCdImage.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Resources\" + cells[0].Value.ToString().Trim() + ".jpg");
                    pbMusicCdImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception)
                {
                    pbMusicCdImage.Image = null;
                }
            }
        }

        private void tabctrlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs a = new DataGridViewCellEventArgs(0, 0);

            if (tabctrlAdmin.SelectedIndex == 0)
            {
                dgvCustomers.ClearSelection();
                dgvCustomers_CellClick(dgvCustomers, a);
            }
            else if (tabctrlAdmin.SelectedIndex == 1)
            {
                dgvBooks.ClearSelection();
                dgvBooks_CellClick(dgvBooks, a);
            }
            else if (tabctrlAdmin.SelectedIndex == 2)
            {
                dgvMagazines.ClearSelection();
                dgvMagazines_CellClick(dgvMagazines, a);
            }
            else
            {
                dgvMusicCds.ClearSelection();
                dgvMusicCds_CellClick(dgvMusicCds, a);
            }
        }
    }
}
