using Fish_Market_System.dto;
using Fish_Market_System.model;
using Fish_Market_System.repository;
using Fish_Market_System.service;
using Fish_Market_System.utilis;
using Fish_Market_System.view;
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
        private List<Customer> customers;
       
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
            ConfigureDataGridView(dgvCashSales);
            ConfigureDataGridView(dgvCreditSales);

            // Default Tab ရွေးပါ
            reportTabControl.SelectedTab = CashPage;

            // Data အကုန် Load လုပ်ပါ
            LoadAllData();

            //DateTime ကို default သတ်မှတ်ထားခြင်း
           
            dtpStartDate.Value = DateTime.Now;
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
            DisplayClientsAndTheirPurchaseList(customers);
            LoadSalesRate();
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
                
                CustomMessageBox.Show("ဖောက်သည်နာမည်ကို ထည့်သွင်းပေးပါ။",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
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
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CustomMessageBox.Show("ငါးအမျိုးစား နာမည်ကို ထည့်သွင်းပေးပါ",
                      "သတိပေးချက်", CustomMessageBox.MessageType.Warning);
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
                Guna2Button btn = CreateStyledButton(f.FishSpeciesName, f);

                btn.Click += (sender, e) =>
                {
                    FishSpecies selectedFish = (FishSpecies)((Guna2Button)sender).Tag;
                    HighlightSelectedButton(fishPanel, (Guna2Button)sender);
                   
                };

                fishPanel.Controls.Add(btn);
            }
        }

        #endregion

        #region Report Section

        private void DisplayClientsAndTheirPurchaseList(List<Customer> customers)
        {
            ClientPanel.Controls.Clear();

            lblClientCounts.Text = $" ဖောက်သည်အရေအတွက် {customers?.Count ?? 0} ဦး";

            // Customer မရှိရင်
            if (customers == null || customers.Count == 0)
            {
                // Search box မှာ စာရှိလား စစ်ပါ
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
                        ? Color.FromArgb(231, 76, 60)   // search → အနီ
                        : Color.FromArgb(26, 42, 58)    // empty  → အနက်ပြာ
                };

                ClientPanel.Controls.Add(lbl);
                return;
            }

            // Customer ရှိရင် button တွေ ဖန်တီးပါ
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
                            report.MerchantName ?? "",
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
               
                
                default:
                    return dgvCash;
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




        #endregion

        #region Helper Methods

        private void HighlightSelectedButton(Panel panel, Guna2Button selectedBtn)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button btn)
                {
                    // မရွေးထားတဲ့ button အားလုံး → default အရောင်
                    btn.FillColor = Color.FromArgb(42, 157, 143);
                    btn.ForeColor = Color.White;
                }
            }

            // ရွေးထားတဲ့ button → အစိမ်းရောင်
            selectedBtn.FillColor = Color.FromArgb(46, 204, 113);   // လှတဲ့ အစိမ်း
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
                FillColor = Color.FromArgb(42, 157, 143),       // Default
                HoverState = { FillColor = Color.FromArgb(60, 180, 165) },  // Hover
                PressedColor = Color.FromArgb(30, 120, 110),    // Pressed
                BorderRadius = 12,
                Font = new Font("Pyidaungsu", 10, FontStyle.Bold),
                Tag = tag,
                Cursor = Cursors.Hand,
                Animated = true,
                TextAlign = HorizontalAlignment.Center
            };
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

        #region Inventory Sections
    

        #endregion


        #region Sale Report
        private void LoadSalesRate()
        {
            comboMerchants.Items.Clear();

            if(merchants.Count > 0)
            {

               
                foreach (Merchant m in merchants)
                {
                    comboMerchants.Items.Add(m);


                }
                comboMerchants.SelectedIndex = 0;

            }

      
            // ComboBox ထဲမှာ မလိုလားအပ်တဲ့ Duplicate item များ မဖြစ်အောင် Clear အရင်လုပ်ပါ

            // Merchant list ကို DataBind လုပ်ခြင်း
            comboMerchants.DisplayMember = "MerchantName"; // User ကို ပြသချင်သည့် Field
            comboMerchants.ValueMember = "MerchantId";     // နောက်ကွယ်မှာ သုံးချင်သည့် ID Field
        
        }
        private int currentMerchantId = 0;
        private void comboMerchants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMerchants.SelectedItem is Merchant selectedMerchant)
            {
                
                this.currentMerchantId = selectedMerchant.MerchantId;

                DateTime startDate = dtpStartDate.Value.Date;
                //MessageBox.Show($"Merchant Id is {merchantId}");
                RenderSalesData();
            }
        }
        

        private void RenderSalesData()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            // ၁။ Merchant ရဲ့ Sales Data အားလုံးကို ယူမည်
            List<MerchantSalesSummary> allSales = merchantService.GetSalesByMerchantId(currentMerchantId,startDate);

            // ၂။ LINQ ဖြင့် Cash နှင့် Credit ခွဲထုတ်မည်
            var cashSales = allSales.Where(s => s.PaymentType.ToLower() == "cash").ToList();
            var creditSales = allSales.Where(s => s.PaymentType.ToLower() == "credit").ToList();

            // ၃။ dgvCash ထဲသို့ ထည့်ခြင်း
            PopulateGrid(dgvCashSales, cashSales);
            decimal totalCashSalesAmount = cashSales.Sum(c => c.TotalAmount);

            // ၄။ dgvCredit ထဲသို့ ထည့်ခြင်း
            PopulateGrid(dgvCreditSales, creditSales);
            decimal totalCreditSalesAmount = creditSales.Sum(c => c.TotalAmount);

            lblTotalCashSales.Text = $"လက်ငင်းရောင်းရငွေ စုစုပေါင်း = { totalCashSalesAmount:N2}ကျပ် ";
            lblTotalCreditSales.Text = $"အကြွေးရောင်းရငွေ စုစုပေါင်း = { totalCreditSalesAmount:N2} ကျပ်";
        }

        // DataGridView ထဲသို့ Data ထည့်ပေးသည့် Helper Method (Code စိစစ်သန့်ရှင်းစေရန်)
        private void PopulateGrid(DataGridView dgv, List<MerchantSalesSummary> salesList)
        {
            dgv.SuspendLayout();
            dgv.DataSource = null;
            dgv.Rows.Clear();

           if(salesList.Count  > 0)
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

                
            } else
            {
                dgv.Rows.Add("ဒေတာမရှိပါ", "", "", "", "");
            }

                dgv.ResumeLayout();
        }


        #endregion

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if(currentMerchantId > 0)
            {
                RenderSalesData();
            }
        }

      
    }
}
