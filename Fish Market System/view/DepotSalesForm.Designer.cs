namespace Fish_Market_System.view
{
    partial class DepotSalesForm
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FishByDepotPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRemaingStockByDepot = new System.Windows.Forms.Label();
            this.btnAddSales = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFishes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMerchants = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 25;
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.FillColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 589);
            this.mainPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.Controls.Add(this.cmbMerchants);
            this.headerPanel.Controls.Add(this.label6);
            this.headerPanel.Controls.Add(this.FishByDepotPanel);
            this.headerPanel.Controls.Add(this.lblRemaingStockByDepot);
            this.headerPanel.Controls.Add(this.btnAddSales);
            this.headerPanel.Controls.Add(this.cmbPaymentType);
            this.headerPanel.Controls.Add(this.label5);
            this.headerPanel.Controls.Add(this.txtQuantity);
            this.headerPanel.Controls.Add(this.txtPrice);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.cmbFishes);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.cmbDepot);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Location = new System.Drawing.Point(23, 23);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1060, 537);
            this.headerPanel.TabIndex = 0;
            // 
            // FishByDepotPanel
            // 
            this.FishByDepotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FishByDepotPanel.AutoScroll = true;
            this.FishByDepotPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FishByDepotPanel.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FishByDepotPanel.Location = new System.Drawing.Point(618, 132);
            this.FishByDepotPanel.Name = "FishByDepotPanel";
            this.FishByDepotPanel.Size = new System.Drawing.Size(399, 139);
            this.FishByDepotPanel.TabIndex = 1;
            this.FishByDepotPanel.WrapContents = false;
            // 
            // lblRemaingStockByDepot
            // 
            this.lblRemaingStockByDepot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRemaingStockByDepot.AutoSize = true;
            this.lblRemaingStockByDepot.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaingStockByDepot.ForeColor = System.Drawing.Color.Blue;
            this.lblRemaingStockByDepot.Location = new System.Drawing.Point(400, 79);
            this.lblRemaingStockByDepot.Name = "lblRemaingStockByDepot";
            this.lblRemaingStockByDepot.Size = new System.Drawing.Size(68, 36);
            this.lblRemaingStockByDepot.TabIndex = 12;
            this.lblRemaingStockByDepot.Text = "label1";
            this.lblRemaingStockByDepot.Click += new System.EventHandler(this.lblRemaingStockByDepot_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSales.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.ForeColor = System.Drawing.Color.White;
            this.btnAddSales.Location = new System.Drawing.Point(729, 466);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(288, 43);
            this.btnAddSales.TabIndex = 11;
            this.btnAddSales.Text = "အရောင်းစာရင်းထည့်သွင်းသည်";
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentType.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.ForeColor = System.Drawing.Color.Blue;
            this.cmbPaymentType.ItemHeight = 30;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "လက်ငင်း",
            "အကြွေး",
            "နယ်ဝေး"});
            this.cmbPaymentType.Location = new System.Drawing.Point(760, 360);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(161, 36);
            this.cmbPaymentType.StartIndex = 0;
            this.cmbPaymentType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "ဝယ်ယူမှုပုံစံ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(479, 348);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(229, 48);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(205, 348);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(229, 48);
            this.txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "အလေးချိန်";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "ဈေးနှုန်း";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ငါးအမျိုးစား";
            // 
            // cmbFishes
            // 
            this.cmbFishes.BackColor = System.Drawing.Color.Transparent;
            this.cmbFishes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFishes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFishes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFishes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFishes.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFishes.ForeColor = System.Drawing.Color.Blue;
            this.cmbFishes.ItemHeight = 30;
            this.cmbFishes.Location = new System.Drawing.Point(12, 360);
            this.cmbFishes.Name = "cmbFishes";
            this.cmbFishes.Size = new System.Drawing.Size(161, 36);
            this.cmbFishes.TabIndex = 3;
            this.cmbFishes.SelectedIndexChanged += new System.EventHandler(this.cmbFishes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "ဒိုင်နာမည်";
            // 
            // cmbDepot
            // 
            this.cmbDepot.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepot.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepot.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepot.ForeColor = System.Drawing.Color.Blue;
            this.cmbDepot.ItemHeight = 30;
            this.cmbDepot.Location = new System.Drawing.Point(185, 172);
            this.cmbDepot.Name = "cmbDepot";
            this.cmbDepot.Size = new System.Drawing.Size(264, 36);
            this.cmbDepot.TabIndex = 1;
            this.cmbDepot.SelectedIndexChanged += new System.EventHandler(this.cmbDepot_SelectedIndexChanged_1);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(397, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "ကုန်သည်အမည်";
            // 
            // cmbMerchants
            // 
            this.cmbMerchants.BackColor = System.Drawing.Color.Transparent;
            this.cmbMerchants.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMerchants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerchants.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMerchants.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMerchants.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMerchants.ForeColor = System.Drawing.Color.Blue;
            this.cmbMerchants.ItemHeight = 30;
            this.cmbMerchants.Location = new System.Drawing.Point(185, 235);
            this.cmbMerchants.Name = "cmbMerchants";
            this.cmbMerchants.Size = new System.Drawing.Size(264, 36);
            this.cmbMerchants.TabIndex = 14;
            // 
            // DepotSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 613);
            this.Controls.Add(this.mainPanel);
            this.Name = "DepotSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepotSalesForm";
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFishes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepot;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnAddSales;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRemaingStockByDepot;
        private System.Windows.Forms.FlowLayoutPanel FishByDepotPanel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMerchants;
        private System.Windows.Forms.Label label6;
    }
}