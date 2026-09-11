using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "CreditPaymentForm";

            this.Text = "📋 အကြွေးစာရင်း";
            this.Size = new Size(1000, 500);
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblTitle = new Label();
            lblTitle.Text = "📋 အကြွေးစာရင်း";
            lblTitle.Font = new Font("Myanmar Text", 14, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            dgvCredit = new DataGridView();
            dgvCredit.Location = new Point(20, 60);
            dgvCredit.Size = new Size(960, 380);
            dgvCredit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCredit.ReadOnly = true;
            dgvCredit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Controls.Add(dgvCredit);

            Button btnPay = new Button();
            btnPay.Text = "💰 ကြွေးပေးမည်";
            btnPay.Location = new Point(20, 450);
            btnPay.Size = new Size(150, 40);
            btnPay.BackColor = Color.LightGreen;
            btnPay.Click += BtnPay_Click;
            this.Controls.Add(btnPay);

            Button btnClose = new Button();
            btnClose.Text = "❌ ပိတ်မည်";
            btnClose.Location = new Point(180, 450);
            btnClose.Size = new Size(150, 40);
            btnClose.BackColor = Color.LightCoral;
            //btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        #endregion
    }
}