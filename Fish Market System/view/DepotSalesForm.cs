using Fish_Market_System.dto;
using Fish_Market_System.model;
using Fish_Market_System.service;
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
    public partial class DepotSalesForm : Form
    {
        private readonly string CustomerName;
        private readonly int CustomerId;
        private readonly List<Merchant> merchants;
        private readonly List<Depot> Depots;
        private readonly List<FishSpecies> Fishes; // ✅ ထားပါ
        private readonly DepotSaleService saleService = new DepotSaleService();
        private DepotStock depotStock = new DepotStock();
        private int DepotId;

        // ✅ Constructor မှာ Fishes ကိုပါလက်ခံပါ
        public DepotSalesForm(int cId, string cName,List<Merchant> ms, List<Depot> ds, List<FishSpecies> fs)
        {
            InitializeComponent();
            this.CustomerId = cId;
            this.CustomerName = cName;
            this.merchants = ms;
            this.Depots = ds;
            this.Fishes = fs; // ✅ Fishes ကို သိမ်းပါ
            DisplayData();
        }

        private void DisplayData()
        {
            lblTitle.Text = $"{CustomerName} အရောင်းစာရင်း";

            cmbDepot.Items.Clear();
            cmbFishes.Items.Clear();

            // ComboBox ကို Object တွေနဲ့ ဖြည့်ပါ
            foreach (Depot depot in Depots)
            {
                cmbDepot.Items.Add(depot);
            }

            foreach(Merchant mechant in merchants)
            {
                cmbMerchants.Items.Add(mechant);
            }

            // ✅ Fishes က Null မဖြစ်အောင် စစ်ပါ
            if (Fishes != null)
            {
                foreach (FishSpecies fish in Fishes)
                {
                    cmbFishes.Items.Add(fish);
                }
            }

            // DisplayMember နဲ့ ValueMember သတ်မှတ်ပါ
            cmbDepot.DisplayMember = "DepotName";
            cmbDepot.ValueMember = "DepotId";
            cmbMerchants.DisplayMember = "MerchantName";
            cmbMerchants.ValueMember = "MerchantId";
            cmbFishes.DisplayMember = "FishSpeciesName";
            cmbFishes.ValueMember = "FishSpeciesId";

            if (cmbDepot.Items.Count > 0)
            {
                cmbDepot.SelectedIndex = 0;
            }
            if(cmbMerchants.Items.Count > 0)
            {
                cmbMerchants.SelectedIndex = 0;
            }

            if (cmbFishes.Items.Count > 0)
            {
                cmbFishes.SelectedIndex = 0;
            }

            // PaymentType ComboBox ဖြည့်ပါ
            LoadPaymentTypes();

            // Default Stock ပြသခြင်း
            UpdateStockDisplay();
            FishStockDisplay();
        }

        private void LoadPaymentTypes()
        {
            cmbPaymentType.Items.Clear();
            cmbPaymentType.Items.Add("လက်ငင်း");
            cmbPaymentType.Items.Add("အကြွေး");
            //cmbPaymentType.Items.Add("DELIVERY");

            if (cmbPaymentType.Items.Count > 0)
            {
                cmbPaymentType.SelectedIndex = 0;
            }
        }

        private void FishStockDisplay()
        {
            try
            {
                // Panel ကိုရှင်းပါ
                FishByDepotPanel.Controls.Clear();

                // DepotId ရှိမှသာ ခေါ်ပါ
                if (DepotId > 0)
                {
                    List<DepotFish> fishes = saleService.GetFishByDepot(DepotId);

                    if (fishes != null && fishes.Count > 0)
                    {
                        foreach (DepotFish fish in fishes)
                        {
                            Label lbl = new Label
                            {
                                Text = $"🐟 {fish.FishName} → {fish.TotalQuantity:N2} ကီလို",
                                Font = new Font("Pyidaungsu", 10, FontStyle.Regular),
                                AutoSize = true,
                                Margin = new Padding(3),
                                ForeColor = Color.Black
                            };
                            FishByDepotPanel.Controls.Add(lbl);
                        }

                        // စုစုပေါင်းထည့်ပါ
                        decimal total = fishes.Sum(f => f.TotalQuantity);
                        Label lblTotal = new Label
                        {
                            Text = $"📊 စုစုပေါင်း → {total:N2} ကီလို",
                            Font = new Font("Pyidaungsu", 10, FontStyle.Bold),
                            AutoSize = true,
                            Margin = new Padding(3),
                            ForeColor = Color.Red,
                            BackColor = Color.LightYellow
                        };
                        FishByDepotPanel.Controls.Add(lblTotal);
                    }
                    else
                    {
                        Label lbl = new Label
                        {
                            Text = "📭 ကုန်ချိန်မရှိသေးပါ",
                            Font = new Font("Pyidaungsu", 10, FontStyle.Regular),
                            AutoSize = true,
                            Margin = new Padding(3),
                            ForeColor = Color.Gray
                        };
                        FishByDepotPanel.Controls.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FishStockDisplay: {ex.Message}");
                MessageBox.Show($"Error loading fish stock: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStockDisplay()
        {
            try
            {
                if (cmbDepot.SelectedItem != null)
                {
                    Depot selectedDepot = (Depot)cmbDepot.SelectedItem;
                    DepotId = selectedDepot.DepotId; // ✅ DepotId ကို သိမ်းပါ

                    // ✅ Service ကနေ ပြန်ယူပါ
                    depotStock = saleService.GetDepotStockById(DepotId);

                    if (depotStock != null && depotStock.TotalQuantity > 0)
                    {
                        lblRemaingStockByDepot.Text = $"{depotStock.DepotName} ရှိ လက်ကျန်ကုန်ချိန် {depotStock.TotalQuantity:N2} ကီလို";
                    }
                    else
                    {
                        lblRemaingStockByDepot.Text = $"{selectedDepot.DepotName} ရှိ လက်ကျန်ကုန်ချိန် 0 ကီလို";
                    }

                    // ✅ FishStockDisplay ကိုလည်း Refresh လုပ်ပါ
                    FishStockDisplay();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating stock: {ex.Message}");
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            try
            {
                // ၁။ Validation
                if (cmbDepot.SelectedItem == null)
                {
                    MessageBox.Show("ဒိုင်တစ်ခု ရွေးချယ်ပါ။", "သတိပေးချက်",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbDepot.Focus();
                    return;
                }

                if (cmbFishes.SelectedItem == null)
                {
                    MessageBox.Show("ငါးအမျိုးအစား တစ်ခု ရွေးချယ်ပါ။", "သတိပေးချက်",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbFishes.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("ဈေးနှုန်း ထည့်သွင်းပါ။", "သတိပေးချက်",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("အလေးချိန် ထည့်သွင်းပါ။", "သတိပေးချက်",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }

                // ၂။ Object တွေကို ပြန်ယူပါ
                Depot selectedDepot = (Depot)cmbDepot.SelectedItem;
                FishSpecies selectedFish = (FishSpecies)cmbFishes.SelectedItem;
                Merchant seletctedMerchant = (Merchant)cmbMerchants.SelectedItem;
                DepotId = selectedDepot.DepotId;

                // ၃။ Stock စစ်ဆေးပါ
                depotStock = saleService.GetDepotStockById(DepotId);
                decimal quantity = Convert.ToDecimal(txtQuantity.Text);

                // ✅ Species Stock ကိုပါ စစ်ဆေးပါ
                List<DepotFish> speciesStocks = saleService.GetFishByDepot(DepotId);
                decimal availableForSpecies = 0;

                if (speciesStocks != null)
                {
                    var speciesStock = speciesStocks.FirstOrDefault(f => f.FishName == selectedFish.FishSpeciesName);

                   
                    if (speciesStock != null)
                    {
                        availableForSpecies = speciesStock.TotalQuantity;
                    }
                }

                if (availableForSpecies < quantity)
                {
                    MessageBox.Show($"Stock မလုံလောက်ပါ။\n{selectedFish.FishSpeciesName} ရှိသော ပမာဏ: {availableForSpecies:N2}\nလိုအပ်သော ပမာဏ: {quantity:N2}",
                                   "သတိပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string paymentType = cmbPaymentType.SelectedItem?.ToString() ?? "လက်ငင်း";

               

                if (paymentType == "လက်ငင်း")
                {
                    paymentType = "cash"; 
                }
                else if (paymentType == "အကြွေး")
                {
                    paymentType = "credit";
                }

                    // ၄။ Sale Object ဆောက်ပါ
                    DepotSale sale = new DepotSale
                    {
                        CustomerId = this.CustomerId,
                        DepotId = selectedDepot.DepotId,
                        MerchantId = seletctedMerchant.MerchantId,
                        SpeciesId = selectedFish.FishSpeciesId,
                        Quantity = quantity,
                        SellPrice = Convert.ToDecimal(txtPrice.Text),
                        PaymentType = paymentType, // ပြောင်းထားတဲ့တန်ဖိုးကိုသုံးပါ
                        SaleDate = DateTime.Now
                    };

                MessageBox.Show("Selected item is " + sale.PaymentType);

                // ၅။ Save လုပ်ပါ
                if (saleService.AddSale(sale))
                {
                    MessageBox.Show("အရောင်းစာရင်းအား ထည့်သွင်းပြီးပါပြီ", "အောင်မြင်သည်",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ၆။ Form ကို Refresh လုပ်ပါ
                    ClearInputs();
                    UpdateStockDisplay();
                    FishStockDisplay();
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"Object Casting Error ဖြစ်နေပါတယ်။\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"နံပါတ်မှန်ကန်စွာ ထည့်သွင်းပါ။\n{ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbPaymentType.SelectedIndex = 0;

            if (cmbDepot.Items.Count > 0)
                cmbDepot.SelectedIndex = 0;

            if (cmbFishes.Items.Count > 0)
                cmbFishes.SelectedIndex = 0;
        }

        // ✅ ComboBox Selection Changed Event
        private void cmbDepot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateStockDisplay();
        }

        private void lblRemaingStockByDepot_Click(object sender, EventArgs e)
        {
            // လိုအပ်ရင် ထည့်ပါ
        }

        private void cmbFishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}