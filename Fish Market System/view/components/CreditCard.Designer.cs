namespace Fish_Market_System.view.components
{
    partial class CreditCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCreditPay = new Guna.UI2.WinForms.Guna2Button();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAmount.Location = new System.Drawing.Point(19, 83);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(61, 32);
            this.lblRemainingAmount.TabIndex = 4;
            this.lblRemainingAmount.Text = "label2";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(19, 129);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(61, 32);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "label2";
            // 
            // btnCreditPay
            // 
            this.btnCreditPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreditPay.BorderRadius = 15;
            this.btnCreditPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreditPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreditPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreditPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreditPay.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditPay.ForeColor = System.Drawing.Color.White;
            this.btnCreditPay.Location = new System.Drawing.Point(562, 54);
            this.btnCreditPay.Name = "btnCreditPay";
            this.btnCreditPay.Size = new System.Drawing.Size(213, 66);
            this.btnCreditPay.TabIndex = 2;
            this.btnCreditPay.Text = "အကြွေးပေးသည်";
            this.btnCreditPay.Click += new System.EventHandler(this.btnCreditPay_Click);
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditAmount.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditAmount.Location = new System.Drawing.Point(172, 129);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(61, 32);
            this.lblCreditAmount.TabIndex = 1;
            this.lblCreditAmount.Text = "label2";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.BackColor = System.Drawing.Color.Transparent;
            this.lblMerchantName.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantName.Location = new System.Drawing.Point(19, 18);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(61, 32);
            this.lblMerchantName.TabIndex = 0;
            this.lblMerchantName.Text = "label1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.lblMerchantName);
            this.guna2Panel1.Controls.Add(this.btnCreditPay);
            this.guna2Panel1.Controls.Add(this.lblRemainingAmount);
            this.guna2Panel1.Controls.Add(this.lblCreditAmount);
            this.guna2Panel1.Controls.Add(this.lblCustomerName);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 16);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(818, 201);
            this.guna2Panel1.TabIndex = 5;
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CreditCard";
            this.Size = new System.Drawing.Size(846, 220);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCreditPay;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRemainingAmount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
