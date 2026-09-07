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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
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
            this.FishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1097, 234);
            this.mainPanel.TabIndex = 0;
            // 
            // btnAddPurchases
            // 
            this.btnAddPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPurchases.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurchases.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPurchases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPurchases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPurchases.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAddPurchases.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchases.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchases.Location = new System.Drawing.Point(896, 165);
            this.btnAddPurchases.Name = "btnAddPurchases";
            this.btnAddPurchases.Size = new System.Drawing.Size(180, 45);
            this.btnAddPurchases.TabIndex = 12;
            this.btnAddPurchases.Text = "စာရင်းသွင်းသည်";
            this.btnAddPurchases.Click += new System.EventHandler(this.btnAddPurchases_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(864, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "ဈေးနှုန်း";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuyPrice.DefaultText = "";
            this.txtBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuyPrice.Location = new System.Drawing.Point(847, 91);
            this.txtBuyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.PlaceholderText = "";
            this.txtBuyPrice.SelectedText = "";
            this.txtBuyPrice.Size = new System.Drawing.Size(229, 48);
            this.txtBuyPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "အလေးချိန်";
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
            this.txtQuantity.Location = new System.Drawing.Point(581, 91);
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
            this.cmbSpecies.Location = new System.Drawing.Point(264, 91);
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
            this.cmbDepot.Location = new System.Drawing.Point(16, 91);
            this.cmbDepot.Name = "cmbDepot";
            this.cmbDepot.Size = new System.Drawing.Size(194, 36);
            this.cmbDepot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "ငါးအမျိုးစားများ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ဒိုင်";
            // 
            // purchaseDetailsView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.purchaseDetailsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.purchaseDetailsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.purchaseDetailsView.ColumnHeadersHeight = 51;
            this.purchaseDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchaseDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FishType,
            this.BuyPrice,
            this.Quantity,
            this.TotalAmount,
            this.purchaseDate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseDetailsView.DefaultCellStyle = dataGridViewCellStyle8;
            this.purchaseDetailsView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseDetailsView.Location = new System.Drawing.Point(20, 280);
            this.purchaseDetailsView.Name = "purchaseDetailsView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.purchaseDetailsView.RowHeadersVisible = false;
            this.purchaseDetailsView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.purchaseDetailsView.RowTemplate.Height = 30;
            this.purchaseDetailsView.Size = new System.Drawing.Size(1089, 279);
            this.purchaseDetailsView.TabIndex = 1;
            this.purchaseDetailsView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseDetailsView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.ThemeStyle.HeaderStyle.Height = 51;
            this.purchaseDetailsView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailsView.ThemeStyle.RowsStyle.Height = 30;
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
            this.purchaseDate.HeaderText = "နေ့စွဲ";
            this.purchaseDate.MinimumWidth = 6;
            this.purchaseDate.Name = "purchaseDate";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(27, 165);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(61, 32);
            this.lblTotalQuantity.TabIndex = 13;
            this.lblTotalQuantity.Text = "label2";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalAmount.Location = new System.Drawing.Point(593, 178);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(61, 32);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.Text = "label2";
            // 
            // DepotPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 634);
            this.Controls.Add(this.purchaseDetailsView);
            this.Controls.Add(this.mainPanel);
            this.Name = "DepotPurchaseForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDate;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}