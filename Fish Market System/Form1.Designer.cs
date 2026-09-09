using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.merchantPage = new System.Windows.Forms.TabPage();
            this.lblMerchantCounts = new System.Windows.Forms.Label();
            this.merchantPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddMerchant = new Guna.UI2.WinForms.Guna2Button();
            this.txtMerchantName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCustomerCounts = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.txtClientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FishStockPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.depotPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddDepot = new Guna.UI2.WinForms.Guna2Button();
            this.txtdepotName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fishPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddNewFish = new Guna.UI2.WinForms.Guna2Button();
            this.txtFishName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblReportTotalAmount = new System.Windows.Forms.Label();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.lblReportTotalQty = new System.Windows.Forms.Label();
            this.reportTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.CashPage = new System.Windows.Forms.TabPage();
            this.dgvCash = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CreditPage = new System.Windows.Forms.TabPage();
            this.dvgCredit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblReportTotalCount = new System.Windows.Forms.Label();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClientCounts = new System.Windows.Forms.Label();
            this.ClientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvInventoryReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Merchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.saleSummaryControlTab = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCashSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCreditSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboMerchants = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCreditSales = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCashSales = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.depot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TabControl1.SuspendLayout();
            this.merchantPage.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.reportTabControl.SuspendLayout();
            this.CashPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.CreditPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCredit)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.saleSummaryControlTab.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashSales)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditSales)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.merchantPage);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.Controls.Add(this.tabPage5);
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage6);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(26, 32);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1224, 741);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.Navy;
            // 
            // merchantPage
            // 
            this.merchantPage.BackColor = System.Drawing.Color.Transparent;
            this.merchantPage.Controls.Add(this.lblMerchantCounts);
            this.merchantPage.Controls.Add(this.merchantPanel);
            this.merchantPage.Controls.Add(this.label2);
            this.merchantPage.Controls.Add(this.guna2Panel1);
            this.merchantPage.ForeColor = System.Drawing.Color.Transparent;
            this.merchantPage.Location = new System.Drawing.Point(184, 4);
            this.merchantPage.Name = "merchantPage";
            this.merchantPage.Padding = new System.Windows.Forms.Padding(3);
            this.merchantPage.Size = new System.Drawing.Size(1036, 733);
            this.merchantPage.TabIndex = 0;
            this.merchantPage.Text = "ကုန်သည်များ";
            // 
            // lblMerchantCounts
            // 
            this.lblMerchantCounts.AutoSize = true;
            this.lblMerchantCounts.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantCounts.ForeColor = System.Drawing.Color.Black;
            this.lblMerchantCounts.Location = new System.Drawing.Point(681, 261);
            this.lblMerchantCounts.Name = "lblMerchantCounts";
            this.lblMerchantCounts.Size = new System.Drawing.Size(201, 36);
            this.lblMerchantCounts.TabIndex = 5;
            this.lblMerchantCounts.Text = " ကုန်သည်အရေအတွက်";
            // 
            // merchantPanel
            // 
            this.merchantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.merchantPanel.AutoScroll = true;
            this.merchantPanel.Location = new System.Drawing.Point(22, 345);
            this.merchantPanel.Name = "merchantPanel";
            this.merchantPanel.Size = new System.Drawing.Size(864, 368);
            this.merchantPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ကုန်သည်များစာရင်း";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.btnAddMerchant);
            this.guna2Panel1.Controls.Add(this.txtMerchantName);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(32, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(854, 188);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnAddMerchant
            // 
            this.btnAddMerchant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMerchant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMerchant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMerchant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMerchant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMerchant.FillColor = System.Drawing.Color.Navy;
            this.btnAddMerchant.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMerchant.ForeColor = System.Drawing.Color.White;
            this.btnAddMerchant.Location = new System.Drawing.Point(594, 82);
            this.btnAddMerchant.Name = "btnAddMerchant";
            this.btnAddMerchant.Size = new System.Drawing.Size(180, 45);
            this.btnAddMerchant.TabIndex = 2;
            this.btnAddMerchant.Text = "ထည့်သွင်းသည်";
            this.btnAddMerchant.Click += new System.EventHandler(this.btnAddMerchant_Click);
            // 
            // txtMerchantName
            // 
            this.txtMerchantName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMerchantName.DefaultText = "";
            this.txtMerchantName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMerchantName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMerchantName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMerchantName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMerchantName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMerchantName.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.txtMerchantName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMerchantName.Location = new System.Drawing.Point(15, 73);
            this.txtMerchantName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMerchantName.Name = "txtMerchantName";
            this.txtMerchantName.PlaceholderText = "ကုန်သည်နာမည်ထည့်ပါ";
            this.txtMerchantName.SelectedText = "";
            this.txtMerchantName.Size = new System.Drawing.Size(356, 54);
            this.txtMerchantName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ကုန်သည်အသစ်ထည့်ရန်";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCustomerCounts);
            this.tabPage2.Controls.Add(this.customerPanel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.guna2Panel2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 733);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ဖောက်သည်များ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCustomerCounts
            // 
            this.lblCustomerCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerCounts.AutoSize = true;
            this.lblCustomerCounts.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCounts.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerCounts.Location = new System.Drawing.Point(683, 227);
            this.lblCustomerCounts.Name = "lblCustomerCounts";
            this.lblCustomerCounts.Size = new System.Drawing.Size(219, 36);
            this.lblCustomerCounts.TabIndex = 6;
            this.lblCustomerCounts.Text = "ဖောက်သည်အရေအတွက်";
            // 
            // customerPanel
            // 
            this.customerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPanel.AutoScroll = true;
            this.customerPanel.Location = new System.Drawing.Point(26, 308);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(854, 390);
            this.customerPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "ဖောက်သည်များစာရင်း";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.btnAddCustomers);
            this.guna2Panel2.Controls.Add(this.txtClientName);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(26, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(854, 188);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomers.FillColor = System.Drawing.Color.Navy;
            this.btnAddCustomers.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomers.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomers.Location = new System.Drawing.Point(594, 82);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(180, 45);
            this.btnAddCustomers.TabIndex = 2;
            this.btnAddCustomers.Text = "ထည့်သွင်းသည်";
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientName.DefaultText = "";
            this.txtClientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientName.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.txtClientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientName.Location = new System.Drawing.Point(15, 73);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PlaceholderText = "ဖောက်သည်နာမည်ထည့်ပါ";
            this.txtClientName.SelectedText = "";
            this.txtClientName.Size = new System.Drawing.Size(356, 54);
            this.txtClientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "ဖောက်သည်အသစ်ထည့်ရန်";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FishStockPanel);
            this.tabPage3.Controls.Add(this.depotPanel);
            this.tabPage3.Controls.Add(this.guna2Panel3);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1036, 733);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ဒိုင်";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FishStockPanel
            // 
            this.FishStockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FishStockPanel.AutoScroll = true;
            this.FishStockPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FishStockPanel.Location = new System.Drawing.Point(377, 285);
            this.FishStockPanel.Name = "FishStockPanel";
            this.FishStockPanel.Size = new System.Drawing.Size(481, 406);
            this.FishStockPanel.TabIndex = 6;
            this.FishStockPanel.WrapContents = false;
            // 
            // depotPanel
            // 
            this.depotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depotPanel.AutoScroll = true;
            this.depotPanel.Location = new System.Drawing.Point(21, 285);
            this.depotPanel.Name = "depotPanel";
            this.depotPanel.Size = new System.Drawing.Size(325, 414);
            this.depotPanel.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.btnAddDepot);
            this.guna2Panel3.Controls.Add(this.txtdepotName);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Location = new System.Drawing.Point(21, 17);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(827, 188);
            this.guna2Panel3.TabIndex = 1;
            // 
            // btnAddDepot
            // 
            this.btnAddDepot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDepot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDepot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDepot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDepot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDepot.FillColor = System.Drawing.Color.Navy;
            this.btnAddDepot.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepot.ForeColor = System.Drawing.Color.White;
            this.btnAddDepot.Location = new System.Drawing.Point(567, 82);
            this.btnAddDepot.Name = "btnAddDepot";
            this.btnAddDepot.Size = new System.Drawing.Size(180, 45);
            this.btnAddDepot.TabIndex = 2;
            this.btnAddDepot.Text = "ထည့်သွင်းသည်";
            this.btnAddDepot.Click += new System.EventHandler(this.btnAddDepot_Click);
            // 
            // txtdepotName
            // 
            this.txtdepotName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdepotName.DefaultText = "";
            this.txtdepotName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdepotName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdepotName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdepotName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdepotName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepotName.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.txtdepotName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdepotName.Location = new System.Drawing.Point(15, 73);
            this.txtdepotName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdepotName.Name = "txtdepotName";
            this.txtdepotName.PlaceholderText = "ဒိုင်နာမည်ထည့်ပါ";
            this.txtdepotName.SelectedText = "";
            this.txtdepotName.Size = new System.Drawing.Size(356, 54);
            this.txtdepotName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "ဒိုင်အသစ်ထည့်ရန်";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fishPanel);
            this.tabPage4.Controls.Add(this.guna2Panel4);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1036, 733);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ငါးအမျိုးစား";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fishPanel
            // 
            this.fishPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fishPanel.AutoScroll = true;
            this.fishPanel.Location = new System.Drawing.Point(20, 258);
            this.fishPanel.Name = "fishPanel";
            this.fishPanel.Size = new System.Drawing.Size(837, 368);
            this.fishPanel.TabIndex = 6;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.Controls.Add(this.btnAddNewFish);
            this.guna2Panel4.Controls.Add(this.txtFishName);
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Location = new System.Drawing.Point(20, 18);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(827, 188);
            this.guna2Panel4.TabIndex = 2;
            // 
            // btnAddNewFish
            // 
            this.btnAddNewFish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewFish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewFish.FillColor = System.Drawing.Color.Navy;
            this.btnAddNewFish.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFish.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFish.Location = new System.Drawing.Point(567, 82);
            this.btnAddNewFish.Name = "btnAddNewFish";
            this.btnAddNewFish.Size = new System.Drawing.Size(180, 45);
            this.btnAddNewFish.TabIndex = 2;
            this.btnAddNewFish.Text = "ထည့်သွင်းသည်";
            this.btnAddNewFish.Click += new System.EventHandler(this.btnAddNewFish_Click);
            // 
            // txtFishName
            // 
            this.txtFishName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFishName.DefaultText = "";
            this.txtFishName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFishName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFishName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFishName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFishName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFishName.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.txtFishName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFishName.Location = new System.Drawing.Point(15, 73);
            this.txtFishName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFishName.Name = "txtFishName";
            this.txtFishName.PlaceholderText = "ငါးနာမည်ထည့်ပါ";
            this.txtFishName.SelectedText = "";
            this.txtFishName.Size = new System.Drawing.Size(356, 54);
            this.txtFishName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "ငါးအမျိုးစား အသစ်ထည့်ရန်";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblReportTotalAmount);
            this.tabPage5.Controls.Add(this.lblSelectedCustomer);
            this.tabPage5.Controls.Add(this.lblReportTotalQty);
            this.tabPage5.Controls.Add(this.reportTabControl);
            this.tabPage5.Controls.Add(this.lblReportTotalCount);
            this.tabPage5.Controls.Add(this.headerPanel);
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1036, 733);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "စာရင်းများ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblReportTotalAmount
            // 
            this.lblReportTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTotalAmount.AutoSize = true;
            this.lblReportTotalAmount.Location = new System.Drawing.Point(21, 315);
            this.lblReportTotalAmount.Name = "lblReportTotalAmount";
            this.lblReportTotalAmount.Size = new System.Drawing.Size(141, 30);
            this.lblReportTotalAmount.TabIndex = 6;
            this.lblReportTotalAmount.Text = "ဖောက်သည်စာရင်း";
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.Location = new System.Drawing.Point(21, 255);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(141, 30);
            this.lblSelectedCustomer.TabIndex = 3;
            this.lblSelectedCustomer.Text = "ဖောက်သည်စာရင်း";
            // 
            // lblReportTotalQty
            // 
            this.lblReportTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTotalQty.AutoSize = true;
            this.lblReportTotalQty.Location = new System.Drawing.Point(657, 255);
            this.lblReportTotalQty.Name = "lblReportTotalQty";
            this.lblReportTotalQty.Size = new System.Drawing.Size(141, 30);
            this.lblReportTotalQty.TabIndex = 5;
            this.lblReportTotalQty.Text = "ဖောက်သည်စာရင်း";
            // 
            // reportTabControl
            // 
            this.reportTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTabControl.Controls.Add(this.CashPage);
            this.reportTabControl.Controls.Add(this.CreditPage);
            this.reportTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.reportTabControl.Location = new System.Drawing.Point(22, 390);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.Size = new System.Drawing.Size(958, 337);
            this.reportTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.reportTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.reportTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.reportTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.reportTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.reportTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.reportTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.reportTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.reportTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.reportTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.reportTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.reportTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.reportTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.reportTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.reportTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.reportTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.reportTabControl.TabIndex = 1;
            this.reportTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.reportTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.reportTabControl.SelectedIndexChanged += new System.EventHandler(this.reportTabControl_SelectedIndexChanged_1);
            // 
            // CashPage
            // 
            this.CashPage.Controls.Add(this.dgvCash);
            this.CashPage.Location = new System.Drawing.Point(4, 44);
            this.CashPage.Name = "CashPage";
            this.CashPage.Padding = new System.Windows.Forms.Padding(3);
            this.CashPage.Size = new System.Drawing.Size(950, 289);
            this.CashPage.TabIndex = 0;
            this.CashPage.Text = "လက်ငင်း";
            this.CashPage.UseVisualStyleBackColor = true;
            // 
            // dgvCash
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvCash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCash.ColumnHeadersHeight = 32;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depot,
            this.fish,
            this.quantity,
            this.price,
            this.amount,
            this.date});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCash.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCash.Location = new System.Drawing.Point(18, 29);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.RowHeadersVisible = false;
            this.dgvCash.RowHeadersWidth = 51;
            this.dgvCash.RowTemplate.Height = 24;
            this.dgvCash.Size = new System.Drawing.Size(902, 221);
            this.dgvCash.TabIndex = 0;
            this.dgvCash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCash.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCash.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvCash.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCash.ThemeStyle.RowsStyle.Height = 24;
            // 
            // CreditPage
            // 
            this.CreditPage.Controls.Add(this.dvgCredit);
            this.CreditPage.Location = new System.Drawing.Point(4, 44);
            this.CreditPage.Name = "CreditPage";
            this.CreditPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreditPage.Size = new System.Drawing.Size(950, 289);
            this.CreditPage.TabIndex = 1;
            this.CreditPage.Text = "အကြွေး";
            this.CreditPage.UseVisualStyleBackColor = true;
            // 
            // dvgCredit
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dvgCredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dvgCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dvgCredit.ColumnHeadersHeight = 32;
            this.dvgCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCredit.DefaultCellStyle = dataGridViewCellStyle21;
            this.dvgCredit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgCredit.Location = new System.Drawing.Point(24, 34);
            this.dvgCredit.Name = "dvgCredit";
            this.dvgCredit.RowHeadersVisible = false;
            this.dvgCredit.RowHeadersWidth = 51;
            this.dvgCredit.RowTemplate.Height = 24;
            this.dvgCredit.Size = new System.Drawing.Size(902, 233);
            this.dvgCredit.TabIndex = 1;
            this.dvgCredit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCredit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgCredit.ThemeStyle.HeaderStyle.Height = 32;
            this.dvgCredit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgCredit.ThemeStyle.RowsStyle.Height = 24;
            // 
            // lblReportTotalCount
            // 
            this.lblReportTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTotalCount.AutoSize = true;
            this.lblReportTotalCount.Location = new System.Drawing.Point(343, 255);
            this.lblReportTotalCount.Name = "lblReportTotalCount";
            this.lblReportTotalCount.Size = new System.Drawing.Size(141, 30);
            this.lblReportTotalCount.TabIndex = 4;
            this.lblReportTotalCount.Text = "ဖောက်သည်စာရင်း";
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.Controls.Add(this.lblClientCounts);
            this.headerPanel.Controls.Add(this.ClientPanel);
            this.headerPanel.Controls.Add(this.label7);
            this.headerPanel.Location = new System.Drawing.Point(22, 29);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(958, 205);
            this.headerPanel.TabIndex = 0;
            // 
            // lblClientCounts
            // 
            this.lblClientCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientCounts.AutoSize = true;
            this.lblClientCounts.Location = new System.Drawing.Point(753, 19);
            this.lblClientCounts.Name = "lblClientCounts";
            this.lblClientCounts.Size = new System.Drawing.Size(141, 30);
            this.lblClientCounts.TabIndex = 2;
            this.lblClientCounts.Text = "ဖောက်သည်စာရင်း";
            // 
            // ClientPanel
            // 
            this.ClientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientPanel.AutoScroll = true;
            this.ClientPanel.Location = new System.Drawing.Point(22, 71);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(916, 112);
            this.ClientPanel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "ဖောက်သည်စာရင်း";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainPanel);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1036, 733);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "သွင်းကုန်စာရင်းများ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.btnSearch);
            this.mainPanel.Controls.Add(this.dtpEndDate);
            this.mainPanel.Controls.Add(this.dtpStartDate);
            this.mainPanel.Controls.Add(this.dgvInventoryReport);
            this.mainPanel.Controls.Add(this.lblDescription);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Location = new System.Drawing.Point(18, 21);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1002, 685);
            this.mainPanel.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(3, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 36);
            this.label10.TabIndex = 7;
            this.label10.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(380, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "To";
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(774, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "ရှာဖွေသည်";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.Gray;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(476, 172);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(282, 36);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.Value = new System.DateTime(2026, 9, 9, 20, 54, 31, 131);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.Gray;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(77, 172);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(282, 36);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.Value = new System.DateTime(2026, 9, 9, 20, 54, 31, 131);
            // 
            // dgvInventoryReport
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvInventoryReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvInventoryReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvInventoryReport.ColumnHeadersHeight = 50;
            this.dgvInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInventoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Merchant,
            this.fishType,
            this.fishPrice,
            this.Weight,
            this.TotalValue});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryReport.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvInventoryReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInventoryReport.Location = new System.Drawing.Point(25, 260);
            this.dgvInventoryReport.Name = "dgvInventoryReport";
            this.dgvInventoryReport.RowHeadersVisible = false;
            this.dgvInventoryReport.RowHeadersWidth = 51;
            this.dgvInventoryReport.RowTemplate.Height = 24;
            this.dgvInventoryReport.Size = new System.Drawing.Size(929, 355);
            this.dgvInventoryReport.TabIndex = 2;
            this.dgvInventoryReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventoryReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvInventoryReport.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvInventoryReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvInventoryReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvInventoryReport.ThemeStyle.RowsStyle.Height = 24;
            // 
            // Merchant
            // 
            this.Merchant.HeaderText = "ကုန်သည်အမည်";
            this.Merchant.MinimumWidth = 6;
            this.Merchant.Name = "Merchant";
            // 
            // fishType
            // 
            this.fishType.HeaderText = "ငါးအမျိုးစား";
            this.fishType.MinimumWidth = 6;
            this.fishType.Name = "fishType";
            // 
            // fishPrice
            // 
            this.fishPrice.HeaderText = "ဈေးနှုန်း";
            this.fishPrice.MinimumWidth = 6;
            this.fishPrice.Name = "fishPrice";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "အရေအတွက်";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "စုစုပေါင်းတန်ဖိုး";
            this.TotalValue.MinimumWidth = 6;
            this.TotalValue.Name = "TotalValue";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescription.Location = new System.Drawing.Point(33, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 36);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(30, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(441, 50);
            this.label8.TabIndex = 0;
            this.label8.Text = "ကုန်သည်များ၏ သွင်းကုန်များ စာရင်း";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.saleSummaryControlTab);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.comboMerchants);
            this.tabPage6.Controls.Add(this.tableLayoutPanel1);
            this.tabPage6.Location = new System.Drawing.Point(184, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1036, 733);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "အရောင်းစာရင်း";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // saleSummaryControlTab
            // 
            this.saleSummaryControlTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saleSummaryControlTab.Controls.Add(this.tabPage7);
            this.saleSummaryControlTab.Controls.Add(this.tabPage8);
            this.saleSummaryControlTab.ItemSize = new System.Drawing.Size(180, 40);
            this.saleSummaryControlTab.Location = new System.Drawing.Point(17, 279);
            this.saleSummaryControlTab.Name = "saleSummaryControlTab";
            this.saleSummaryControlTab.SelectedIndex = 0;
            this.saleSummaryControlTab.Size = new System.Drawing.Size(994, 425);
            this.saleSummaryControlTab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.saleSummaryControlTab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.saleSummaryControlTab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.saleSummaryControlTab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.saleSummaryControlTab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.saleSummaryControlTab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.saleSummaryControlTab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.saleSummaryControlTab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.saleSummaryControlTab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.saleSummaryControlTab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.saleSummaryControlTab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.saleSummaryControlTab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.saleSummaryControlTab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.saleSummaryControlTab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.saleSummaryControlTab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.saleSummaryControlTab.TabButtonSize = new System.Drawing.Size(180, 40);
            this.saleSummaryControlTab.TabIndex = 3;
            this.saleSummaryControlTab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.saleSummaryControlTab.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.guna2Panel7);
            this.tabPage7.Location = new System.Drawing.Point(4, 44);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(986, 377);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "လက်ငင်းစာရင်း";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.BorderRadius = 15;
            this.guna2Panel7.Controls.Add(this.dgvCashSales);
            this.guna2Panel7.Controls.Add(this.label14);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(9, 24);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(958, 347);
            this.guna2Panel7.TabIndex = 0;
            // 
            // dgvCashSales
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgvCashSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvCashSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvCashSales.ColumnHeadersHeight = 32;
            this.dgvCashSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCashSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashSales.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvCashSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCashSales.Location = new System.Drawing.Point(21, 75);
            this.dgvCashSales.Name = "dgvCashSales";
            this.dgvCashSales.RowHeadersVisible = false;
            this.dgvCashSales.RowHeadersWidth = 51;
            this.dgvCashSales.RowTemplate.Height = 24;
            this.dgvCashSales.Size = new System.Drawing.Size(918, 252);
            this.dgvCashSales.TabIndex = 6;
            this.dgvCashSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCashSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCashSales.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvCashSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCashSales.ThemeStyle.RowsStyle.Height = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ဝယ်သူအမည်";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ငါးအမျိုးစား";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ဈေးနှုန်း";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "အရေအတွက်";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "စုစုပေါင်း တန်ဖိုး";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 36);
            this.label14.TabIndex = 5;
            this.label14.Text = "လက်ငင်းရောင်းအား";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.guna2Panel8);
            this.tabPage8.Location = new System.Drawing.Point(4, 44);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(986, 377);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "အကြွေးစာရင်း";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel8.BorderRadius = 15;
            this.guna2Panel8.Controls.Add(this.dgvCreditSales);
            this.guna2Panel8.Controls.Add(this.label16);
            this.guna2Panel8.FillColor = System.Drawing.Color.White;
            this.guna2Panel8.Location = new System.Drawing.Point(14, 15);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(958, 347);
            this.guna2Panel8.TabIndex = 1;
            // 
            // dgvCreditSales
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvCreditSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvCreditSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvCreditSales.ColumnHeadersHeight = 32;
            this.dgvCreditSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCreditSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditSales.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvCreditSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCreditSales.Location = new System.Drawing.Point(21, 75);
            this.dgvCreditSales.Name = "dgvCreditSales";
            this.dgvCreditSales.RowHeadersVisible = false;
            this.dgvCreditSales.RowHeadersWidth = 51;
            this.dgvCreditSales.RowTemplate.Height = 24;
            this.dgvCreditSales.Size = new System.Drawing.Size(918, 252);
            this.dgvCreditSales.TabIndex = 6;
            this.dgvCreditSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCreditSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCreditSales.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvCreditSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCreditSales.ThemeStyle.RowsStyle.Height = 24;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ဝယ်သူအမည်";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "ငါးအမျိုးစား";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "ဈေးနှုန်း";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "အရေအတွက်";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "စုစုပေါင်း တန်ဖိုး";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 36);
            this.label16.TabIndex = 5;
            this.label16.Text = "အကြွေးရောင်းအား";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "ကုန်သည်နာမည်";
            // 
            // comboMerchants
            // 
            this.comboMerchants.BackColor = System.Drawing.Color.Transparent;
            this.comboMerchants.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMerchants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMerchants.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMerchants.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMerchants.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboMerchants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboMerchants.ItemHeight = 30;
            this.comboMerchants.Location = new System.Drawing.Point(209, 38);
            this.comboMerchants.Name = "comboMerchants";
            this.comboMerchants.Size = new System.Drawing.Size(140, 36);
            this.comboMerchants.TabIndex = 1;
            this.comboMerchants.SelectedIndexChanged += new System.EventHandler(this.comboMerchants_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.lblTotalCreditSales);
            this.guna2Panel6.Controls.Add(this.label13);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel6.Location = new System.Drawing.Point(502, 13);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(469, 126);
            this.guna2Panel6.TabIndex = 1;
            // 
            // lblTotalCreditSales
            // 
            this.lblTotalCreditSales.AutoSize = true;
            this.lblTotalCreditSales.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCreditSales.Location = new System.Drawing.Point(32, 61);
            this.lblTotalCreditSales.Name = "lblTotalCreditSales";
            this.lblTotalCreditSales.Size = new System.Drawing.Size(167, 36);
            this.lblTotalCreditSales.TabIndex = 5;
            this.lblTotalCreditSales.Text = "အကြွေးရောင်းရငွေ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 36);
            this.label13.TabIndex = 4;
            this.label13.Text = "အကြွေးရောင်းရငွေ";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.Controls.Add(this.lblTotalCashSales);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel5.Location = new System.Drawing.Point(13, 13);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(469, 126);
            this.guna2Panel5.TabIndex = 0;
            // 
            // lblTotalCashSales
            // 
            this.lblTotalCashSales.AutoSize = true;
            this.lblTotalCashSales.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCashSales.Location = new System.Drawing.Point(15, 61);
            this.lblTotalCashSales.Name = "lblTotalCashSales";
            this.lblTotalCashSales.Size = new System.Drawing.Size(176, 36);
            this.lblTotalCashSales.TabIndex = 4;
            this.lblTotalCashSales.Text = "လက်ငင်းရောင်းရငွေ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 36);
            this.label12.TabIndex = 3;
            this.label12.Text = "လက်ငင်းရောင်းရငွေ";
            // 
            // depot
            // 
            this.depot.HeaderText = "ကုန်သည်အမည်";
            this.depot.MinimumWidth = 6;
            this.depot.Name = "depot";
            // 
            // fish
            // 
            this.fish.HeaderText = "ငါးအမျိုးစား";
            this.fish.MinimumWidth = 6;
            this.fish.Name = "fish";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "အရေတွက်";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "ဈေးနှုန်း";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "ကျသင့်ငွေ";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // date
            // 
            this.date.HeaderText = "နေ့စွဲ";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ကုန်သည်အမည်";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ငါးအမျိုးစား";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "အရေတွက်";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ဈေးနှုန်း";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ကျသင့်ငွေ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "နေ့စွဲ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 808);
            this.Controls.Add(this.guna2TabControl1);
            this.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🐟 ငါးပုဇွန်စနစ် - FishFlow";
            this.guna2TabControl1.ResumeLayout(false);
            this.merchantPage.ResumeLayout(false);
            this.merchantPage.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.reportTabControl.ResumeLayout(false);
            this.CashPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.CreditPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCredit)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryReport)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.saleSummaryControlTab.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashSales)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditSales)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage merchantPage;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnAddMerchant;
        private Guna.UI2.WinForms.Guna2TextBox txtMerchantName;
        private Label label1;
        private FlowLayoutPanel merchantPanel;
        private Label lblMerchantCounts;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomers;
        private Guna.UI2.WinForms.Guna2TextBox txtClientName;
        private Label label3;
        private FlowLayoutPanel customerPanel;
        private Label label4;
        private Label lblCustomerCounts;
        private FlowLayoutPanel depotPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnAddDepot;
        private Guna.UI2.WinForms.Guna2TextBox txtdepotName;
        private Label label5;
        private FlowLayoutPanel fishPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnAddNewFish;
        private Guna.UI2.WinForms.Guna2TextBox txtFishName;
        private Label label6;
        private FlowLayoutPanel FishStockPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Label label7;
        private FlowLayoutPanel ClientPanel;
        private Guna.UI2.WinForms.Guna2TabControl reportTabControl;
        private TabPage CashPage;
        private TabPage CreditPage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCash;
        private Label lblClientCounts;
        private Guna.UI2.WinForms.Guna2DataGridView dvgCredit;
        private Label lblSelectedCustomer;
        private Label lblReportTotalAmount;
        private Label lblReportTotalQty;
        private Label lblReportTotalCount;
        private TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventoryReport;
        private Label lblDescription;
        private Label label8;
        private DataGridViewTextBoxColumn Merchant;
        private DataGridViewTextBoxColumn fishType;
        private DataGridViewTextBoxColumn fishPrice;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn TotalValue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Label label10;
        private Label label9;
        private TabPage tabPage6;
        private Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox comboMerchants;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Label lblTotalCreditSales;
        private Label label13;
        private Label lblTotalCashSales;
        private Label label12;
        private Guna.UI2.WinForms.Guna2TabControl saleSummaryControlTab;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCashSales;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label14;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCreditSales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private Label label16;
        private DataGridViewTextBoxColumn depot;
        private DataGridViewTextBoxColumn fish;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

