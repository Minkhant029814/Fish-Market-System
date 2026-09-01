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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.marchantDisplayLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addMarchantPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.txtMarchantName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddnewMarchant = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.addMarchantPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.marchantDisplayLayout);
            this.guna2Panel1.Controls.Add(this.addMarchantPanel);
            this.guna2Panel1.Controls.Add(this.btnAddnewMarchant);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 21);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(942, 478);
            this.guna2Panel1.TabIndex = 0;
            // 
            // marchantDisplayLayout
            // 
            this.marchantDisplayLayout.AutoScroll = true;
            this.marchantDisplayLayout.Location = new System.Drawing.Point(18, 267);
            this.marchantDisplayLayout.Name = "marchantDisplayLayout";
            this.marchantDisplayLayout.Size = new System.Drawing.Size(907, 194);
            this.marchantDisplayLayout.TabIndex = 3;
            // 
            // addMarchantPanel
            // 
            this.addMarchantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMarchantPanel.Controls.Add(this.btnCreate);
            this.addMarchantPanel.Controls.Add(this.txtMarchantName);
            this.addMarchantPanel.Location = new System.Drawing.Point(481, 90);
            this.addMarchantPanel.Name = "addMarchantPanel";
            this.addMarchantPanel.Size = new System.Drawing.Size(427, 134);
            this.addMarchantPanel.TabIndex = 2;
            this.addMarchantPanel.Visible = false;
            this.addMarchantPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addMarchantPanel_Paint);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(232, 84);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 37);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "ထည့်သွင်းသည်";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtMarchantName
            // 
            this.txtMarchantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarchantName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarchantName.DefaultText = "";
            this.txtMarchantName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarchantName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarchantName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarchantName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarchantName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarchantName.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtMarchantName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarchantName.Location = new System.Drawing.Point(25, 21);
            this.txtMarchantName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarchantName.Name = "txtMarchantName";
            this.txtMarchantName.PlaceholderText = "ကုန်သည်နာမည်ထည့်ရန်";
            this.txtMarchantName.SelectedText = "";
            this.txtMarchantName.Size = new System.Drawing.Size(382, 51);
            this.txtMarchantName.TabIndex = 0;
            // 
            // btnAddnewMarchant
            // 
            this.btnAddnewMarchant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnewMarchant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddnewMarchant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddnewMarchant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddnewMarchant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddnewMarchant.FillColor = System.Drawing.Color.Blue;
            this.btnAddnewMarchant.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddnewMarchant.ForeColor = System.Drawing.Color.White;
            this.btnAddnewMarchant.Location = new System.Drawing.Point(661, 24);
            this.btnAddnewMarchant.Name = "btnAddnewMarchant";
            this.btnAddnewMarchant.Size = new System.Drawing.Size(227, 45);
            this.btnAddnewMarchant.TabIndex = 1;
            this.btnAddnewMarchant.Text = "ကုန်သည်အသစ်ထည့်ရန်";
            this.btnAddnewMarchant.Click += new System.EventHandler(this.btnAddnewMarchant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fish Market System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 511);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.addMarchantPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddnewMarchant;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel addMarchantPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtMarchantName;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.FlowLayoutPanel marchantDisplayLayout;
    }
}

