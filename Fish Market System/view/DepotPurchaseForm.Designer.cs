namespace Fish_Market_System.view
{
    partial class DepotPurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.cbDepotRemain = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.btnAddPurchases = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSpecies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDepot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseDetailsView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.depotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.Controls.Add(this.cbDepotRemain);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.cmbPayment);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.cmbCus);
            this.mainPanel.Controls.Add(this.lblMerchantName);
            this.mainPanel.Controls.Add(this.lblTotalAmount);
            this.mainPanel.Controls.Add(this.lblTotalQuantity);
            this.mainPanel.Controls.Add(this.btnAddPurchases);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.txtBuyPrice);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.txtQuantity);
            this.mainPanel.Controls.Add(this.cmbSpecies);
            this.mainPanel.Controls.Add(this.cmbDepot);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.FillColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1364, 320);
            this.mainPanel.TabIndex = 0;
            // 
            // cbDepotRemain
            // 
            this.cbDepotRemain.AutoSize = true;
            this.cbDepotRemain.BackColor = System.Drawing.Color.White;
            this.cbDepotRemain.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.cbDepotRemain.CheckedState.BorderRadius = 0;
            this.cbDepotRemain.CheckedState.BorderThickness = 0;
            this.cbDepotRemain.CheckedState.FillColor = System.Drawing.Color.White;
            this.cbDepotRemain.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.cbDepotRemain.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepotRemain.Location = new System.Drawing.Point(19, 192);
            this.cbDepotRemain.Name = "cbDepotRemain";
            this.cbDepotRemain.Size = new System.Drawing.Size(96, 40);
            this.cbDepotRemain.TabIndex = 20;
            this.cbDepotRemain.Text = "ဒိုင်ကျန်";
            this.cbDepotRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDepotRemain.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.cbDepotRemain.UncheckedState.BorderRadius = 0;
            this.cbDepotRemain.UncheckedState.BorderThickness = 0;
            this.cbDepotRemain.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbDepotRemain.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1197, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "ဝယ်ယူမှုပုံစံ";
            // 
            // cmbPayment
            // 
            this.cmbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPayment.BackColor = System.Drawing.Color.Transparent;
            this.cmbPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPayment.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPayment.ItemHeight = 45;
            this.cmbPayment.Items.AddRange(new object[] {
            "လက်ငင်း",
            "အကြွေး"});
            this.cmbPayment.Location = new System.Drawing.Point(1163, 177);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(163, 51);
            this.cmbPayment.StartIndex = 0;
            this.cmbPayment.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "ဖောက်သည်နာမည်များ";
            // 
            // cmbCus
            // 
            this.cmbCus.BackColor = System.Drawing.Color.Transparent;
            this.cmbCus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCus.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCus.ItemHeight = 30;
            this.cmbCus.Location = new System.Drawing.Point(204, 192);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(219, 36);
            this.cmbCus.TabIndex = 16;
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.BackColor = System.Drawing.Color.Transparent;
            this.lblMerchantName.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantName.Location = new System.Drawing.Point(553, 21);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(208, 50);
            this.lblMerchantName.TabIndex = 15;
            this.lblMerchantName.Text = " ကုန်သည်အမည်";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(633, 264);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(61, 32);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.Text = "label2";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.lblTotalQuantity.Location = new System.Drawing.Point(13, 264);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(61, 32);
            this.lblTotalQuantity.TabIndex = 13;
            this.lblTotalQuantity.Text = "label2";
            // 
            // btnAddPurchases
            // 
            this.btnAddPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPurchases.BorderRadius = 15;
            this.btnAddPurchases.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurchases.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurchases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPurchases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPurchases.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.btnAddPurchases.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchases.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchases.Location = new System.Drawing.Point(1146, 251);
            this.btnAddPurchases.Name = "btnAddPurchases";
            this.btnAddPurchases.Size = new System.Drawing.Size(180, 45);
            this.btnAddPurchases.TabIndex = 12;
            this.btnAddPurchases.Text = "စာရင်းသွင်းသည်";
            this.btnAddPurchases.Click += new System.EventHandler(this.btnAddPurchases_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(944, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "ဈေးနှုန်း";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuyPrice.DefaultText = "";
            this.txtBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyPrice.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyPrice.Location = new System.Drawing.Point(907, 180);
            this.txtBuyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.PlaceholderText = "";
            this.txtBuyPrice.SelectedText = "";
            this.txtBuyPrice.Size = new System.Drawing.Size(229, 48);
            this.txtBuyPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "အလေးချိန်";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(707, 180);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(165, 48);
            this.txtQuantity.TabIndex = 8;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.BackColor = System.Drawing.Color.Transparent;
            this.cmbSpecies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpecies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSpecies.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSpecies.ItemHeight = 30;
            this.cmbSpecies.Location = new System.Drawing.Point(457, 192);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(219, 36);
            this.cmbSpecies.TabIndex = 7;
            // 
            // cmbDepot
            // 
            this.cmbDepot.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepot.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepot.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepot.ItemHeight = 30;
            this.cmbDepot.Location = new System.Drawing.Point(105, 21);
            this.cmbDepot.Name = "cmbDepot";
            this.cmbDepot.Size = new System.Drawing.Size(223, 36);
            this.cmbDepot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "ငါးအမျိုးစားများ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ဒိုင်";
            // 
            // purchaseDetailsView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.purchaseDetailsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseDetailsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseDetailsView.ColumnHeadersHeight = 51;
            this.purchaseDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchaseDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depotName,
            this.FishType,
            this.BuyPrice,
            this.Quantity,
            this.TotalAmount,
            this.purchaseDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseDetailsView.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseDetailsView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseDetailsView.Location = new System.Drawing.Point(12, 353);
            this.purchaseDetailsView.Name = "purchaseDetailsView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.purchaseDetailsView.RowHeadersVisible = false;
            this.purchaseDetailsView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.purchaseDetailsView.RowTemplate.Height = 30;
            this.purchaseDetailsView.Size = new System.Drawing.Size(1356, 345);
            this.purchaseDetailsView.TabIndex = 1;
            this.purchaseDetailsView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseDetailsView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.purchaseDetailsView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.ThemeStyle.HeaderStyle.Height = 51;
            this.purchaseDetailsView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.ThemeStyle.RowsStyle.Height = 30;
            // 
            // depotName
            // 
            this.depotName.HeaderText = "ဝယ်သူအမည်";
            this.depotName.MinimumWidth = 6;
            this.depotName.Name = "depotName";
            // 
            // FishType
            // 
            this.FishType.HeaderText = " ငါးအမျိုးစား";
            this.FishType.MinimumWidth = 6;
            this.FishType.Name = "FishType";
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "ဈေးနှုန်း";
            this.BuyPrice.MinimumWidth = 6;
            this.BuyPrice.Name = "BuyPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "အရေအတွက်";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "စုစုပေါင်းတန်ဖိုး";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            // 
            // purchaseDate
            // 
            this.purchaseDate.HeaderText = "ဝယ်ယူမှုပုံစံ";
            this.purchaseDate.MinimumWidth = 6;
            this.purchaseDate.Name = "purchaseDate";
            // 
            // DepotPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 710);
            this.Controls.Add(this.purchaseDetailsView);
            this.Controls.Add(this.mainPanel);
            this.Name = "DepotPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepotPurchaseForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtBuyPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSpecies;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddPurchases;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseDetailsView;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCus;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private Guna.UI2.WinForms.Guna2CheckBox cbDepotRemain;
    }
}