namespace Fish_Market_System.view.components
{
    partial class CreditPaymentForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPayAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPayAmountLabel = new System.Windows.Forms.Label();
            this.lblRemainingLabel = new System.Windows.Forms.Label();
            this.lblPaidLabel = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblMerchant = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.cmbPaymentMethod);
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.btnConfirm);
            this.guna2Panel1.Controls.Add(this.txtNote);
            this.guna2Panel1.Controls.Add(this.txtPayAmount);
            this.guna2Panel1.Controls.Add(this.lblPayAmountLabel);
            this.guna2Panel1.Controls.Add(this.lblRemainingLabel);
            this.guna2Panel1.Controls.Add(this.lblPaidLabel);
            this.guna2Panel1.Controls.Add(this.lblTotalLabel);
            this.guna2Panel1.Controls.Add(this.lblCustomer);
            this.guna2Panel1.Controls.Add(this.lblMerchant);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(706, 621);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(470, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(470, 437);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(50, 530);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(229, 48);
            this.txtNote.TabIndex = 8;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayAmount.DefaultText = "";
            this.txtPayAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPayAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayAmount.Location = new System.Drawing.Point(50, 437);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.PlaceholderText = "";
            this.txtPayAmount.SelectedText = "";
            this.txtPayAmount.Size = new System.Drawing.Size(229, 48);
            this.txtPayAmount.TabIndex = 7;
            this.txtPayAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayAmount_KeyDown);
            // 
            // lblPayAmountLabel
            // 
            this.lblPayAmountLabel.AutoSize = true;
            this.lblPayAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPayAmountLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAmountLabel.Location = new System.Drawing.Point(31, 370);
            this.lblPayAmountLabel.Name = "lblPayAmountLabel";
            this.lblPayAmountLabel.Size = new System.Drawing.Size(68, 36);
            this.lblPayAmountLabel.TabIndex = 6;
            this.lblPayAmountLabel.Text = "label1";
            // 
            // lblRemainingLabel
            // 
            this.lblRemainingLabel.AutoSize = true;
            this.lblRemainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingLabel.Location = new System.Drawing.Point(31, 316);
            this.lblRemainingLabel.Name = "lblRemainingLabel";
            this.lblRemainingLabel.Size = new System.Drawing.Size(68, 36);
            this.lblRemainingLabel.TabIndex = 5;
            this.lblRemainingLabel.Text = "label1";
            // 
            // lblPaidLabel
            // 
            this.lblPaidLabel.AutoSize = true;
            this.lblPaidLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPaidLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidLabel.Location = new System.Drawing.Point(31, 265);
            this.lblPaidLabel.Name = "lblPaidLabel";
            this.lblPaidLabel.Size = new System.Drawing.Size(68, 36);
            this.lblPaidLabel.TabIndex = 4;
            this.lblPaidLabel.Text = "label1";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(31, 213);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(68, 36);
            this.lblTotalLabel.TabIndex = 3;
            this.lblTotalLabel.Text = "label1";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(31, 156);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 36);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "label1";
            // 
            // lblMerchant
            // 
            this.lblMerchant.AutoSize = true;
            this.lblMerchant.BackColor = System.Drawing.Color.Transparent;
            this.lblMerchant.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchant.Location = new System.Drawing.Point(31, 99);
            this.lblMerchant.Name = "lblMerchant";
            this.lblMerchant.Size = new System.Drawing.Size(68, 36);
            this.lblMerchant.TabIndex = 1;
            this.lblMerchant.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPaymentMethod.ItemHeight = 30;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(383, 63);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(140, 36);
            this.cmbPaymentMethod.TabIndex = 11;
            // 
            // CreditPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 645);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CreditPaymentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditPaymentForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblPayAmountLabel;
        private System.Windows.Forms.Label lblRemainingLabel;
        private System.Windows.Forms.Label lblPaidLabel;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblMerchant;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPayAmount;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentMethod;
    }
}