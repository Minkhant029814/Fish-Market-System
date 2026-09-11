using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view
{
    partial class AddDailyEntryForm
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
            this.Text = "AddDailyEntryForm";

            this.Text = "📦 ဒိုင်အသစ်သွင်းခြင်း";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblTitle = new Label();
            lblTitle.Text = "📝 ဒိုင်အသစ် ထည့်သွင်းခြင်း";
            lblTitle.Font = new Font("Myanmar Text", 14, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(450, 30);
            this.Controls.Add(lblTitle);

            Label lblProduct = new Label();
            lblProduct.Text = "ငါးအမျိုးအစား *";
            lblProduct.Location = new Point(20, 70);
            lblProduct.Size = new Size(130, 25);
            this.Controls.Add(lblProduct);

            cmbProduct = new ComboBox();
            cmbProduct.Location = new Point(160, 70);
            cmbProduct.Size = new Size(300, 25);
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbProduct);

            Label lblQuantity = new Label();
            lblQuantity.Text = "အလေးချိန် (ပိဿာ) *";
            lblQuantity.Location = new Point(20, 110);
            lblQuantity.Size = new Size(130, 25);
            this.Controls.Add(lblQuantity);

            txtQuantity = new TextBox();
            txtQuantity.Location = new Point(160, 110);
            txtQuantity.Size = new Size(140, 25);
            txtQuantity.Text = "0";
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            this.Controls.Add(txtQuantity);

            Label lblPrice = new Label();
            lblPrice.Text = "ဝယ်ဈေး (ကျပ်) *";
            lblPrice.Location = new Point(20, 150);
            lblPrice.Size = new Size(130, 25);
            this.Controls.Add(lblPrice);

            txtPrice = new TextBox();
            txtPrice.Location = new Point(160, 150);
            txtPrice.Size = new Size(140, 25);
            txtPrice.Text = "0";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            this.Controls.Add(txtPrice);

            Label lblNote = new Label();
            lblNote.Text = "မှတ်ချက်";
            lblNote.Location = new Point(20, 190);
            lblNote.Size = new Size(130, 25);
            this.Controls.Add(lblNote);

            txtNote = new TextBox();
            txtNote.Location = new Point(160, 190);
            txtNote.Size = new Size(300, 80);
            txtNote.Multiline = true;
            this.Controls.Add(txtNote);

            btnSave = new Button();
            btnSave.Text = "💾 သိမ်းမည်";
            btnSave.Location = new Point(160, 290);
            btnSave.Size = new Size(140, 40);
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            Button btnCancel = new Button();
            btnCancel.Text = "❌ ပယ်ဖျက်မည်";
            btnCancel.Location = new Point(320, 290);
            btnCancel.Size = new Size(140, 40);
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Font = new Font("Myanmar Text", 11, FontStyle.Bold);
            //btnCancel.Click += (s, e) => this.Close();
            this.Controls.Add(btnCancel);
        }

        #endregion
    }
}