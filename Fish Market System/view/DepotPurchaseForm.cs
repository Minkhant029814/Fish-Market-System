using Fish_Market_System.service;
using Fish_Market_System.utilis;
using FishStore.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view
{
    public partial class DepotPurchaseForm : Form
    {
        private readonly int merchantId;
        private readonly string merchantName;
        private readonly List<Depot> depots;
        private readonly List<FishCategory> fishes;
        private readonly List<Customer> customers;
        private readonly DepotPurchaseService purchaseService = new DepotPurchaseService();
        public DepotPurchaseForm(int mid,string merchantName,List<Customer> cus,List<Depot> ds,List<FishCategory> fs)
        {
            this.merchantId = mid;
            this.depots = ds;
            this.merchantName = merchantName;
            this.customers = cus;
            this.fishes = fs;
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            // ============================================
            // ၁။ ComboBox တွေကို ရှင်းပါ
            // ============================================
            cmbDepot.Items.Clear();
            cmbSpecies.Items.Clear();
            cmbFishCategory.Items.Clear();
            cmbCus.Items.Clear();

            lblMerchantName.Text = $" ကုန်သည်အမည် {merchantName}";

            // ============================================
            // ၂။ Display/Value Member သတ်မှတ်ပါ
            // ============================================
            cmbDepot.DisplayMember = "DepotName";
            cmbDepot.ValueMember = "DepotId";

            cmbSpecies.DisplayMember = "FishSpeciesName";
            cmbSpecies.ValueMember = "FishSpeciesId"; // ✅ FishSpeciesId ဖြစ်ရမယ်

            cmbCus.DisplayMember = "CustomerName";
            cmbCus.ValueMember = "CustomerId";

            cmbFishCategory.DisplayMember = "CategoryName"; // ✅ CategoryName
            cmbFishCategory.ValueMember = "CategoryId";

            // ============================================
            // ၃။ ဒေတာတွေ ထည့်ပါ
            // ============================================
            foreach (Depot depot in depots)
            {
                cmbDepot.Items.Add(depot);
            }

            foreach (FishCategory fish in fishes)
            {
                cmbFishCategory.Items.Add(fish);
            }

            foreach (Customer c in customers)
            {
                cmbCus.Items.Add(c);
            }

            // ============================================
            // ၄။ Default Selection
            // ============================================
            if (cmbDepot.Items.Count > 0)
                cmbDepot.SelectedIndex = 0;

            if (cmbFishCategory.Items.Count > 0)
                cmbFishCategory.SelectedIndex = 0; // ဒါက Event ကို Trigger လုပ်မယ်

            if (cmbCus.Items.Count > 0)
                cmbCus.SelectedIndex = 0;

            // ============================================
            // ၅။ DataGridView ပြပါ
            // ============================================
            DisplayDepotPurchasesDetails();
        }

        private void btnAddPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                // ============================================
                // ၁။ Validation
                // ============================================
                if (cmbDepot.SelectedItem == null)
                {
                    CustomMessageBox.Show("ဒိုင်တစ်ခု ရွေးချယ်ပါ။", "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                if (cmbFishCategory.SelectedItem == null)
                {
                    CustomMessageBox.Show("ငါးအုပ်စု ရွေးချယ်ပါ။", "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                if (cmbSpecies.SelectedItem == null || !cmbSpecies.Enabled)
                {
                    CustomMessageBox.Show("ငါးမျိုးစိတ် ရွေးချယ်ပါ။", "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                if (cmbCus.SelectedItem == null)
                {
                    CustomMessageBox.Show("ဖောက်သည်တစ်ဦး ရွေးချယ်ပါ။", "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBuyPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    CustomMessageBox.Show("ဈေးနှုန်းနှင့် အလေးချိန်ကို ထည့်သွင်းပါ။", "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    return;
                }

                // ============================================
                // ၂။ Object တွေယူပါ
                // ============================================
                Depot selectedDepot = (Depot)cmbDepot.SelectedItem;
                FishSpecies selectedSpecies = (FishSpecies)cmbSpecies.SelectedItem;
                Customer selectedCustomer = (Customer)cmbCus.SelectedItem;

                // ============================================
                // ၃။ PaymentType ပြောင်းပါ
                // ============================================
                string paymentType = cmbPayment.SelectedItem?.ToString() ?? "လက်ငင်း";

                if (paymentType == "လက်ငင်း")
                    paymentType = "cash";
                else if (paymentType == "အကြွေး")
                    paymentType = "credit";

                // ============================================
                // ၄။ Purchase Object ဆောက်ပါ
                // ============================================
                DepotPurchase purchase = new DepotPurchase
                {
                    DepotId = selectedDepot.DepotId,
                    SpeciesId = selectedSpecies.FishSpeciesId,
                    CustomerId = selectedCustomer.CustomerId,
                    MerchantId = this.merchantId,
                    Price = Convert.ToDecimal(txtBuyPrice.Text),
                    PaymentType = paymentType,
                    Quantity = Convert.ToDecimal(txtQuantity.Text),
                    PurchaseDate = DateTime.Now
                };

                // ============================================
                // ၅။ ဒိုင်ကျန် စစ်ဆေးပါ
                // ============================================
                bool isDepotStock = cbDepotRemain.Checked;
                bool success;
                string successMessage;

                if (isDepotStock)
                {
                    // ဒိုင်ကျန်
                    success = purchaseService.AddDepotRemainedSale(purchase);
                    successMessage = "ဒိုင်ကျန် ဝယ်ယူမှုအောင်မြင်ပါသည်။";
                }
                else
                {
                    // ပုံမှန်
                    success = purchaseService.AddPurchase(purchase);
                    successMessage = "ဝယ်ယူမှုအောင်မြင်ပါသည်။";
                }

                // ============================================
                // ၆။ အောင်မြင်ရင်
                // ============================================
                if (success)
                {
                    CustomMessageBox.Show(successMessage, "အောင်မြင်သည်",
                                          CustomMessageBox.MessageType.Success);

                    txtBuyPrice.Clear();
                    txtQuantity.Clear();
                    txtBuyPrice.Focus();

                    // DataGridView ပြန် Load
                    DisplayDepotPurchasesDetails();
                }
            }
            catch (FormatException)
            {
                CustomMessageBox.Show("ဈေးနှုန်းနှင့်အလေးချိန်ကို ကိန်းဂဏန်းများ ထည့်သွင်းပါ။",
                                      "သတိပေးချက်",
                                      CustomMessageBox.MessageType.Warning);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }
        //Rendering DepotPurchasesDetails

        private void DisplayDepotPurchasesDetails()
        {

            try

            {
                purchaseDetailsView.Rows.Clear();
                List<DepotPurchaseDetails> purchases = purchaseService.GetPurchaseByMerchantId(merchantId);
                decimal totalQuantity = 0;
                decimal totalAmount = 0;

                foreach (var p in purchases)
                {
                    totalQuantity += p.Quantity;
                    totalAmount += p.TotalBuyAmount;
                }
                foreach (DepotPurchaseDetails purchase in purchases)
                {
                    // Payment Type ကို မြန်မာလိုပြောင်းပါ
                    string paymentDisplay;

                    if (purchase.PaymentType == "cash")
                    {
                        paymentDisplay = "လက်ငင်း";
                    }
                    else if (purchase.PaymentType == "credit")
                    {
                        paymentDisplay = "အကြွေး";
                    }
                   
                    else
                    {
                        paymentDisplay = purchase.PaymentType ?? "မသိ";
                    }

                    purchaseDetailsView.Rows.Add(
                        purchase.CustomerName,
                        purchase.FishName,
                        purchase.BuyPrice.ToString("N2"),
                        purchase.Quantity.ToString("N2"),
                        purchase.TotalBuyAmount.ToString("N2"),
                        paymentDisplay // ✅ မြန်မာလိုပြပါ
                    );
                }
                lblTotalQuantity.Text = $"စုစုပေါင်းကုန်ချိန်  { totalQuantity:N2} ";
                lblTotalAmount.Text = $"စုစုပေါင်းတန်ဖိုး {totalAmount:N2} ကျပ် ";

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"အမှားအယွင်းဖြစ်ပွားခဲ့သည်။\n{ex.Message}", "Error",
                      CustomMessageBox.MessageType.Error);


            }
        }

        private void cmbFishCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ✅ Null Check
            if (cmbFishCategory.SelectedItem == null) return;

            FishCategory selectedCategory = (FishCategory)cmbFishCategory.SelectedItem;

            // ✅ MessageBox ဖျက် (Debug အတွက်ပဲ)

            DisplayAllSpecies(selectedCategory.CategoryId);
        }

       
           private void DisplayAllSpecies(int categoryId)
        {
            try
            {
                // ✅ cmbSpecies ကို အရင်ရှင်းပါ
                cmbSpecies.Items.Clear();

                FishSpeciesService fishService = new FishSpeciesService();
                List<FishSpecies> fishes = fishService.GetAllSpecies(categoryId);

                if (fishes == null || fishes.Count == 0)
                {
                    cmbSpecies.Enabled = false;
                    lblSpeciesInfo.Visible = true;
                    lblSpeciesInfo.Text = "⚠️ ဤငါးအုပ်စုအတွက် မျိုးစိတ် မရှိသေးပါ။";
                    lblSpeciesInfo.ForeColor = Color.Orange;
                    return;
                }

                cmbSpecies.Enabled = true;
                lblSpeciesInfo.Visible = false;

                foreach (FishSpecies fish in fishes)
                {
                    cmbSpecies.Items.Add(fish);
                }

                if (cmbSpecies.Items.Count > 0)
                {
                    cmbSpecies.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

    }
    }

