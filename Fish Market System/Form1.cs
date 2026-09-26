using Fish_Market_System.service;

using Fish_Market_System.utilis;
using Fish_Market_System.view;
using Fish_Market_System.view.components;
using FishStore.Core.dto.creditPay;
using FishStore.Core.service.creditPay;
using FishStore.dto;
using FishStore.dto.dailyRepot;
using FishStore.model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fish_Market_System
{
    public partial class Form1 : Form
    {
        #region Services & Variables

        // Services
        private readonly MerchantService merchantService = new MerchantService();
        private readonly CustomerService customerService = new CustomerService();
        private readonly DepotService depotService = new DepotService();
        private readonly FishSpeciesService fishSpeciesService = new FishSpeciesService();
        private readonly DepotSaleService saleService = new DepotSaleService();
        private readonly SaleReportService reportService = new SaleReportService();
        private readonly MerchantDayReportService merchantReportService = new MerchantDayReportService();
        private readonly MerchantCreditService merchantCreditService = new MerchantCreditService();
        private readonly CreditSearchService creditSearchService = new CreditSearchService();

        // Lists
        private List<Merchant> merchants;
        private List<Depot> depots;
        private List<FishCategory> fishes;
        private List<Customer> customers;

        // Report Variables
        private int selectedCustomerIdForReport = 0;
        private int merchantIdForCreditLists = 0;
        private int currentMerchantId = 0;
        private int selectedMerchantId = 0;
        private DateTime selectedDate = DateTime.Now;
        private int fishCategoryId = 0;

        #endregion

        #region Constructor & Form Load

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ============================================
            // ၁။ DataGridView Configure
            // ============================================
            ConfigureDataGridView(dgvCash);
            ConfigureDataGridView(dvgCredit);
            //ConfigureDataGridView(dgvDeli);
            ConfigureDataGridView(dgvCashSales);
            ConfigureDataGridView(dgvCreditSales);

            // ✅ Credit Grid တွေကို Setup လုပ်ပါ
            if (dgvNormalCredit.Columns.Count == 0)
                SetupCreditGrid(dgvNormalCredit);
            if (dgvStockCredit.Columns.Count == 0)
                SetupCreditGrid(dgvStockCredit);
            if (dgvAllCredit.Columns.Count == 0)
                SetupCreditGrid(dgvAllCredit);
            // ============================================
            // ၂။ DateTimePicker Settings
            // ============================================
            dtpStartDate.MaxDate = DateTime.Now.Date;
            dtpReportDate.MaxDate = DateTime.Now.Date;
            dtpStartDate.Value = DateTime.Now.Date;
            dtpReportDate.Value = DateTime.Now.Date;

            // Event ချိတ်ဆက်ခြင်း
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            dtpReportDate.ValueChanged += dtpReportDate_ValueChanged;

            // ============================================
            // ၃။ Default Tab
            // ============================================
            reportTabControl.SelectedTab = CashPage;

            // ============================================
            // ၄။ Data Load
            // ============================================
            LoadAllData();
        }

        private void ConfigureDataGridView(DataGridView view)
        {
            // Row Height
            view.RowTemplate.Height = 40;

            // Font
            view.DefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            view.ColumnHeadersDefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
            view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Selection
            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            view.MultiSelect = false;
            view.ReadOnly = true;

            // Hide Row Headers
            view.RowHeadersVisible = false;

            // Disable Add Rows
            view.AllowUserToAddRows = false;

            // Alternating Row Color
            view.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            view.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void LoadAllData()
        {
            try
            {
                // ၁။ ကုန်သည် (Merchant Panel)
                displayAndRefreshMerchant();

                // ၂။ ဖောက်သည် (Customer)
                displayAndRefreshCustomer();

                // ၃။ ဒိုင် (Depot)
                displayAndRefreshDepot();

                // ၄။ ငါး (Fish)
                displayAndRefreshFish();

                // ၅။ DataGridView Setup
                SetupSummaryGrid();
                SetupDetailGrid();

                // ✅ Credit Grid Setup (dgv ၃ ခုလုံး)
                if (dgvNormalCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvNormalCredit);
                if (dgvStockCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvStockCredit);
                if (dgvAllCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvAllCredit);

                // ၆။ Customer List
                DisplayClientsAndTheirPurchaseList(customers);

                // ၇။ Merchant Credit List
                if (merchants != null && merchants.Count > 0)
                {
                    DisplayMerchantCreditsLists(merchants);
                }

                // ၈။ Today Report
                LoadMerchantSummary();

                // ၉။ Merchant Sales
                LoadSalesRate();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error in LoadAllData: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

        #endregion

        #region Merchant Section

        private void btnAddMerchant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMerchantName.Text))
            {
                CustomMessageBox.Show("ကုန်သည်နာမည်ကို ထည့်သွင်းပေးပါ။",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
                txtMerchantName.Focus();
                return;
            }

            Merchant m = new Merchant
            {
                MerchantName = txtMerchantName.Text.Trim()
            };

            if (merchantService.AddMerchant(m))
            {
                CustomMessageBox.Show("ကုန်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               CustomMessageBox.MessageType.Success);

                displayAndRefreshMerchant();
                txtMerchantName.Clear();
                txtMerchantName.Focus();
            }
        }

        private void displayAndRefreshMerchant()
        {
            merchantPanel.Controls.Clear();

            merchants = merchantService.GetAll();
            lblMerchantCounts.Text = $" ကုန်သည်အရေအတွက် {merchants?.Count ?? 0} ဦး";

            if (merchants == null || merchants.Count == 0) return;

            foreach (Merchant m in merchants)
            {
                Guna2Button btn = CreateStyledButton(m.MerchantName, m);

                btn.Click += (sender, e) =>
                {
                    Merchant selectedMerchant = (Merchant)((Guna2Button)sender).Tag;
                    HighlightSelectedButton(merchantPanel, (Guna2Button)sender);

                    DepotPurchaseForm form = new DepotPurchaseForm(
                        selectedMerchant.MerchantId,
                        selectedMerchant.MerchantName,
                        customerService.GetAll(),
                        depots,
                        fishes
                    );
                    form.ShowDialog();
                };

                merchantPanel.Controls.Add(btn);
            }
        }

        #endregion

        #region Customer Section

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientName.Text))
            {
                CustomMessageBox.Show("ဖောက်သည်နာမည်ကို ထည့်သွင်းပေးပါ။",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
                txtClientName.Focus();
                return;
            }

            Customer customer = new Customer
            {
                CustomerName = txtClientName.Text.Trim()
            };

            if (customerService.AddCustomer(customer))
            {
                CustomMessageBox.Show("ဖောက်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               CustomMessageBox.MessageType.Success);

                displayAndRefreshCustomer();
                DisplayClientsAndTheirPurchaseList(customers);
                txtClientName.Clear();
                txtClientName.Focus();
            }
        }

        private void displayAndRefreshCustomer()
        {
            customers = customerService.GetAll();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = txtSearchBox.Text.Trim();
                string searchName = string.IsNullOrWhiteSpace(name) ? null : name;

                customers = customerService.GetAll(searchName);
                DisplayClientsAndTheirPurchaseList(customers);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                CustomMessageBox.MessageType.Error);
            }
        }

        #endregion

        #region Depot Section

        private void btnAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdepotName.Text))
            {
                CustomMessageBox.Show(" ဒိုင်နာမည်ကိုထည့်သွင်းပေးပါ။",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
                txtdepotName.Focus();
                return;
            }

            Depot depot = new Depot
            {
                DepotName = txtdepotName.Text.Trim()
            };

            if (depotService.AddDepot(depot))
            {
                CustomMessageBox.Show("ဒိုင်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               CustomMessageBox.MessageType.Success);

                displayAndRefreshDepot();
                txtdepotName.Clear();
                txtdepotName.Focus();
            }
        }

        private void displayAndRefreshDepot()
        {
            depotPanel.Controls.Clear();
            depots = depotService.GetAll();

            if (depots == null || depots.Count == 0) return;

            foreach (Depot depot in depots)
            {
                Guna2Button btn = CreateStyledButton(depot.DepotName, depot);

                btn.Click += (sender, e) =>
                {
                    Depot selectedDepot = (Depot)((Guna2Button)sender).Tag;
                    HighlightSelectedButton(depotPanel, (Guna2Button)sender);
                    FishStockDisplay(selectedDepot.DepotId, selectedDepot.DepotName);
                };

                depotPanel.Controls.Add(btn);
            }
        }

        private void FishStockDisplay(int depotId, string depotName)
        {
            try
            {
                FishStockPanel.Controls.Clear();
                FishStockPanel.AutoScroll = true;

                if (depotId > 0)
                {
                    List<DepotFish> fishes = saleService.GetFishByDepot(depotId);

                    // ခေါင်းစဉ်
                    Label lblTitle = new Label
                    {
                        Text = $"📦 {depotName} ရှိ လက်ကျန်စာရင်း",
                        Font = new Font("Pyidaungsu", 12, FontStyle.Bold),
                        AutoSize = true,
                        Margin = new Padding(5),
                        ForeColor = Color.DarkBlue
                    };
                    FishStockPanel.Controls.Add(lblTitle);

                    if (fishes != null && fishes.Count > 0)
                    {
                        foreach (DepotFish fish in fishes)
                        {
                            Label lbl = new Label
                            {
                                Text = $"🐟 {fish.FishName,-20} → {fish.TotalQuantity,10:N2} ကီလို",
                                Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                                AutoSize = true,
                                Margin = new Padding(3),
                                ForeColor = Color.Black
                            };
                            FishStockPanel.Controls.Add(lbl);
                        }

                        // စုစုပေါင်း
                        decimal total = fishes.Sum(f => f.TotalQuantity);
                        Label lblTotal = new Label
                        {
                            Text = $"📊 စုစုပေါင်း → {total:N2} ကီလို",
                            Font = new Font("Pyidaungsu", 11, FontStyle.Bold),
                            AutoSize = true,
                            Margin = new Padding(3),
                            ForeColor = Color.Red,
                            BackColor = Color.LightYellow
                        };
                        FishStockPanel.Controls.Add(lblTotal);
                    }
                    else
                    {
                        Label lbl = new Label
                        {
                            Text = "📭 ကုန်ချိန်မရှိသေးပါ",
                            Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                            AutoSize = true,
                            Margin = new Padding(3),
                            ForeColor = Color.Gray
                        };
                        FishStockPanel.Controls.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error loading fish stock: {ex.Message}", "Error",
                               CustomMessageBox.MessageType.Error);
            }
        }

        #endregion

        #region Fish Species Section

        private void btnAddNewFish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFishName.Text))
            {
                CustomMessageBox.Show("ငါးအမျိုးအစား နာမည်ကို ထည့်သွင်းပေးပါ။",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
                txtFishName.Focus();
                return;
            }

            FishCategory fish = new FishCategory
            {
                CategoryName = txtFishName.Text.Trim()
            };

            if (fishSpeciesService.AddFish(fish))
            {
                CustomMessageBox.Show("ငါးအမျိုးအစားနာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               CustomMessageBox.MessageType.Success);

                displayAndRefreshFish();
                txtFishName.Clear();
                txtFishName.Focus();
            }
        }

        private void displayAndRefreshFish()
        {
            fishPanel.Controls.Clear();
            fishes = fishSpeciesService.GetAll();

            if (fishes == null || fishes.Count == 0) return;

            foreach (FishCategory f in fishes)
            {
                Guna2Button btn = CreateStyledButton(f.CategoryName, f);

                btn.Click += (sender, e) =>
                {
                    FishCategory selectedFish = (FishCategory)((Guna2Button)sender).Tag;
                    HighlightSelectedButton(fishPanel, (Guna2Button)sender);

                    if (pnlNewSpecies.Visible == false)
                    {
                        pnlNewSpecies.Visible = true;
                    }

                    fishCategoryId = selectedFish.CategoryId;
                };

                fishPanel.Controls.Add(btn);
            }
        }

        private void btnAddSpecies_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFishSpeciesName.Text))
                {
                    CustomMessageBox.Show("ငါးမျိုးစိတ်နာမည် ထည့်ပါ။",
                                          "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                FishSpecies fish = new FishSpecies
                {
                    CategoryId = fishCategoryId,
                    FishSpeciesName = txtFishSpeciesName.Text.Trim()
                };

                if (fishSpeciesService.AddNewSpecies(fish))
                {
                    CustomMessageBox.Show("ငါးမျိုးစိတ် ထည့်သွင်းခြင်း အောင်မြင်သည်။",
                                          "အောင်မြင်သည်",
                                          CustomMessageBox.MessageType.Success);
                    txtFishSpeciesName.Clear();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
            }
        }

        #endregion

        #region Customer List with Cash and Credit List

        private void DisplayClientsAndTheirPurchaseList(List<Customer> customers)
        {
            ClientPanel.Controls.Clear();

            lblClientCounts.Text = $" ဖောက်သည်အရေအတွက် {customers?.Count ?? 0} ဦး";

            if (customers == null || customers.Count == 0)
            {
                bool isSearching = !string.IsNullOrWhiteSpace(txtSearchBox.Text);

                Label lbl = new Label
                {
                    Text = isSearching
                        ? "🔍 ရှာဖွေမှုနှင့်ကိုက်ညီသော ဖောက်သည်မရှိပါ"
                        : "📋 ဖောက်သည် စာရင်း မရှိသေးပါ",
                    Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                    AutoSize = true,
                    Margin = new Padding(5),
                    ForeColor = isSearching
                        ? Color.FromArgb(231, 76, 60)
                        : Color.FromArgb(26, 42, 58)
                };

                ClientPanel.Controls.Add(lbl);
                return;
            }

            foreach (Customer c in customers)
            {
                Guna2Button btn = CreateStyledButton(c.CustomerName, c);

                btn.Click += (sender, e) =>
                {
                    Guna2Button clickedBtn = (Guna2Button)sender;
                    Customer selectedCustomer = (Customer)clickedBtn.Tag;
                    selectedCustomerIdForReport = selectedCustomer.CustomerId;

                    HighlightSelectedButton(ClientPanel, clickedBtn);

                    string paymentType = GetPaymentFromTab();
                    DisplaySaleReportForCustomer(selectedCustomer.CustomerId, paymentType);

                    lblSelectedCustomer.Text = $"📋 {selectedCustomer.CustomerName} ရဲ့ ဝယ်ယူမှုစာရင်း";
                };

                ClientPanel.Controls.Add(btn);
            }
        }

        private void DisplaySaleReportForCustomer(int customerId, string paymentType)
        {
            try
            {
                string dbPaymentType = GetDbPaymentType(paymentType);

                List<CustomerSaleReport> reports = reportService.GetSalesByCustomerAndPayment(customerId, dbPaymentType);
                DataGridView view = GetDataGridViewByPaymentType(paymentType);

                view.Rows.Clear();

                if (reports.Count > 0)
                {
                    foreach (CustomerSaleReport report in reports)
                    {
                        view.Rows.Add(
                            report.MerchantName ?? "",
                            report.FishName ?? "",
                            report.Quantity.ToString("N2"),
                            report.Price.ToString("#,##0.00"),
                            report.TotalAmount.ToString("#,##0.00"),
                            report.SaleDate.ToString("dd/MM/yyyy")
                        );
                    }

                    decimal totalAmount = reports.Sum(r => r.TotalAmount);
                    decimal totalQty = reports.Sum(r => r.Quantity);

                    lblReportTotalCount.Text = $"စုစုပေါင်း: {reports.Count} မှတ်တမ်း";
                    lblReportTotalQty.Text = $"စုစုပေါင်းအရေအတွက်: {totalQty:N2}";
                    lblReportTotalAmount.Text = $"စုစုပေါင်းကျသင့်ငွေ: {totalAmount:#,##0.00} ကျပ်";
                }
                else
                {
                    view.Rows.Add("ဒေတာမရှိပါ", "", "", "", "", "");
                    lblReportTotalCount.Text = "စုစုပေါင်း: 0 မှတ်တမ်း";
                    lblReportTotalQty.Text = "စုစုပေါင်းအရေအတွက်: 0";
                    lblReportTotalAmount.Text = "စုစုပေါင်းကျသင့်ငွေ: 0 ကျပ်";
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                              CustomMessageBox.MessageType.Error);
            }
        }

        #endregion

        #region Helper Methods

        private string GetDbPaymentType(string paymentType)
        {
            string type = paymentType?.ToUpper() ?? "CASH";

            switch (type)
            {
                case "CASH": return "cash";
                case "CREDIT": return "credit";
                case "DELI":
                case "DELIVERY": return "deli";
                default: return "cash";
            }
        }

        private DataGridView GetDataGridViewByPaymentType(string paymentType)
        {
            string type = paymentType?.ToUpper() ?? "CASH";

            switch (type)
            {
                case "CASH": return dgvCash;
                case "CREDIT": return dvgCredit;
                case "DELI":
                //case "DELIVERY": return dgvDeli;
                default: return dgvCash;
            }
        }

        private string GetPaymentFromTab()
        {
            if (reportTabControl.SelectedTab == CashPage)
            {
                notePanel.FillColor = Color.FromArgb(37, 168, 92);
                return "CASH";
            }
            else if (reportTabControl.SelectedTab == CreditPage)
            {
                notePanel.FillColor = Color.FromArgb(231, 111, 81);
                return "CREDIT";
            }

            return "CASH";
        }

        private void HighlightSelectedButton(Panel panel, Guna2Button selectedBtn)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(42, 157, 143);
                    btn.ForeColor = Color.White;
                }
            }

            selectedBtn.FillColor = Color.FromArgb(46, 204, 113);
            selectedBtn.ForeColor = Color.White;
        }

        private Guna2Button CreateStyledButton(string text, object tag, int width = 150, int height = 40)
        {
            return new Guna2Button
            {
                Text = text,
                Width = width,
                Height = height,
                Margin = new Padding(5),
                ForeColor = Color.White,
                FillColor = Color.FromArgb(42, 157, 143),
                HoverState = { FillColor = Color.FromArgb(60, 180, 165) },
                PressedColor = Color.FromArgb(30, 120, 110),
                BorderRadius = 12,
                Font = new Font("Pyidaungsu", 10, FontStyle.Bold),
                Tag = tag,
                Cursor = Cursors.Hand,
                Animated = true,
                TextAlign = HorizontalAlignment.Center
            };
        }

        private void reportTabControl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Customer Report
            if (selectedCustomerIdForReport > 0)
            {
                string paymentType = GetPaymentFromTab();
                DisplaySaleReportForCustomer(selectedCustomerIdForReport, paymentType);
            }

            // Merchant Credit Report
            if (merchantIdForCreditLists > 0)
            {
                LoadMerchantCreditSummary(merchantIdForCreditLists);
            }
        }

        #endregion

        #region Merchant Sales List

        private void LoadSalesRate()
        {
            comboMerchants.Items.Clear();

            if (merchants != null && merchants.Count > 0)
            {
                foreach (Merchant m in merchants)
                {
                    comboMerchants.Items.Add(m);
                }

                comboMerchants.DisplayMember = "MerchantName";
                comboMerchants.ValueMember = "MerchantId";
                comboMerchants.SelectedIndex = 0;
            }
        }

        private void comboMerchants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMerchants.SelectedItem is Merchant selectedMerchant)
            {
                this.currentMerchantId = selectedMerchant.MerchantId;
                RenderSalesData();
            }
        }

        private void RenderSalesData()
        {
            try
            {
                if (currentMerchantId <= 0) return;

                DateTime startDate = dtpStartDate.Value.Date;

                List<MerchantSalesSummary> allSales = merchantService.GetSalesByMerchantId(currentMerchantId, startDate);

                if (allSales == null) allSales = new List<MerchantSalesSummary>();

                var cashSales = allSales.Where(s => s.PaymentType != null && s.PaymentType.ToLower() == "cash").ToList();
                var creditSales = allSales.Where(s => s.PaymentType != null && s.PaymentType.ToLower() == "credit").ToList();

                PopulateGrid(dgvCashSales, cashSales);
                decimal totalCashSalesAmount = cashSales.Sum(c => c.TotalAmount);

                PopulateGrid(dgvCreditSales, creditSales);
                decimal totalCreditSalesAmount = creditSales.Sum(c => c.TotalAmount);

                lblTotalCashSales.Text = $"လက်ငင်းရောင်းရငွေ စုစုပေါင်း = {totalCashSalesAmount:N2} ကျပ်";
                lblTotalCreditSales.Text = $"အကြွေးရောင်းရငွေ စုစုပေါင်း = {totalCreditSalesAmount:N2} ကျပ်";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

        private void PopulateGrid(DataGridView dgv, List<MerchantSalesSummary> salesList)
        {
            dgv.SuspendLayout();
            dgv.DataSource = null;
            dgv.Rows.Clear();

            if (salesList.Count > 0)
            {
                foreach (MerchantSalesSummary sale in salesList)
                {
                    dgv.Rows.Add(
                        sale.CustomerName ?? "",
                        sale.FishName ?? "",
                        sale.Quantity.ToString("N2"),
                        sale.Amount.ToString("N2"),
                        sale.TotalAmount.ToString("N2")
                    );
                }
            }
            else
            {
                dgv.Rows.Add("ဒေတာမရှိပါ", "", "", "", "");
            }

            dgv.ResumeLayout();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentMerchantId > 0)
            {
                RenderSalesData();
            }
        }

        #endregion

        #region Today Report

        private void SetupSummaryGrid()
        {
            dgvMerchantSummary.Rows.Clear();
            dgvMerchantSummary.Columns.Clear();

            dgvMerchantSummary.Columns.Add("colMerchantId", "ID");
            dgvMerchantSummary.Columns.Add("colMerchantName", "ကုန်သည်အမည်");
            dgvMerchantSummary.Columns.Add("colCashQty", "လက်ငင်းအရေအတွက်");
            dgvMerchantSummary.Columns.Add("colCashAmount", "လက်ငင်းငွေ");
            dgvMerchantSummary.Columns.Add("colCreditQty", "အကြွေးအရေအတွက်");
            dgvMerchantSummary.Columns.Add("colCreditAmount", "အကြွေးငွေ");
            dgvMerchantSummary.Columns.Add("colTotalQty", "စုစုပေါင်းအရေအတွက်");
            dgvMerchantSummary.Columns.Add("colTotalAmount", "စုစုပေါင်းငွေ");

            dgvMerchantSummary.Columns["colMerchantId"].Visible = false;
            dgvMerchantSummary.Columns["colMerchantName"].Width = 150;
            dgvMerchantSummary.Columns["colCashQty"].Width = 120;
            dgvMerchantSummary.Columns["colCashAmount"].Width = 130;
            dgvMerchantSummary.Columns["colCreditQty"].Width = 120;
            dgvMerchantSummary.Columns["colCreditAmount"].Width = 130;
            dgvMerchantSummary.Columns["colTotalQty"].Width = 130;
            dgvMerchantSummary.Columns["colTotalAmount"].Width = 130;

            dgvMerchantSummary.RowTemplate.Height = 40;
            dgvMerchantSummary.DefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            dgvMerchantSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
            dgvMerchantSummary.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMerchantSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMerchantSummary.MultiSelect = false;
            dgvMerchantSummary.ReadOnly = true;
            dgvMerchantSummary.RowHeadersVisible = false;
            dgvMerchantSummary.AllowUserToAddRows = false;
        }

        private void SetupDetailGrid()
        {
            dgvPurchaseDetails.Rows.Clear();
            dgvPurchaseDetails.Columns.Clear();

            dgvPurchaseDetails.Columns.Add("colCustomer", "ဖောက်သည်အမည်");
            dgvPurchaseDetails.Columns.Add("colFish", "ငါးအမျိုးအစား");
            dgvPurchaseDetails.Columns.Add("colQty", "ကုန်အလေးချိန်");
            dgvPurchaseDetails.Columns.Add("colPrice", "ဈေးနှုန်း");
            dgvPurchaseDetails.Columns.Add("colTotal", "စုစုပေါင်း");
            dgvPurchaseDetails.Columns.Add("colPayment", "ဝယ်ယူမှုပုံစံ");

            dgvPurchaseDetails.Columns["colCustomer"].Width = 150;
            dgvPurchaseDetails.Columns["colFish"].Width = 150;
            dgvPurchaseDetails.Columns["colQty"].Width = 120;
            dgvPurchaseDetails.Columns["colPrice"].Width = 120;
            dgvPurchaseDetails.Columns["colTotal"].Width = 140;
            dgvPurchaseDetails.Columns["colPayment"].Width = 120;

            dgvPurchaseDetails.RowTemplate.Height = 40;
            dgvPurchaseDetails.DefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            dgvPurchaseDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
            dgvPurchaseDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPurchaseDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseDetails.MultiSelect = false;
            dgvPurchaseDetails.ReadOnly = true;
            dgvPurchaseDetails.RowHeadersVisible = false;
            dgvPurchaseDetails.AllowUserToAddRows = false;
        }

        private void LoadMerchantSummary()
        {
            try
            {
                selectedDate = dtpReportDate.Value.Date;

                List<MerchantDaySummary> summaries = merchantReportService.GetMerchantSummaryByDate(selectedDate);
                dgvMerchantSummary.Rows.Clear();
                dgvPurchaseDetails.Rows.Clear();

                if (summaries.Count > 0)
                {
                    foreach (MerchantDaySummary s in summaries)
                    {
                        dgvMerchantSummary.Rows.Add(
                            s.MerchantId,
                            s.MerchantName,
                            s.CashQuantity.ToString("N2"),
                            s.CashAmount.ToString("#,##0.00"),
                            s.CreditQuantity.ToString("N2"),
                            s.CreditAmount.ToString("#,##0.00"),
                            s.TotalQuantity.ToString("N2"),
                            s.TotalAmount.ToString("#,##0.00")
                        );
                    }

                    decimal totalCash = summaries.Sum(s => s.CashAmount);
                    decimal totalCredit = summaries.Sum(s => s.CreditAmount);
                    decimal grandTotal = totalCash + totalCredit;

                    lblSummaryTotal.Text = $"ကုန်သည် {summaries.Count} ဦး | " +
                                           $"လက်ငင်း: {totalCash:#,##0.00} ကျပ် | " +
                                           $"အကြွေး: {totalCredit:#,##0.00} ကျပ် | " +
                                           $"စုစုပေါင်း: {grandTotal:#,##0.00} ကျပ်";
                }
                else
                {
                    lblSummaryTotal.Text = $"{selectedDate:dd/MM/yyyy} ရက်စွဲအတွက် ဒေတာမရှိပါ";
                    lblDetailTotal.Text = "ဒေတာမရှိပါ";
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error {ex.Message}", "Error", CustomMessageBox.MessageType.Warning);
            }
        }

        private void dgvMerchantSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvMerchantSummary.Rows[e.RowIndex];

                if (row.Cells["colMerchantId"].Value == null) return;

                selectedMerchantId = Convert.ToInt32(row.Cells["colMerchantId"].Value);
                LoadPurchaseDetails(selectedMerchantId, selectedDate);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error {ex.Message}", "Error", CustomMessageBox.MessageType.Error);
            }
        }

        private void LoadPurchaseDetails(int merchantId, DateTime date)
        {
            try
            {
                List<PurchaseDetail> details = merchantReportService.GetPurchaseDetails(merchantId, date);

                dgvPurchaseDetails.Rows.Clear();

                if (details.Count > 0)
                {
                    foreach (PurchaseDetail d in details)
                    {
                        string paymentDisplay;
                        Color rowColor;
                        Color textColor = Color.White;

                        switch (d.PaymentType?.ToLower())
                        {
                            case "cash":
                                paymentDisplay = "လက်ငင်း";
                                rowColor = Color.FromArgb(76, 175, 80);
                                break;
                            case "credit":
                                paymentDisplay = "အကြွေး";
                                rowColor = Color.FromArgb(255, 152, 0);
                                break;
                            case "deli":
                            case "delivery":
                                paymentDisplay = "နယ်ဝေးပို့";
                                rowColor = Color.FromArgb(33, 150, 243);
                                break;
                            default:
                                paymentDisplay = d.PaymentType ?? "မသိ";
                                rowColor = Color.White;
                                textColor = Color.Black;
                                break;
                        }

                        int rowIndex = dgvPurchaseDetails.Rows.Add(
                            d.CustomerName,
                            d.FishName,
                            d.Quantity.ToString("N2"),
                            d.Price.ToString("#,##0.00"),
                            d.TotalAmount.ToString("#,##0.00"),
                            paymentDisplay
                        );

                        dgvPurchaseDetails.Rows[rowIndex].DefaultCellStyle.BackColor = rowColor;
                        dgvPurchaseDetails.Rows[rowIndex].DefaultCellStyle.ForeColor = textColor;
                    }

                    decimal totalQty = details.Sum(d => d.Quantity);
                    decimal totalAmount = details.Sum(d => d.TotalAmount);

                    lblDetailTotal.Text = $"မှတ်တမ်း {details.Count} ခု | " +
                                           $"စုစုပေါင်းအလေးချိန်: {totalQty:N2} | " +
                                           $"စုစုပေါင်းငွေ: {totalAmount:#,##0.00} ကျပ်";
                }
                else
                {
                    dgvPurchaseDetails.Rows.Add("ဒေတာမရှိပါ", "", "", "", "", "");
                    lblDetailTotal.Text = "ဒေတာမရှိပါ";
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                               CustomMessageBox.MessageType.Error);
            }
        }

        private void dtpReportDate_ValueChanged(object sender, EventArgs e)
        {
            LoadMerchantSummary();
        }

        #endregion

        #region Merchant Credits List

        private void DisplayMerchantCreditsLists(List<Merchant> merchants)
        {
            merchantCreditPanels.Controls.Clear();

            lblMerchantCounts.Text = $" ကုန်သည်အရေအတွက် {merchants?.Count ?? 0} ဦး";

            if (merchants == null || merchants.Count == 0)
            {
                bool isSearching = !string.IsNullOrWhiteSpace(txtCreditMerchants.Text);

                Label lbl = new Label
                {
                    Text = isSearching
                        ? "🔍 ရှာဖွေမှုနှင့်ကိုက်ညီသော ကုန်သည်မရှိပါ"
                        : "📋 ကုန်သည် စာရင်း မရှိသေးပါ",
                    Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                    AutoSize = true,
                    Margin = new Padding(5),
                    ForeColor = isSearching
                        ? Color.FromArgb(231, 76, 60)
                        : Color.FromArgb(26, 42, 58)
                };

                merchantCreditPanels.Controls.Add(lbl);
                return;
            }

            foreach (Merchant m in merchants)
            {
                Guna2Button btn = CreateStyledButton(m.MerchantName, m);

                btn.Click += (sender, e) =>
                {
                    Guna2Button clickedBtn = (Guna2Button)sender;
                    Merchant selectedMerchant = (Merchant)clickedBtn.Tag;
                    merchantIdForCreditLists = selectedMerchant.MerchantId;

                    HighlightSelectedButton(merchantCreditPanels, clickedBtn);
                    LoadMerchantCreditSummary(selectedMerchant.MerchantId);

                    lblSelectedMerchant.Text = $"📋 {selectedMerchant.MerchantName} ရဲ့ အကြွေးစာရင်း";
                };

                merchantCreditPanels.Controls.Add(btn);
            }
        }

        private void txtCreditMerchants_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = txtCreditMerchants.Text.Trim();
                string searchName = string.IsNullOrWhiteSpace(name) ? null : name;

                merchants = merchantService.GetAll(searchName);
                DisplayMerchantCreditsLists(merchants);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                CustomMessageBox.MessageType.Error);
            }
        }

        private void LoadMerchantCreditSummary(int merchantId)
        {
            try
            {
                // DataGridView Setup
                if (dgvNormalCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvNormalCredit);
                if (dgvStockCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvStockCredit);
                if (dgvAllCredit.Columns.Count == 0)
                    SetupCreditGrid(dgvAllCredit);

                // ============================================
                // ၁။ ရိုးရိုးအကြွေး
                // ============================================
                List<MerchantCreditSummary> normalCredits =
                    merchantCreditService.GetNormalCreditSummary(merchantId);

                PopulateCreditGrid(dgvNormalCredit, normalCredits, "ရိုးရိုးအကြွေး");

                // ============================================
                // ၂။ ဒိုင်ကျန်အကြွေး
                // ============================================
                List<MerchantCreditSummary> stockCredits =
                    merchantCreditService.GetDepotStockCreditSummary(merchantId);

                PopulateCreditGrid(dgvStockCredit, stockCredits, "ဒိုင်ကျန်အကြွေး");

                // ============================================
                // ၃။ အားလုံးပေါင်း
                // ============================================
                List<MerchantCreditSummary> allCredits =
                    merchantCreditService.GetAllCreditSummary(merchantId);

                PopulateCreditGrid(dgvAllCredit, allCredits, "အားလုံးပေါင်း");

                // ============================================
                // ၄။ Labels Update
                // ============================================
                UpdateCreditLabels(merchantId);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }
        private void SetupCreditGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("colMerchant", "ကုန်သည်အမည်");
            dgv.Columns.Add("colCustomer", "ဖောက်သည်အမည်");    // ✅ အသစ်
            dgv.Columns.Add("colFish", "ငါးအမျိုးအစား");          // ✅ အသစ်
            dgv.Columns.Add("colCreditType", "အကြွေးအမျိုးအစား");
            dgv.Columns.Add("colRecords", "မှတ်တမ်း");
            dgv.Columns.Add("colQuantity", "အရေအတွက်");
            dgv.Columns.Add("colTotalAmount", "စုစုပေါင်းတန်ဖိုး");
            dgv.Columns.Add("colPaid", "ဆပ်ပြီး");
            dgv.Columns.Add("colRemaining", "ကျန်ငွေ");

            dgv.Columns["colMerchant"].Width = 130;
            dgv.Columns["colCustomer"].Width = 130;      // ✅
            dgv.Columns["colFish"].Width = 120;          // ✅
            dgv.Columns["colCreditType"].Width = 130;
            dgv.Columns["colRecords"].Width = 80;
            dgv.Columns["colQuantity"].Width = 100;
            dgv.Columns["colTotalAmount"].Width = 130;
            dgv.Columns["colPaid"].Width = 120;
            dgv.Columns["colRemaining"].Width = 120;

            dgv.RowTemplate.Height = 40;
            dgv.DefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
        }
        private void PopulateCreditGrid(DataGridView dgv,
     List<MerchantCreditSummary> credits, string title)
        {
            dgv.Rows.Clear();

            if (credits == null || credits.Count == 0)
            {
                dgv.Rows.Add("ဒေတာမရှိပါ", "", "", "", "", "", "", "", "");
                return;
            }

            foreach (MerchantCreditSummary credit in credits)
            {
                // Row အရောင်
                Color rowColor;
                Color textColor = Color.Black;
                Font rowFont = new Font("Pyidaungsu", 10, FontStyle.Regular);

                switch (credit.CreditType)
                {
                    case "ရိုးရိုးအကြွေး":
                        rowColor = Color.FromArgb(255, 245, 220); // ဝါဖျော့
                        break;
                    case "ဒိုင်ကျန်အကြွေး":
                        rowColor = Color.FromArgb(220, 240, 255); // အပြာဖျော့
                        break;
                    case "အားလုံးပေါင်း":
                        rowColor = Color.FromArgb(230, 255, 230); // စိမ်းဖျော့
                        textColor = Color.DarkGreen;
                        rowFont = new Font("Pyidaungsu", 10, FontStyle.Bold);
                        break;
                    default:
                        rowColor = Color.White;
                        break;
                }

                int rowIndex = dgv.Rows.Add(
                    credit.MerchantName,
                    credit.CustomerName,        // ✅ ဖောက်သည်နာမည်
                    credit.FishName,            // ✅ ငါးအမည်
                    credit.CreditType,
                    credit.TotalRecords.ToString(),
                    credit.TotalQuantity.ToString("N2"),
                    credit.TotalAmount.ToString("#,##0.00"),
                    credit.PaidAmount.ToString("#,##0.00"),
                    credit.RemainingAmount.ToString("#,##0.00")
                );

                dgv.Rows[rowIndex].DefaultCellStyle.BackColor = rowColor;
                dgv.Rows[rowIndex].DefaultCellStyle.ForeColor = textColor;
                dgv.Rows[rowIndex].DefaultCellStyle.Font = rowFont;

                // ကျန်ငွေ Cell ကို အနီရောင် Bold
                if (credit.RemainingAmount > 0)
                {
                    DataGridViewCell cell = dgv.Rows[rowIndex].Cells["colRemaining"];
                    cell.Style.ForeColor = Color.Red;
                    cell.Style.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
                }
            }
        }

        private void UpdateCreditLabels(int merchantId)
        {
            // ရိုးရိုးအကြွေး
            List<MerchantCreditSummary> normal =
                merchantCreditService.GetNormalCreditSummary(merchantId);

            if (normal.Count > 0)
            {
                decimal normalTotal = normal.Sum(c => c.TotalAmount);
                decimal normalRemaining = normal.Sum(c => c.RemainingAmount);

                lblNormalTotal.Text = $"ရိုးရိုးအကြွေး စုစုပေါင်း: {normalTotal:#,##0.00} ကျပ် | " +
                                      $"ကျန်ငွေ: {normalRemaining:#,##0.00} ကျပ်";
            }
            else
            {
                lblNormalTotal.Text = "ရိုးရိုးအကြွေး: 0 ကျပ်";
            }

            // ဒိုင်ကျန်အကြွေး
            List<MerchantCreditSummary> stock =
                merchantCreditService.GetDepotStockCreditSummary(merchantId);

            if (stock.Count > 0)
            {
                decimal stockTotal = stock.Sum(c => c.TotalAmount);
                decimal stockRemaining = stock.Sum(c => c.RemainingAmount);

                lblStockTotal.Text = $"ဒိုင်ကျန်အကြွေး စုစုပေါင်း: {stockTotal:#,##0.00} ကျပ် | " +
                                     $"ကျန်ငွေ: {stockRemaining:#,##0.00} ကျပ်";
            }
            else
            {
                lblStockTotal.Text = "ဒိုင်ကျန်အကြွေး: 0 ကျပ်";
            }

            // အားလုံးပေါင်း
            List<MerchantCreditSummary> all =
                merchantCreditService.GetAllCreditSummary(merchantId);

            if (all.Count > 0)
            {
                decimal allTotal = all.Sum(c => c.TotalAmount);
                decimal allPaid = all.Sum(c => c.PaidAmount);
                decimal allRemaining = all.Sum(c => c.RemainingAmount);

                lblAllTotal.Text = $"အားလုံးပေါင်း: {allTotal:#,##0.00} ကျပ် | " +
                                   $"ဆပ်ပြီး: {allPaid:#,##0.00} ကျပ် | " +
                                   $"ကျန်ငွေ: {allRemaining:#,##0.00} ကျပ်";
            }
            else
            {
                lblAllTotal.Text = "အားလုံးပေါင်း: 0 ကျပ်";
            }
        }
        #endregion

        private void merchantCreditTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region CreditPayment Section

        private void LoadCreditSearchResults(string searchText)
        {
            try
            {
                
                List<CreditSearchResult> results = creditSearchService.SearchCredits(searchText);

                // FlowLayoutPanel ကိုရှင်းပါ
                flCreditpay.Controls.Clear();
                flCreditpay.SuspendLayout();

                

                if (results == null || results.Count == 0)
                {
                    Label lbl = new Label
                    {
                        Text = "🔍 ရှာဖွေမှုနှင့်ကိုက်ညီသော ဒေတာမတွေ့ပါ",
                        Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                        AutoSize = true,
                        Margin = new Padding(10),
                        ForeColor = Color.Gray
                    };
                    flCreditpay.Controls.Add(lbl);
                    flCreditpay.ResumeLayout();
                    return;
                }

                // Card တွေ ထည့်ပါ
                foreach (CreditSearchResult result in results)
                {
                    CreditCard card = new CreditCard(result);
                    card.Width = flCreditpay.ClientSize.Width - 25;

                    card.PayCreditClicked += Card_PayCreditClicked;

                    flCreditpay.Controls.Add(card);
                }
                flCreditpay.ResumeLayout();

                UpdateSearchTotalLabel(results);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

        private void Card_PayCreditClicked(object sender, CreditSearchResult credit)
        {
            try
            {
                if (credit == null)
                {
                    CustomMessageBox.Show("အကြွေးအချက်အလက် မရှိပါ။", "Error",
                                          CustomMessageBox.MessageType.Error);
                    return;
                }

                // ✅ Credit Payment Form ဖွင့်
                using (CreditPaymentForm paymentForm = new CreditPaymentForm(credit))
                {
                    DialogResult result = paymentForm.ShowDialog();

                    // ✅ ဆပ်မှု အောင်မြင်ရင် Data ပြန် Load
                    if (result == DialogResult.OK && paymentForm.IsSuccess)
                    {
                        string searchText = txtCreditSearch.Text.Trim();
                        LoadCreditSearchResults(searchText);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

        private void UpdateSearchTotalLabel(List<CreditSearchResult> results)
        {
            decimal totalNormal = results.Sum(r => r.NormalCreditAmount);
            decimal totalStock = results.Sum(r => r.StockCreditAmount);
            decimal grandTotal = results.Sum(r => r.TotalAmount);
            decimal totalPaid = results.Sum(r => r.PaidAmount);
            decimal totalRemaining = results.Sum(r => r.RemainingAmount);

            lblSearchTotal.Text =
                $"📊 စုစုပေါင်း - " +
                $"ရိုးရိုး: {totalNormal:#,##0.00} ကျပ် | " +
                $"ဒိုင်ကျန်: {totalStock:#,##0.00} ကျပ် | " +
                $"စုစုပေါင်း: {grandTotal:#,##0.00} ကျပ် | " +
                $"ဆပ်ပြီး: {totalPaid:#,##0.00} ကျပ် | " +
                $"ကျန်ငွေ: {totalRemaining:#,##0.00} ကျပ်";

        }

        #endregion

        private void txtCreditSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtCreditSearch.Text.Trim();
                LoadCreditSearchResults(searchText);
            }
            catch (Exception ex)
            {

                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                              CustomMessageBox.MessageType.Error);
            }
        }

        private void flCreditpay_Resize(object sender, EventArgs e)
        {
            try
            {
                flCreditpay.SuspendLayout();

                int newWidth = flCreditpay.ClientSize.Width - 25;

                foreach (Control c in flCreditpay.Controls)
                {
                    if (c is CreditCard)  // ✅ CreditCard ပဲ ပြင်ပါ
                    {
                        c.Width = newWidth;
                    }
                }

                flCreditpay.ResumeLayout();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ResizeCreditCards: {ex.Message}");
            }
        }
    }
}