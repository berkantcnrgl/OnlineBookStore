namespace Online_Book_Store
{
    partial class AdminProfileForm
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
            this.tabctrlAdmin = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.tbpBooks = new System.Windows.Forms.TabPage();
            this.tbpMagazines = new System.Windows.Forms.TabPage();
            this.tbpMusicCDs = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvMagazines = new System.Windows.Forms.DataGridView();
            this.BookColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookColContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColİsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagazineColIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicCds = new System.Windows.Forms.DataGridView();
            this.MusicCdColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicCdColContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrlAdmin.SuspendLayout();
            this.tbpCustomers.SuspendLayout();
            this.tbpBooks.SuspendLayout();
            this.tbpMagazines.SuspendLayout();
            this.tbpMusicCDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicCds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlAdmin
            // 
            this.tabctrlAdmin.Controls.Add(this.tbpCustomers);
            this.tabctrlAdmin.Controls.Add(this.tbpBooks);
            this.tabctrlAdmin.Controls.Add(this.tbpMagazines);
            this.tabctrlAdmin.Controls.Add(this.tbpMusicCDs);
            this.tabctrlAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabctrlAdmin.Location = new System.Drawing.Point(12, 3);
            this.tabctrlAdmin.Name = "tabctrlAdmin";
            this.tabctrlAdmin.SelectedIndex = 0;
            this.tabctrlAdmin.Size = new System.Drawing.Size(1300, 900);
            this.tabctrlAdmin.TabIndex = 0;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.Controls.Add(this.dgvCustomers);
            this.tbpCustomers.Location = new System.Drawing.Point(4, 28);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(1292, 868);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "Customers";
            this.tbpCustomers.UseVisualStyleBackColor = true;
            // 
            // tbpBooks
            // 
            this.tbpBooks.Controls.Add(this.dgvBooks);
            this.tbpBooks.Location = new System.Drawing.Point(4, 28);
            this.tbpBooks.Name = "tbpBooks";
            this.tbpBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBooks.Size = new System.Drawing.Size(1292, 868);
            this.tbpBooks.TabIndex = 1;
            this.tbpBooks.Text = "Books";
            this.tbpBooks.UseVisualStyleBackColor = true;
            // 
            // tbpMagazines
            // 
            this.tbpMagazines.Controls.Add(this.dgvMagazines);
            this.tbpMagazines.Location = new System.Drawing.Point(4, 28);
            this.tbpMagazines.Name = "tbpMagazines";
            this.tbpMagazines.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMagazines.Size = new System.Drawing.Size(1292, 868);
            this.tbpMagazines.TabIndex = 2;
            this.tbpMagazines.Text = "Magazines";
            this.tbpMagazines.UseVisualStyleBackColor = true;
            // 
            // tbpMusicCDs
            // 
            this.tbpMusicCDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbpMusicCDs.Controls.Add(this.dgvMusicCds);
            this.tbpMusicCDs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpMusicCDs.Location = new System.Drawing.Point(4, 28);
            this.tbpMusicCDs.Name = "tbpMusicCDs";
            this.tbpMusicCDs.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMusicCDs.Size = new System.Drawing.Size(1292, 868);
            this.tbpMusicCDs.TabIndex = 3;
            this.tbpMusicCDs.Text = "MusicCDs";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookColId,
            this.BookColName,
            this.BookColPrice,
            this.BookColIsbn,
            this.BookColAuthor,
            this.BookColPublisher,
            this.BookColContent});
            this.dgvBooks.Location = new System.Drawing.Point(7, 7);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(753, 568);
            this.dgvBooks.TabIndex = 0;
            // 
            // dgvMagazines
            // 
            this.dgvMagazines.AllowUserToAddRows = false;
            this.dgvMagazines.AllowUserToDeleteRows = false;
            this.dgvMagazines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MagazineColID,
            this.MagazineColName,
            this.MagazineColPrice,
            this.MagazineColType,
            this.MagazineColİsbn,
            this.MagazineColIssue});
            this.dgvMagazines.Location = new System.Drawing.Point(7, 7);
            this.dgvMagazines.Name = "dgvMagazines";
            this.dgvMagazines.ReadOnly = true;
            this.dgvMagazines.Size = new System.Drawing.Size(660, 568);
            this.dgvMagazines.TabIndex = 0;
            // 
            // BookColId
            // 
            this.BookColId.HeaderText = "ID";
            this.BookColId.Name = "BookColId";
            this.BookColId.ReadOnly = true;
            // 
            // BookColName
            // 
            this.BookColName.HeaderText = "İsim";
            this.BookColName.Name = "BookColName";
            this.BookColName.ReadOnly = true;
            // 
            // BookColPrice
            // 
            this.BookColPrice.HeaderText = "Fiyat";
            this.BookColPrice.Name = "BookColPrice";
            this.BookColPrice.ReadOnly = true;
            // 
            // BookColIsbn
            // 
            this.BookColIsbn.HeaderText = "Barkod";
            this.BookColIsbn.Name = "BookColIsbn";
            this.BookColIsbn.ReadOnly = true;
            // 
            // BookColAuthor
            // 
            this.BookColAuthor.HeaderText = "Yazar";
            this.BookColAuthor.Name = "BookColAuthor";
            this.BookColAuthor.ReadOnly = true;
            // 
            // BookColPublisher
            // 
            this.BookColPublisher.HeaderText = "Yayımcı";
            this.BookColPublisher.Name = "BookColPublisher";
            this.BookColPublisher.ReadOnly = true;
            // 
            // BookColContent
            // 
            this.BookColContent.HeaderText = "İçerik";
            this.BookColContent.Name = "BookColContent";
            this.BookColContent.ReadOnly = true;
            // 
            // MagazineColID
            // 
            this.MagazineColID.HeaderText = "ID";
            this.MagazineColID.Name = "MagazineColID";
            this.MagazineColID.ReadOnly = true;
            // 
            // MagazineColName
            // 
            this.MagazineColName.HeaderText = "İsim";
            this.MagazineColName.Name = "MagazineColName";
            this.MagazineColName.ReadOnly = true;
            // 
            // MagazineColPrice
            // 
            this.MagazineColPrice.HeaderText = "Fiyat";
            this.MagazineColPrice.Name = "MagazineColPrice";
            this.MagazineColPrice.ReadOnly = true;
            // 
            // MagazineColType
            // 
            this.MagazineColType.HeaderText = "Tür";
            this.MagazineColType.Name = "MagazineColType";
            this.MagazineColType.ReadOnly = true;
            // 
            // MagazineColİsbn
            // 
            this.MagazineColİsbn.HeaderText = "Barkod";
            this.MagazineColİsbn.Name = "MagazineColİsbn";
            this.MagazineColİsbn.ReadOnly = true;
            // 
            // MagazineColIssue
            // 
            this.MagazineColIssue.HeaderText = "İçerik";
            this.MagazineColIssue.Name = "MagazineColIssue";
            this.MagazineColIssue.ReadOnly = true;
            // 
            // dgvMusicCds
            // 
            this.dgvMusicCds.AllowUserToAddRows = false;
            this.dgvMusicCds.AllowUserToDeleteRows = false;
            this.dgvMusicCds.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvMusicCds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicCds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusicCdColId,
            this.MusicCdColName,
            this.MusicCdColPrice,
            this.MusicCdColIsbn,
            this.MusicCdColReleaseDate,
            this.MusicCdColSinger,
            this.MusicCdColType,
            this.MusicCdColContent});
            this.dgvMusicCds.Location = new System.Drawing.Point(0, 0);
            this.dgvMusicCds.Name = "dgvMusicCds";
            this.dgvMusicCds.ReadOnly = true;
            this.dgvMusicCds.Size = new System.Drawing.Size(858, 567);
            this.dgvMusicCds.TabIndex = 0;
            // 
            // MusicCdColId
            // 
            this.MusicCdColId.HeaderText = "ID";
            this.MusicCdColId.Name = "MusicCdColId";
            this.MusicCdColId.ReadOnly = true;
            // 
            // MusicCdColName
            // 
            this.MusicCdColName.HeaderText = "İsim";
            this.MusicCdColName.Name = "MusicCdColName";
            this.MusicCdColName.ReadOnly = true;
            // 
            // MusicCdColPrice
            // 
            this.MusicCdColPrice.HeaderText = "Fiyat";
            this.MusicCdColPrice.Name = "MusicCdColPrice";
            this.MusicCdColPrice.ReadOnly = true;
            // 
            // MusicCdColIsbn
            // 
            this.MusicCdColIsbn.HeaderText = "Barkod";
            this.MusicCdColIsbn.Name = "MusicCdColIsbn";
            this.MusicCdColIsbn.ReadOnly = true;
            // 
            // MusicCdColReleaseDate
            // 
            this.MusicCdColReleaseDate.HeaderText = "Çıkış Yılı";
            this.MusicCdColReleaseDate.Name = "MusicCdColReleaseDate";
            this.MusicCdColReleaseDate.ReadOnly = true;
            // 
            // MusicCdColSinger
            // 
            this.MusicCdColSinger.HeaderText = "Şarkıcı";
            this.MusicCdColSinger.Name = "MusicCdColSinger";
            this.MusicCdColSinger.ReadOnly = true;
            // 
            // MusicCdColType
            // 
            this.MusicCdColType.HeaderText = "Tür";
            this.MusicCdColType.Name = "MusicCdColType";
            this.MusicCdColType.ReadOnly = true;
            // 
            // MusicCdColContent
            // 
            this.MusicCdColContent.HeaderText = "İçerik";
            this.MusicCdColContent.Name = "MusicCdColContent";
            this.MusicCdColContent.ReadOnly = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerColId,
            this.CustomerColName,
            this.CustomerColSurname,
            this.CustomerColAddress,
            this.CustomerColEmail,
            this.CustomerColUsername,
            this.CustomerColPassword});
            this.dgvCustomers.Location = new System.Drawing.Point(7, 7);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(756, 567);
            this.dgvCustomers.TabIndex = 0;
            // 
            // CustomerColId
            // 
            this.CustomerColId.HeaderText = "ID";
            this.CustomerColId.Name = "CustomerColId";
            this.CustomerColId.ReadOnly = true;
            // 
            // CustomerColName
            // 
            this.CustomerColName.HeaderText = "İsim";
            this.CustomerColName.Name = "CustomerColName";
            this.CustomerColName.ReadOnly = true;
            // 
            // CustomerColSurname
            // 
            this.CustomerColSurname.HeaderText = "Soyisim";
            this.CustomerColSurname.Name = "CustomerColSurname";
            this.CustomerColSurname.ReadOnly = true;
            // 
            // CustomerColAddress
            // 
            this.CustomerColAddress.HeaderText = "Adres";
            this.CustomerColAddress.Name = "CustomerColAddress";
            this.CustomerColAddress.ReadOnly = true;
            // 
            // CustomerColEmail
            // 
            this.CustomerColEmail.HeaderText = "E-Posta";
            this.CustomerColEmail.Name = "CustomerColEmail";
            this.CustomerColEmail.ReadOnly = true;
            // 
            // CustomerColUsername
            // 
            this.CustomerColUsername.HeaderText = "Kullanıcı Adı";
            this.CustomerColUsername.Name = "CustomerColUsername";
            this.CustomerColUsername.ReadOnly = true;
            // 
            // CustomerColPassword
            // 
            this.CustomerColPassword.HeaderText = "Şifre";
            this.CustomerColPassword.Name = "CustomerColPassword";
            this.CustomerColPassword.ReadOnly = true;
            // 
            // AdminProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.tabctrlAdmin);
            this.Name = "AdminProfileForm";
            this.Text = "AdminProfileForm";
            this.tabctrlAdmin.ResumeLayout(false);
            this.tbpCustomers.ResumeLayout(false);
            this.tbpBooks.ResumeLayout(false);
            this.tbpMagazines.ResumeLayout(false);
            this.tbpMusicCDs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicCds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlAdmin;
        private System.Windows.Forms.TabPage tbpCustomers;
        private System.Windows.Forms.TabPage tbpBooks;
        private System.Windows.Forms.TabPage tbpMagazines;
        private System.Windows.Forms.TabPage tbpMusicCDs;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColPassword;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColContent;
        private System.Windows.Forms.DataGridView dgvMagazines;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColİsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagazineColIssue;
        private System.Windows.Forms.DataGridView dgvMusicCds;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicCdColContent;
    }
}