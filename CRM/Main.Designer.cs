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
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.AddClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientBtn.Location = new System.Drawing.Point(12, 12);
            this.AddClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(118, 23);
            this.AddClientBtn.TabIndex = 0;
            this.AddClientBtn.TabStop = false;
            this.AddClientBtn.Text = "Add a new client";
            this.AddClientBtn.UseVisualStyleBackColor = false;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1128, 476);
            this.Controls.Add(this.AddClientBtn);
            this.Name = "Main";
            this.Text = "CRM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClientBtn;
    }
}

