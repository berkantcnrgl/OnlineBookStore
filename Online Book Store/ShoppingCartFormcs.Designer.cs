namespace Online_Book_Store
{
    partial class ShoppingCartFormcs
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
            this.flpnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpnlProduct
            // 
            this.flpnlProduct.Location = new System.Drawing.Point(30, 32);
            this.flpnlProduct.Name = "flpnlProduct";
            this.flpnlProduct.Size = new System.Drawing.Size(200, 237);
            this.flpnlProduct.TabIndex = 0;
            // 
            // ShoppingCartFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpnlProduct);
            this.Name = "ShoppingCartFormcs";
            this.Text = "w";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlProduct;
    }
}