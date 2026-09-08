using Fish_Market_System.dto;
using Fish_Market_System.model;
using Fish_Market_System.repository;
using Fish_Market_System.service;
using Fish_Market_System.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fish_Market_System
{
    public partial class Form1 : Form
    {
        // Services
        private readonly MerchantService merchantService = new MerchantService();
        private readonly CustomerService customerService = new CustomerService();
        private readonly DepotService depotService = new DepotService();
        private readonly FishSpeciesService fishSpeciesService = new FishSpeciesService();
        private readonly DepotSaleService saleService = new DepotSaleService();
        private readonly SaleReportService reportService = new SaleReportService();

        // Lists
        private List<Merchant> merchants;
        private List<Depot> depots;
        private List<FishSpecies> fishes;

        // Report Variables
        private int selectedCustomerIdForReport = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        #region Form Load & Setup

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView တွေကို Configure လုပ်ပါ
            ConfigureDataGridView(dgvCash);
            ConfigureDataGridView(dvgCredit);
            ConfigureDataGridView(dvgDeli);

            // Default Tab ရွေးပါ
            reportTabControl.SelectedTab = CashPage;

            // Data အကုန် Load လုပ်ပါ
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
            view.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            view.RowsDefaultCellStyle.BackColor = Color.White;
        }

        private void LoadAllData()
        {
            displayAndRefreshMerchant();
            displayAndRefreshCustomer();
            displayAndRefreshDepot();
            displayAndRefreshFish();
            DisplayClientsAndTheirPurchaseList();
        }

        #endregion

        #region Merchant Section

        private void btnAddMerchant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMerchantName.Text))
            {
                MessageBox.Show("ကုန်သည်နာမည်ကို ထည့်သွင်းပေးပါ။", "သတိပေးချက်",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMerchantName.Focus();
                return;
            }

            Merchant m = new Merchant
            {
                MerchantName = txtMerchantName.Text
            };

            if (merchantService.AddMerchant(m))
            {
                MessageBox.Show("ကုန်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayAndRefreshMerchant();
                txtMerchantName.Clear();
                txtMerchantName.Focus();
            }
        }

        private void displayAndRefreshMerchant()
        {
            merchantPanel.Controls.Clear();

            merchants = merchantService.GetAll();
            lblMerchantCounts.Text = $" ကုန်သည်အရေအတွက် {merchants.Count} ဦး";

            foreach (Merchant m in merchants)
            {
                Button btn = new Button
                {
                    Text = m.MerchantName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = m,
                    Cursor = Cursors.Hand
                };

                btn.Click += (sender, e) =>
                {
                    Merchant selectedMerchant = (Merchant)((Button)sender).Tag;
                    HighlightSelectedButton(merchantPanel, (Button)sender);

                    DepotPurchaseForm form = new DepotPurchaseForm(
                        selectedMerchant.MerchantId,
                        depots,
                        fishes
                    );
                    form.Show();
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
                MessageBox.Show("ဖောက်သည်နာမည်ကို ထည့်သွင်းပေးပါ။", "သတိပေးချက်",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClientName.Focus();
                return;
            }

            Customer customer = new Customer
            {
                CustomerName = txtClientName.Text
            };

            if (customerService.AddCustomer(customer))
            {
                MessageBox.Show("ဖောက်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayAndRefreshCustomer();
                txtClientName.Clear();
                txtClientName.Focus();
            }
        }

        private void displayAndRefreshCustomer()
        {
            customerPanel.Controls.Clear();
            List<Customer> customers = customerService.GetAll();
            lblCustomerCounts.Text = $" ဖောက်သည်အရေအတွက် {customers.Count} ဦး";

            foreach (Customer c in customers)
            {
                Button btn = new Button
                {
                    Text = c.CustomerName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = c,
                    Cursor = Cursors.Hand
                };

                btn.Click += (sender, e) =>
                {
                    Customer selectedCustomer = (Customer)((Button)sender).Tag;
                    HighlightSelectedButton(customerPanel, (Button)sender);

                    DepotSalesForm form = new DepotSalesForm(
                        selectedCustomer.CustomerId,
                        selectedCustomer.CustomerName,
                        depots,
                        fishes
                    );
                    form.Show();
                };

                customerPanel.Controls.Add(btn);
            }
        }

        #endregion

        #region Depot Section

        private void btnAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdepotName.Text))
            {
                MessageBox.Show("ဒိုင်နာမည်ကို ထည့်သွင်းပေးပါ။", "သတိပေးချက်",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdepotName.Focus();
                return;
            }

            Depot depot = new Depot
            {
                DepotName = txtdepotName.Text
            };

            if (depotService.AddDepot(depot))
            {
                MessageBox.Show("ဒိုင်နာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayAndRefreshDepot();
                txtdepotName.Clear();
                txtdepotName.Focus();
            }
        }

        private void displayAndRefreshDepot()
        {
            depotPanel.Controls.Clear();
            depots = depotService.GetAll();

            foreach (Depot depot in depots)
            {
                Button btn = new Button
                {
                    Text = depot.DepotName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = depot,
                    Cursor = Cursors.Hand
                };

                btn.Click += (sender, e) =>
                {
                    Depot selectedDepot = (Depot)((Button)sender).Tag;
                    HighlightSelectedButton(depotPanel, (Button)sender);
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
                MessageBox.Show($"Error loading fish stock: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Fish Species Section

        private void btnAddNewFish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFishName.Text))
            {
                MessageBox.Show("ငါးအမျိုးစားနာမည်ကို ထည့်သွင်းပေးပါ။", "သတိပေးချက်",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFishName.Focus();
                return;
            }

            FishSpecies fish = new FishSpecies
            {
                FishSpeciesName = txtFishName.Text
            };

            if (fishSpeciesService.AddFish(fish))
            {
                MessageBox.Show("ငါးအမျိုးစားနာမည်အား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayAndRefreshFish();
                txtFishName.Clear();
                txtFishName.Focus();
            }
        }

        private void displayAndRefreshFish()
        {
            fishPanel.Controls.Clear();
            fishes = fishSpeciesService.GetAll();

            foreach (FishSpecies f in fishes)
            {
                Button btn = new Button
                {
                    Text = f.FishSpeciesName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = f,
                    Cursor = Cursors.Hand
                };

                btn.Click += (sender, e) =>
                {
                    FishSpecies selectedFish = (FishSpecies)((Button)sender).Tag;
                    HighlightSelectedButton(fishPanel, (Button)sender);
                    MessageBox.Show($"Selected: {selectedFish.FishSpeciesName} (ID: {selectedFish.FishSpeciesId})",
                                   "သတင်းအချက်အလက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                fishPanel.Controls.Add(btn);
            }
        }

        #endregion

        #region Report Section

        private void DisplayClientsAndTheirPurchaseList()
        {
            ClientPanel.Controls.Clear();
            List<Customer> customers = customerService.GetAll();
            lblClientCounts.Text = $" ဖောက်သည်အရေအတွက် {customers.Count} ဦး";

            foreach (Customer c in customers)
            {
                Button btn = new Button
                {
                    Text = c.CustomerName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = c,
                    Cursor = Cursors.Hand
                };

                btn.Click += (sender, e) =>
                {
                    Button clickedBtn = (Button)sender;
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
                string dbPaymentType;
                string type = paymentType?.ToUpper() ?? "CASH";

                switch (type)
                {
                    case "CASH":
                        dbPaymentType = "cash";
                        break;
                    case "CREDIT":
                        dbPaymentType = "credit";
                        break;
                    case "DELI":
                    case "DELIVERY":
                        dbPaymentType = "deli";
                        break;
                    default:
                        dbPaymentType = "cash";
                        break;
                }

                List<CustomerSaleReport> reports = reportService.GetSalesByCustomerAndPayment(customerId, dbPaymentType);
                DataGridView view = GetDataGridViewByPaymentType(paymentType);

                // DataGridView ကိုရှင်းပါ (Rows ပဲရှင်းပါ)
                view.Rows.Clear();

                if (reports.Count > 0)
                {
                    foreach (CustomerSaleReport report in reports)
                    {
                        view.Rows.Add(
                            report.DepotName ?? "",
                            report.FishName ?? "",
                            report.Quantity.ToString("N2"),
                            report.Price.ToString("#,##0.00"),
                            report.TotalAmount.ToString("#,##0.00"),
                            report.SaleDate.ToString("dd/MM/yyyy")
                        );
                    }

                    // စုစုပေါင်းပြပါ
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
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridView GetDataGridViewByPaymentType(string paymentType)
        {
            string type = paymentType?.ToUpper() ?? "CASH";

            switch (type)
            {
                case "CASH":
                    return dgvCash;
                case "CREDIT":
                    return dvgCredit;
                case "DELI":
                case "DELIVERY":
                    return dvgDeli;
                default:
                    return dgvCash;
            }
        }

        private string GetPaymentFromTab()
        {
            if (reportTabControl.SelectedTab == CashPage)
                return "CASH";
            else if (reportTabControl.SelectedTab == CreditPage)
                return "CREDIT";
            else if (reportTabControl.SelectedTab == DeliPage)
                return "DELI";

            return "CASH";
        }

        
   

        #endregion

        #region Helper Methods

        private void HighlightSelectedButton(Panel panel, Button selectedBtn)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.LightBlue;
                    btn.ForeColor = Color.Black;
                }
            }

            selectedBtn.BackColor = Color.DodgerBlue;
            selectedBtn.ForeColor = Color.White;
        }

        #endregion

        private void reportTabControl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (selectedCustomerIdForReport > 0)
            {
                string paymentType = GetPaymentFromTab();
                DisplaySaleReportForCustomer(selectedCustomerIdForReport, paymentType);
            }
        }
    }
}