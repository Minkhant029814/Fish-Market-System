using Fish_Market_System.model;
using Fish_Market_System.service;
using Fish_Market_System.utilis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Market_System.view
{
    public partial class DepotPurchaseForm : Form
    {
        private readonly int merchantId;
        private readonly string merchantName;
        private readonly List<Depot> depots;
        private readonly List<FishSpecies> fishes;
        private readonly List<Customer> customers;
        private readonly DepotPurchaseService purchaseService = new DepotPurchaseService();
        public DepotPurchaseForm(int mid,string merchantName,List<Customer> cus,List<Depot> ds,List<FishSpecies> fs)
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
            DisplayDepotPurchasesDetails();
            // ComboBox တွေကို ရှင်းပါ
            cmbDepot.Items.Clear();
            cmbSpecies.Items.Clear();

            lblMerchantName.Text = $" ကုန်သည်အမည် {merchantName}";

            // Display/Value Member သတ်မှတ်ပါ
            cmbDepot.DisplayMember = "DepotName";
            cmbDepot.ValueMember = "DepotId";
            cmbSpecies.DisplayMember = "FishSpeciesName";
            cmbSpecies.ValueMember = "SpeciesId";
            cmbCus.DisplayMember = "CustomerName";
            cmbCus.ValueMember = "CustomerId";

            // ဒေတာတွေ ထည့်ပါ
            foreach (Depot depot in depots)
            {
                cmbDepot.Items.Add(depot);
            }

            foreach (FishSpecies fish in fishes)
            {
                cmbSpecies.Items.Add(fish);
            }

            foreach(Customer c in customers)
            {
                cmbCus.Items.Add(c);
            }

            // Default Selection
            if (cmbDepot.Items.Count > 0)
                cmbDepot.SelectedIndex = 0;

            if (cmbSpecies.Items.Count > 0)
                cmbSpecies.SelectedIndex = 0;

            if(cmbCus.Items.Count > 0)
            {
                cmbCus.SelectedIndex = 0;
            }
        }




        private void btnAddPurchases_Click(object sender, EventArgs e)
        {

            Depot selectedDepot = (Depot)cmbDepot.SelectedItem;
            FishSpecies selectedSpecies = (FishSpecies)cmbSpecies.SelectedItem;
            Customer selectedCustomer = (Customer)cmbCus.SelectedItem;

            if(string.IsNullOrEmpty(txtBuyPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                
                CustomMessageBox.Show("ဈေးနှုန်းနှင့် အလေးချိန်ကိုထည့်သွင်း‌ပါ။", "သတိပေးချက်", CustomMessageBox.MessageType.Warning);

                return;
            }

            string paymentType = cmbPayment.SelectedItem?.ToString() ?? "လက်ငင်း";



            if (paymentType == "လက်ငင်း")
            {
                paymentType = "cash";
            }
            else if (paymentType == "အကြွေး")
            {
                paymentType = "credit";
            }

            try
            {
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
                bool isDepotStock = cbDepotRemain.Checked;
                if (!isDepotStock)
                {
                    if (purchaseService.AddPurchase(purchase))
                    {
                        CustomMessageBox.Show("ဝယ်ယူမှုအောင်မြင်ပါသည်။", "အောင်မြင်သည်",
                                CustomMessageBox.MessageType.Success);
                        txtBuyPrice.Clear();
                        txtBuyPrice.Focus();

                        txtQuantity.Clear();
                        txtQuantity.Focus();

                    }
                }
                else
                {
                    if (purchaseService.AddDepotRemainedSale(purchase))
                    {
                        CustomMessageBox.Show("ဝယ်ယူမှုအောင်မြင်ပါသည်။", "အောင်မြင်သည်",
                               CustomMessageBox.MessageType.Success);
                        txtBuyPrice.Clear();
                        txtBuyPrice.Focus();

                        txtQuantity.Clear();
                        txtQuantity.Focus();


                    }
                  

                }
                DisplayDepotPurchasesDetails();
            }
            catch (FormatException)
            {

                CustomMessageBox.Show("ဈေးနှုန်းနှင့်အလေးချိန်ကို ကိန်းဂဏန်းများ ထည့်သွင်းပေးပါ။","သတိပေးချက်",CustomMessageBox.MessageType.Warning);

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

      
    }
}
