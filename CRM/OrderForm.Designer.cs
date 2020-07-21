namespace CRM
{
    partial class OrderForm
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
            this.BusinessRadioButton = new System.Windows.Forms.RadioButton();
            this.IndividualRadioButton = new System.Windows.Forms.RadioButton();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BusinessRadioButton
            // 
            this.BusinessRadioButton.AutoSize = true;
            this.BusinessRadioButton.Location = new System.Drawing.Point(12, 12);
            this.BusinessRadioButton.Name = "BusinessRadioButton";
            this.BusinessRadioButton.Size = new System.Drawing.Size(96, 17);
            this.BusinessRadioButton.TabIndex = 0;
            this.BusinessRadioButton.TabStop = true;
            this.BusinessRadioButton.Text = "Business Client";
            this.BusinessRadioButton.UseVisualStyleBackColor = true;
            this.BusinessRadioButton.Click += new System.EventHandler(this.BusinessRadioButton_Click);
            // 
            // IndividualRadioButton
            // 
            this.IndividualRadioButton.AutoSize = true;
            this.IndividualRadioButton.Location = new System.Drawing.Point(103, 12);
            this.IndividualRadioButton.Name = "IndividualRadioButton";
            this.IndividualRadioButton.Size = new System.Drawing.Size(99, 17);
            this.IndividualRadioButton.TabIndex = 1;
            this.IndividualRadioButton.TabStop = true;
            this.IndividualRadioButton.Text = "Individual Client";
            this.IndividualRadioButton.UseVisualStyleBackColor = true;
            this.IndividualRadioButton.Click += new System.EventHandler(this.IndividualRadioButton_Click);
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(13, 88);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.Size = new System.Drawing.Size(355, 107);
            this.ProductGridView.TabIndex = 2;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellClick);
            // 
            // ClientGridView
            // 
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Location = new System.Drawing.Point(374, 88);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.Size = new System.Drawing.Size(412, 107);
            this.ClientGridView.TabIndex = 3;
            this.ClientGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellClick);
            // 
            // OrderGridView
            // 
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(13, 201);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.Size = new System.Drawing.Size(773, 131);
            this.OrderGridView.TabIndex = 4;
            // 
            // ProductID
            // 
            this.ProductID.Enabled = false;
            this.ProductID.Location = new System.Drawing.Point(75, 35);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(166, 20);
            this.ProductID.TabIndex = 5;
            // 
            // ClientID
            // 
            this.ClientID.Enabled = false;
            this.ClientID.Location = new System.Drawing.Point(75, 61);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(166, 20);
            this.ClientID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client ID";
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(271, 58);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(66, 25);
            this.OrderBtn.TabIndex = 9;
            this.OrderBtn.Text = "Add order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount";
            // 
            // AmountNumeric
            // 
            this.AmountNumeric.Location = new System.Drawing.Point(302, 35);
            this.AmountNumeric.Name = "AmountNumeric";
            this.AmountNumeric.Size = new System.Drawing.Size(94, 20);
            this.AmountNumeric.TabIndex = 12;
            this.AmountNumeric.ValueChanged += new System.EventHandler(this.AmountNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(459, 38);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(10, 13);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "-";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.IndividualRadioButton);
            this.Controls.Add(this.BusinessRadioButton);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BusinessRadioButton;
        private System.Windows.Forms.RadioButton IndividualRadioButton;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmountNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceLabel;
    }
}