using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view
{
    partial class DashboardForm
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
            this.Text = "DashboardForm";

            //this.Text = $"📊 Dashboard - {merchantName}";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterParent;

            // Title
            Label lblTitle = new Label();
            //lblTitle.Text = $"🐟 {merchantName} ရဲ့ Dashboard";
            lblTitle.Font = new Font("Myanmar Text", 18, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            // Buttons Panel
            Panel btnPanel = new Panel();
            btnPanel.Location = new Point(20, 70);
            btnPanel.Size = new Size(1160, 60);
            this.Controls.Add(btnPanel);

            Button btnAddEntry = new Button();
            btnAddEntry.Text = "📦 ဒိုင်သွင်းမည်";
            btnAddEntry.Size = new Size(150, 40);
            btnAddEntry.BackColor = Color.LightBlue;
            btnAddEntry.Click += BtnAddEntry_Click;
            btnPanel.Controls.Add(btnAddEntry);

            Button btnAddSale = new Button();
            btnAddSale.Text = "💰 ရောင်းမည်";
            btnAddSale.Location = new Point(160, 0);
            btnAddSale.Size = new Size(150, 40);
            btnAddSale.BackColor = Color.LightGreen;
            btnAddSale.Click += BtnAddSale_Click;
            btnPanel.Controls.Add(btnAddSale);

            Button btnCredit = new Button();
            btnCredit.Text = "📋 အကြွေးစာရင်း";
            btnCredit.Location = new Point(320, 0);
            btnCredit.Size = new Size(150, 40);
            btnCredit.BackColor = Color.LightYellow;
            btnCredit.Click += BtnCredit_Click;
            btnPanel.Controls.Add(btnCredit);

            Button btnRefresh = new Button();
            btnRefresh.Text = "🔄 ပြန်လည်";
            btnRefresh.Location = new Point(480, 0);
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.BackColor = Color.LightGray;
            //btnRefresh.Click += (s, e) => LoadData();
            btnPanel.Controls.Add(btnRefresh);

            // Tab Control
            TabControl tabControl = new TabControl();
            tabControl.Location = new Point(20, 140);
            tabControl.Size = new Size(1160, 500);
            this.Controls.Add(tabControl);

            // Tab 1: Daily Entries
            TabPage tabEntries = new TabPage("📦 ဒိုင်စာရင်း");
            tabControl.TabPages.Add(tabEntries);

            dgvEntries = new DataGridView();
            dgvEntries.Dock = DockStyle.Fill;
            dgvEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntries.ReadOnly = true;
            tabEntries.Controls.Add(dgvEntries);

            // Tab 2: Sales
            TabPage tabSales = new TabPage("💰 ရောင်းစာရင်း");
            tabControl.TabPages.Add(tabSales);

            dgvSales = new DataGridView();
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ReadOnly = true;
            tabSales.Controls.Add(dgvSales);

        }

        #endregion
    }
}