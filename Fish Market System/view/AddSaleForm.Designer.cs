using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view
{
    partial class AddSaleForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AddSaleForm";

            
            this.Text = "💰 ရောင်းချခြင်း";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblTitle = new Label();
            lblTitle.Text = "💰 ရောင်းချခြင်း (ဒိုင်ရွေးပြီးရောင်း)";
            lblTitle.Font = new Font("Myanmar Text", 14, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(550, 30);
            this.Controls.Add(lblTitle);

            // Entry
            Label lblEntry = new Label();
            lblEntry.Text = "ဒိုင်ရွေးပါ *";
            lblEntry.Location = new Point(20, 70);
            lblEntry.Size = new Size(130, 25);
            this.Controls.Add(lblEntry);

            cmbEntry = new ComboBox();
            cmbEntry.Location = new Point(160, 70);
            cmbEntry.Size = new Size(400, 25);
            cmbEntry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntry.SelectedIndexChanged += CmbEntry_SelectedIndexChanged;
            this.Controls.Add(cmbEntry);

            Label lblEntryInfo = new Label();
            lblEntryInfo.Name = "lblEntryInfo";
            lblEntryInfo.Location = new Point(160, 100);
            lblEntryInfo.Size = new Size(400, 20);
            lblEntryInfo.Font = new Font("Myanmar Text", 9);
            lblEntryInfo.ForeColor = Color.Gray;
            this.Controls.Add(lblEntryInfo);

            // Customer
            Label lblCustomer = new Label();
            lblCustomer.Text = "ဝယ်သူ *";
            lblCustomer.Location = new Point(20, 130);
            lblCustomer.Size = new Size(130, 25);
            this.Controls.Add(lblCustomer);

            cmbCustomer = new ComboBox();
            cmbCustomer.Location = new Point(160, 130);
            cmbCustomer.Size = new Size(400, 25);
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbCustomer);

            // Customer Type
            Label lblCustomerType = new Label();
            lblCustomerType.Text = "ဝယ်လက်အမျိုးစား *";
            lblCustomerType.Location = new Point(20, 170);
            lblCustomerType.Size = new Size(130, 25);
            this.Controls.Add(lblCustomerType);

            cmbCustomerType = new ComboBox();
            cmbCustomerType.Location = new Point(160, 170);
            cmbCustomerType.Size = new Size(200, 25);
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.Items.AddRange(new object[] { "Cash", "Credit", "Remote" });
            cmbCustomerType.SelectedIndex = 0;
            this.Controls.Add(cmbCustomerType);

            // Quantity
            Label lblQuantity = new Label();
            lblQuantity.Text = "အလေးချိန် (ပိဿာ) *";
            lblQuantity.Location = new Point(20, 210);
            lblQuantity.Size = new Size(130, 25);
            this.Controls.Add(lblQuantity);

            txtQuantity = new TextBox();
            txtQuantity.Location = new Point(160, 210);
            txtQuantity.Size = new Size(140, 25);
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.TextChanged += CalculateTotal;
            this.Controls.Add(txtQuantity);

            Label lblRemaining = new Label();
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Location = new Point(320, 210);
            lblRemaining.Size = new Size(200, 25);
            lblRemaining.Font = new Font("Myanmar Text", 9);
            lblRemaining.ForeColor = Color.Gray;
            this.Controls.Add(lblRemaining);

            // Sale Price
            Label lblSalePrice = new Label();
            lblSalePrice.Text = "ရောင်းဈေး (ကျပ်) *";
            lblSalePrice.Location = new Point(20, 250);
            lblSalePrice.Size = new Size(130, 25);
            this.Controls.Add(lblSalePrice);

            txtSalePrice = new TextBox();
            txtSalePrice.Location = new Point(160, 250);
            txtSalePrice.Size = new Size(140, 25);
            txtSalePrice.Text = "0";
            txtSalePrice.TextAlign = HorizontalAlignment.Right;
            txtSalePrice.TextChanged += CalculateTotal;
            this.Controls.Add(txtSalePrice);

            // Total
            Label lblTotal = new Label();
            lblTotal.Text = "စုစုပေါင်းငွေ";
            lblTotal.Location = new Point(20, 290);
            lblTotal.Size = new Size(130, 25);
            lblTotal.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            this.Controls.Add(lblTotal);

            txtTotal = new TextBox();
            txtTotal.Location = new Point(160, 290);
            txtTotal.Size = new Size(140, 25);
            txtTotal.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.ReadOnly = true;
            txtTotal.BackColor = Color.LightYellow;
            this.Controls.Add(txtTotal);

            // Note
            Label lblNote = new Label();
            lblNote.Text = "မှတ်ချက်";
            lblNote.Location = new Point(20, 330);
            lblNote.Size = new Size(130, 25);
            this.Controls.Add(lblNote);

            txtNote = new TextBox();
            txtNote.Location = new Point(160, 330);
            txtNote.Size = new Size(400, 60);
            txtNote.Multiline = true;
            this.Controls.Add(txtNote);

            // Buttons
            btnSave = new Button();
            btnSave.Text = "💾 ရောင်းမည်";
            btnSave.Location = new Point(160, 410);
            btnSave.Size = new Size(140, 40);
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            Button btnCancel = new Button();
            btnCancel.Text = "❌ ပယ်ဖျက်မည်";
            btnCancel.Location = new Point(320, 410);
            btnCancel.Size = new Size(140, 40);
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            //btnCancel.Click += (s, e) => this.Close();
            this.Controls.Add(btnCancel);
        
    }

        #endregion
    }
}