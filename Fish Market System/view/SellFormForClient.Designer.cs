namespace Fish_Market_System.view
{
    partial class SellFormForClient
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
            this.lblFishType = new System.Windows.Forms.Label();
            this.lblRemaingWeight = new System.Windows.Forms.Label();
            this.btnBackWard = new Guna.UI2.WinForms.Guna2Button();
            this.SellPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buyStatusCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.fishTypeCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clientNameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSellItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.SellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.guna2DataGridView2);
            this.mainPanel.Controls.Add(this.lblFishType);
            this.mainPanel.Controls.Add(this.lblRemaingWeight);
            this.mainPanel.Controls.Add(this.btnBackWard);
            this.mainPanel.Controls.Add(this.SellPanel);
            this.mainPanel.Controls.Add(this.clientNameLayout);
            this.mainPanel.Location = new System.Drawing.Point(15, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1224, 651);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lblFishType
            // 
            this.lblFishType.AutoSize = true;
            this.lblFishType.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFishType.Location = new System.Drawing.Point(610, 17);
            this.lblFishType.Name = "lblFishType";
            this.lblFishType.Size = new System.Drawing.Size(112, 36);
            this.lblFishType.TabIndex = 11;
            this.lblFishType.Text = "ငါးအမျိုးစား";
            // 
            // lblRemaingWeight
            // 
            this.lblRemaingWeight.AutoSize = true;
            this.lblRemaingWeight.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaingWeight.Location = new System.Drawing.Point(955, 17);
            this.lblRemaingWeight.Name = "lblRemaingWeight";
            this.lblRemaingWeight.Size = new System.Drawing.Size(170, 36);
            this.lblRemaingWeight.TabIndex = 10;
            this.lblRemaingWeight.Text = "ကျန်ရှိသော ကုန်ချိန်";
            // 
            // btnBackWard
            // 
            this.btnBackWard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackWard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackWard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackWard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackWard.FillColor = System.Drawing.Color.Red;
            this.btnBackWard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackWard.ForeColor = System.Drawing.Color.White;
            this.btnBackWard.Location = new System.Drawing.Point(29, 17);
            this.btnBackWard.Name = "btnBackWard";
            this.btnBackWard.Size = new System.Drawing.Size(180, 45);
            this.btnBackWard.TabIndex = 9;
            this.btnBackWard.Text = "‌နောက်သို့";
            this.btnBackWard.Click += new System.EventHandler(this.btnBackWard_Click);
            // 
            // SellPanel
            // 
            this.SellPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SellPanel.Controls.Add(this.btnSellItem);
            this.SellPanel.Controls.Add(this.label4);
            this.SellPanel.Controls.Add(this.buyStatusCombo);
            this.SellPanel.Controls.Add(this.label3);
            this.SellPanel.Controls.Add(this.label2);
            this.SellPanel.Controls.Add(this.label1);
            this.SellPanel.Controls.Add(this.txtWeight);
            this.SellPanel.Controls.Add(this.txtSellPrice);
            this.SellPanel.Controls.Add(this.fishTypeCombo);
            this.SellPanel.Location = new System.Drawing.Point(29, 231);
            this.SellPanel.Name = "SellPanel";
            this.SellPanel.Size = new System.Drawing.Size(1169, 124);
            this.SellPanel.TabIndex = 1;
            this.SellPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 36);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "ဝယ်ယူမှု့ပုံစံ";
            // 
            // buyStatusCombo
            // 
            this.buyStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.buyStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.buyStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buyStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buyStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buyStatusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.buyStatusCombo.ItemHeight = 30;
            this.buyStatusCombo.Items.AddRange(new object[] {
            "လက်ငင်း",
            "အကြွေး"});
            this.buyStatusCombo.Location = new System.Drawing.Point(793, 67);
            this.buyStatusCombo.Name = "buyStatusCombo";
            this.buyStatusCombo.Size = new System.Drawing.Size(140, 36);
            this.buyStatusCombo.StartIndex = 0;
            this.buyStatusCombo.TabIndex = 6;
            this.buyStatusCombo.SelectedIndexChanged += new System.EventHandler(this.buyStatusCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "အလေးချိန်";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ရောင်းဈေး";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ငါးအမျိုးစားများ";
            // 
            // txtWeight
            // 
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Location = new System.Drawing.Point(534, 55);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(229, 48);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellPrice.DefaultText = "";
            this.txtSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellPrice.Location = new System.Drawing.Point(260, 56);
            this.txtSellPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.PlaceholderText = "";
            this.txtSellPrice.SelectedText = "";
            this.txtSellPrice.Size = new System.Drawing.Size(229, 48);
            this.txtSellPrice.TabIndex = 1;
            // 
            // fishTypeCombo
            // 
            this.fishTypeCombo.BackColor = System.Drawing.Color.Transparent;
            this.fishTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fishTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fishTypeCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fishTypeCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fishTypeCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fishTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fishTypeCombo.ItemHeight = 30;
            this.fishTypeCombo.Location = new System.Drawing.Point(16, 68);
            this.fishTypeCombo.Name = "fishTypeCombo";
            this.fishTypeCombo.Size = new System.Drawing.Size(190, 36);
            this.fishTypeCombo.TabIndex = 0;
            this.fishTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fishTypeCombo_SelectedIndexChanged);
            // 
            // clientNameLayout
            // 
            this.clientNameLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNameLayout.AutoScroll = true;
            this.clientNameLayout.Location = new System.Drawing.Point(29, 95);
            this.clientNameLayout.Name = "clientNameLayout";
            this.clientNameLayout.Size = new System.Drawing.Size(1169, 117);
            this.clientNameLayout.TabIndex = 0;
            // 
            // btnSellItem
            // 
            this.btnSellItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellItem.FillColor = System.Drawing.Color.ForestGreen;
            this.btnSellItem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellItem.ForeColor = System.Drawing.Color.White;
            this.btnSellItem.Location = new System.Drawing.Point(968, 59);
            this.btnSellItem.Name = "btnSellItem";
            this.btnSellItem.Size = new System.Drawing.Size(180, 45);
            this.btnSellItem.TabIndex = 8;
            this.btnSellItem.Text = "ရောင်းသည်";
            this.btnSellItem.Click += new System.EventHandler(this.btnSellItem_Click);
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 50;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fishType,
            this.price,
            this.Weight,
            this.buyingType,
            this.totalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(29, 366);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            this.guna2DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.Size = new System.Drawing.Size(1169, 170);
            this.guna2DataGridView2.TabIndex = 12;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 50;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // fishType
            // 
            this.fishType.HeaderText = "ငါးအမျိုးစားများ";
            this.fishType.MinimumWidth = 10;
            this.fishType.Name = "fishType";
            // 
            // price
            // 
            this.price.HeaderText = "ဈေးနှုန်း";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "အလေးချိန်";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            // 
            // buyingType
            // 
            this.buyingType.HeaderText = "ဝယ်ယူမှုပုံစံ";
            this.buyingType.MinimumWidth = 6;
            this.buyingType.Name = "buyingType";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "ကျသင့်ငွေ";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            // 
            // SellFormForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 675);
            this.Controls.Add(this.mainPanel);
            this.Name = "SellFormForClient";
            this.Text = "SellFormForClient";
            this.Load += new System.EventHandler(this.SellFormForClient_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.SellPanel.ResumeLayout(false);
            this.SellPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel clientNameLayout;
        private Guna.UI2.WinForms.Guna2Panel SellPanel;
        private Guna.UI2.WinForms.Guna2Button btnBackWard;
        private Guna.UI2.WinForms.Guna2ComboBox fishTypeCombo;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox buyStatusCombo;
        private System.Windows.Forms.Label lblFishType;
        private System.Windows.Forms.Label lblRemaingWeight;
        private Guna.UI2.WinForms.Guna2Button btnSellItem;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}