namespace Online_Book_Store
{
    partial class FormLogin
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtUserName.Location = new System.Drawing.Point(224, 239);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 32);
            this.txtUserName.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(43, 240);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(145, 29);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Kullanıcı Adı";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(43, 312);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(63, 29);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox1.Location = new System.Drawing.Point(224, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 32);
            this.textBox1.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(163, 419);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 90);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseMove);
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Underline);
            this.lbSignUp.ForeColor = System.Drawing.Color.White;
            this.lbSignUp.Location = new System.Drawing.Point(219, 555);
            this.lbSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(96, 29);
            this.lbSignUp.TabIndex = 5;
            this.lbSignUp.Text = "Kayıt Ol";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            this.lbSignUp.MouseEnter += new System.EventHandler(this.lbSignUp_MouseEnter);
            this.lbSignUp.MouseLeave += new System.EventHandler(this.lbSignUp_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Online_Book_Store.Properties.Resources.siyah;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(163, 31);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(242, 188);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Book_Store.Properties.Resources.LoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 616);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.txtUserName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

