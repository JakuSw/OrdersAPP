namespace CRM
{
    partial class Main
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
            this.BClientBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PClientBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BClientBtn
            // 
            this.BClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.BClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClientBtn.Location = new System.Drawing.Point(12, 12);
            this.BClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BClientBtn.Name = "BClientBtn";
            this.BClientBtn.Size = new System.Drawing.Size(118, 23);
            this.BClientBtn.TabIndex = 0;
            this.BClientBtn.TabStop = false;
            this.BClientBtn.Text = "Business customer";
            this.BClientBtn.UseVisualStyleBackColor = false;
            this.BClientBtn.Click += new System.EventHandler(this.BClientBtn_Click);
            // 
            // PClientBtn
            // 
            this.PClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.PClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PClientBtn.Location = new System.Drawing.Point(145, 12);
            this.PClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PClientBtn.Name = "PClientBtn";
            this.PClientBtn.Size = new System.Drawing.Size(118, 23);
            this.PClientBtn.TabIndex = 2;
            this.PClientBtn.TabStop = false;
            this.PClientBtn.Text = "Individual customer";
            this.PClientBtn.UseVisualStyleBackColor = false;
            this.PClientBtn.Click += new System.EventHandler(this.PClientBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Location = new System.Drawing.Point(12, 51);
            this.ProductBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(118, 23);
            this.ProductBtn.TabIndex = 3;
            this.ProductBtn.TabStop = false;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Location = new System.Drawing.Point(145, 51);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(118, 23);
            this.OrderBtn.TabIndex = 4;
            this.OrderBtn.TabStop = false;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(289, 100);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.PClientBtn);
            this.Controls.Add(this.BClientBtn);
            this.Name = "Main";
            this.Text = "CRM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BClientBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PClientBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Button OrderBtn;
    }
}

