namespace Online_Book_Store
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrevPurchases = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flpnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlUser.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlUser.Controls.Add(this.lbUsername);
            this.pnlUser.Controls.Add(this.btnAdminProfile);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.btnPrevPurchases);
            this.pnlUser.Controls.Add(this.btnShoppingCart);
            this.pnlUser.Controls.Add(this.btnUserProfile);
            this.pnlUser.Location = new System.Drawing.Point(0, 190);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(300, 725);
            this.pnlUser.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(12, 643);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(118, 31);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username";
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminProfile.FlatAppearance.BorderSize = 0;
            this.btnAdminProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdminProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminProfile.ForeColor = System.Drawing.Color.White;
            this.btnAdminProfile.Location = new System.Drawing.Point(0, 344);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(300, 80);
            this.btnAdminProfile.TabIndex = 3;
            this.btnAdminProfile.Text = "Yönetici Profili";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.MouseEnter += new System.EventHandler(this.btnAdminProfile_MouseEnter);
            this.btnAdminProfile.MouseLeave += new System.EventHandler(this.btnAdminProfile_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 258);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 80);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnPrevPurchases
            // 
            this.btnPrevPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPurchases.FlatAppearance.BorderSize = 0;
            this.btnPrevPurchases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnPrevPurchases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnPrevPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPurchases.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPrevPurchases.Location = new System.Drawing.Point(0, 172);
            this.btnPrevPurchases.Name = "btnPrevPurchases";
            this.btnPrevPurchases.Size = new System.Drawing.Size(300, 80);
            this.btnPrevPurchases.TabIndex = 2;
            this.btnPrevPurchases.Text = "Önceki Siparişler";
            this.btnPrevPurchases.UseVisualStyleBackColor = true;
            this.btnPrevPurchases.MouseEnter += new System.EventHandler(this.btnPrevPurchases_MouseEnter);
            this.btnPrevPurchases.MouseLeave += new System.EventHandler(this.btnPrevPurchases_MouseLeave);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShoppingCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShoppingCart.ForeColor = System.Drawing.Color.White;
            this.btnShoppingCart.Location = new System.Drawing.Point(-3, 86);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(300, 80);
            this.btnShoppingCart.TabIndex = 1;
            this.btnShoppingCart.Text = "Alışveriş Sepeti";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.MouseEnter += new System.EventHandler(this.btnShoppingCart_MouseEnter);
            this.btnShoppingCart.MouseLeave += new System.EventHandler(this.btnShoppingCart_MouseLeave);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.FlatAppearance.BorderSize = 0;
            this.btnUserProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnUserProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserProfile.ForeColor = System.Drawing.Color.White;
            this.btnUserProfile.Location = new System.Drawing.Point(0, 0);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(300, 80);
            this.btnUserProfile.TabIndex = 0;
            this.btnUserProfile.Text = "Kullanıcı Profili";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.MouseEnter += new System.EventHandler(this.btnUserProfile_MouseEnter);
            this.btnUserProfile.MouseLeave += new System.EventHandler(this.btnUserProfile_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.pnlLogo.Controls.Add(this.panel1);
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(300, 190);
            this.pnlLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 35);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 35);
            this.panel2.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Online_Book_Store.Properties.Resources.siyah;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(50, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 160);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // flpnlItems
            // 
            this.flpnlItems.BackColor = System.Drawing.Color.Transparent;
            this.flpnlItems.Location = new System.Drawing.Point(306, 116);
            this.flpnlItems.Name = "flpnlItems";
            this.flpnlItems.Size = new System.Drawing.Size(1260, 780);
            this.flpnlItems.TabIndex = 12;
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProduct.ForeColor = System.Drawing.Color.White;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Kitap",
            "Dergi",
            "Müzik CD"});
            this.cmbProduct.Location = new System.Drawing.Point(306, 75);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(219, 35);
            this.cmbProduct.TabIndex = 13;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(531, 75);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(219, 35);
            this.cmbCategory.TabIndex = 14;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = global::Online_Book_Store.Properties.Resources.minimize__1_;
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinimize.Location = new System.Drawing.Point(1476, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(30, 30);
            this.pbMinimize.TabIndex = 11;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = global::Online_Book_Store.Properties.Resources.stand_by;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(1512, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 30);
            this.pbExit.TabIndex = 10;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Online_Book_Store.Properties.Resources.bookshelf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 909);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.flpnlItems);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPrevPurchases;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.FlowLayoutPanel flpnlItems;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}