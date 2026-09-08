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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.reportTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.CashPage = new System.Windows.Forms.TabPage();
            this.dgvCash = new Guna.UI2.WinForms.Guna2DataGridView();
            this.depot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditPage = new System.Windows.Forms.TabPage();
            this.dvgCredit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliPage = new System.Windows.Forms.TabPage();
            this.dvgDeli = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClientCounts = new System.Windows.Forms.Label();
            this.ClientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReportTotalCount = new System.Windows.Forms.Label();
            this.lblReportTotalQty = new System.Windows.Forms.Label();
            this.lblReportTotalAmount = new System.Windows.Forms.Label();
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
            this.DeliPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeli)).BeginInit();
            this.headerPanel.SuspendLayout();
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
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(26, 32);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1197, 709);
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
            this.merchantPage.Size = new System.Drawing.Size(1009, 701);
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
            this.merchantPanel.Size = new System.Drawing.Size(837, 336);
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
            this.guna2Panel1.Size = new System.Drawing.Size(827, 188);
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
            this.btnAddMerchant.Location = new System.Drawing.Point(567, 82);
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
            this.tabPage2.Size = new System.Drawing.Size(1009, 701);
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
            this.lblCustomerCounts.Location = new System.Drawing.Point(656, 227);
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
            this.customerPanel.Size = new System.Drawing.Size(827, 358);
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
            this.guna2Panel2.Size = new System.Drawing.Size(827, 188);
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
            this.btnAddCustomers.Location = new System.Drawing.Point(567, 82);
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
            this.tabPage3.Size = new System.Drawing.Size(1009, 701);
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
            this.FishStockPanel.Size = new System.Drawing.Size(481, 374);
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
            this.depotPanel.Size = new System.Drawing.Size(325, 382);
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
            this.tabPage4.Size = new System.Drawing.Size(1009, 701);
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
            this.fishPanel.Size = new System.Drawing.Size(837, 336);
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
            this.tabPage5.Size = new System.Drawing.Size(1009, 701);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "စာရင်းများ";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // reportTabControl
            // 
            this.reportTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTabControl.Controls.Add(this.CashPage);
            this.reportTabControl.Controls.Add(this.CreditPage);
            this.reportTabControl.Controls.Add(this.DeliPage);
            this.reportTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.reportTabControl.Location = new System.Drawing.Point(22, 390);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.Size = new System.Drawing.Size(958, 305);
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
            this.CashPage.Size = new System.Drawing.Size(950, 331);
            this.CashPage.TabIndex = 0;
            this.CashPage.Text = "လက်ငင်း";
            this.CashPage.UseVisualStyleBackColor = true;
            // 
            // dgvCash
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvCash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCash.ColumnHeadersHeight = 32;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depot,
            this.fish,
            this.quantity,
            this.price,
            this.amount,
            this.date});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCash.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCash.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCash.Location = new System.Drawing.Point(18, 29);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.RowHeadersVisible = false;
            this.dgvCash.RowHeadersWidth = 51;
            this.dgvCash.RowTemplate.Height = 24;
            this.dgvCash.Size = new System.Drawing.Size(902, 263);
            this.dgvCash.TabIndex = 0;
            this.dgvCash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCash.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCash.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvCash.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dgvCash.ThemeStyle.RowsStyle.Height = 24;
            // 
            // depot
            // 
            this.depot.HeaderText = "ဒိုင်အမည်";
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
            // CreditPage
            // 
            this.CreditPage.Controls.Add(this.dvgCredit);
            this.CreditPage.Location = new System.Drawing.Point(4, 44);
            this.CreditPage.Name = "CreditPage";
            this.CreditPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreditPage.Size = new System.Drawing.Size(950, 257);
            this.CreditPage.TabIndex = 1;
            this.CreditPage.Text = "အကြွေး";
            this.CreditPage.UseVisualStyleBackColor = true;
            // 
            // dvgCredit
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dvgCredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dvgCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dvgCredit.ColumnHeadersHeight = 32;
            this.dvgCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCredit.DefaultCellStyle = dataGridViewCellStyle15;
            this.dvgCredit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgCredit.Location = new System.Drawing.Point(24, 34);
            this.dvgCredit.Name = "dvgCredit";
            this.dvgCredit.RowHeadersVisible = false;
            this.dvgCredit.RowHeadersWidth = 51;
            this.dvgCredit.RowTemplate.Height = 24;
            this.dvgCredit.Size = new System.Drawing.Size(902, 201);
            this.dvgCredit.TabIndex = 1;
            this.dvgCredit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCredit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgCredit.ThemeStyle.HeaderStyle.Height = 32;
            this.dvgCredit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgCredit.ThemeStyle.RowsStyle.Height = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ဒိုင်အမည်";
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
            // DeliPage
            // 
            this.DeliPage.Controls.Add(this.dvgDeli);
            this.DeliPage.Location = new System.Drawing.Point(4, 44);
            this.DeliPage.Name = "DeliPage";
            this.DeliPage.Size = new System.Drawing.Size(950, 331);
            this.DeliPage.TabIndex = 2;
            this.DeliPage.Text = "နယ်ပို့";
            this.DeliPage.UseVisualStyleBackColor = true;
            // 
            // dvgDeli
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dvgDeli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dvgDeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dvgDeli.ColumnHeadersHeight = 32;
            this.dvgDeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgDeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Myanmar Text", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDeli.DefaultCellStyle = dataGridViewCellStyle18;
            this.dvgDeli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgDeli.Location = new System.Drawing.Point(24, 34);
            this.dvgDeli.Name = "dvgDeli";
            this.dvgDeli.RowHeadersVisible = false;
            this.dvgDeli.RowHeadersWidth = 51;
            this.dvgDeli.RowTemplate.Height = 24;
            this.dvgDeli.Size = new System.Drawing.Size(902, 263);
            this.dvgDeli.TabIndex = 1;
            this.dvgDeli.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgDeli.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgDeli.ThemeStyle.HeaderStyle.Height = 32;
            this.dvgDeli.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.dvgDeli.ThemeStyle.RowsStyle.Height = 24;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ဒိုင်အမည်";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ငါးအမျိုးစား";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "အရေတွက်";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "ဈေးနှုန်း";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "ကျသင့်ငွေ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "နေ့စွဲ";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 776);
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
            this.DeliPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeli)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
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
        private TabPage DeliPage;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCash;
        private DataGridViewTextBoxColumn depot;
        private DataGridViewTextBoxColumn fish;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private Label lblClientCounts;
        private Guna.UI2.WinForms.Guna2DataGridView dvgCredit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Guna.UI2.WinForms.Guna2DataGridView dvgDeli;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label lblSelectedCustomer;
        private Label lblReportTotalAmount;
        private Label lblReportTotalQty;
        private Label lblReportTotalCount;
    }
}

