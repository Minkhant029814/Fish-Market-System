using Fish_Market_System.model;
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
    public partial class SellFormForClient : Form
    {
        private readonly List<string> clientsName;
        private readonly List<Fish> fishes;

        // ပြင်ဆင်ချက် ၁: Null Errorမတက်အောင် ဤနေရာတွင်တစ်ခါတည်း new ပေးလိုက်ပါသည်
        private readonly List<Fish> sellingFishes = new List<Fish>();

        private string selectedClientName = "";

        public SellFormForClient(List<string> clientsName, List<Fish> fishes)
        {
            InitializeComponent();
            this.clientsName = clientsName;
            this.fishes = fishes;
            DisplayClients(clientsName);

            DisplayFishTypes(fishes);
        }

        private void DisplayClients(List<string> names)
        {
            clientNameLayout.Controls.Clear();
            foreach (string name in names)
            {
                Button clientBtn = new Button();
                clientBtn.Text = name;
                clientBtn.Width = 150;
                clientBtn.Height = 40;
                clientBtn.BackColor = Color.LightBlue;
                clientBtn.Font = new Font("Myanmar Text", 12);

                clientBtn.Click += (s, ev) =>
                {
                    selectedClientName = name;
                    SellPanel.Visible = true;
                };

                clientNameLayout.Controls.Add(clientBtn);
            }
        }

        private void DisplayFishTypes(List<Fish> fishes)
        {
            fishTypeCombo.Items.Clear();

            var uniqueFishTypes = fishes.Select(f => f.FishType).Distinct().ToList();

            foreach (string type in uniqueFishTypes)
            {
                fishTypeCombo.Items.Add(type);
            }

            if (fishTypeCombo.Items.Count > 0)
            {
                fishTypeCombo.SelectedIndex = 0;
            }

            if(buyStatusCombo.Items.Count > 0)
            {
                buyStatusCombo.SelectedIndex = 0;
                selectedSellingType = buyStatusCombo.SelectedItem.ToString();
            }
        }

        private void fishTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fishTypeCombo.SelectedItem == null) return;

            string selectedFishType = fishTypeCombo.SelectedItem.ToString();

            decimal availableWeight = fishes
                .Where(f => f.FishType == selectedFishType)
                .Sum(f => f.Weight);

            lblFishType.Text = " ငါးအမျိုးစား \n" + selectedFishType;
            lblRemaingWeight.Text = $"လက်ကျန်ကုန်ချိန်:\n {availableWeight:#,##0.##} ပိဿာ";
        }

        private void displaySellingFishes(List<Fish> fishes)
        {
            guna2DataGridView2.Rows.Clear();

            foreach (Fish f in fishes)
            {
                // ပြင်ဆင်ချက် ၄: ရောင်းချမှုစာရင်း Grid တွင်လည်း ဒဿမပိုင်းများ စနစ်တကျ ပေါ်စေရန် ညှိထားပါသည်
                guna2DataGridView2.Rows.Add(
                    f.FishType,
                    f.PricePerEachWeigh.ToString("#,##0"),
                    f.Weight.ToString("#,##0.##"),
                    f.SellingType,
                    f.TotalPrice.ToString("#,##0.##")
                );
            }
        }

        private void btnSellItem_Click(object sender, EventArgs e)
        {
            // စစ်ဆေးမှုအပိုင်း (Text Box ဗလာဖြစ်နေခြင်း ရှိ/မရှိ စစ်ဆေးခြင်း)
            if (fishTypeCombo.SelectedItem == null || string.IsNullOrWhiteSpace(txtWeight.Text) || string.IsNullOrWhiteSpace(txtSellPrice.Text))
            {
                MessageBox.Show("ငါးအမျိုးအစား၊ ရောင်းဈေးနှင့် ရောင်းမည့်အလေးချိန်ကို သေချာဖြည့်ပါ");
                return;
            }

            string selectedFishType = fishTypeCombo.SelectedItem.ToString();
            decimal sellWeight = decimal.Parse(txtWeight.Text);
            decimal sellPrice = decimal.Parse(txtSellPrice.Text);

            decimal totalAvailable = fishes.Where(f => f.FishType == selectedFishType).Sum(f => f.Weight);

            if (sellWeight > totalAvailable)
            {
                MessageBox.Show($"လက်ကျန်မလောက်ပါ။ လက်ရှိ {totalAvailable.ToString("#,##0.##")} ပိဿာသာ ရှိပါသည်");
                return;
            }

            // --- မူရင်း ကုန်ပစ္စည်းထဲမှ အလေးချိန် နှုတ်ယူခြင်း လုပ်ငန်းစဉ် ---
            decimal weightToDeduct = sellWeight;

            foreach (Fish fish in fishes.Where(f => f.FishType == selectedFishType))
            {
                if (weightToDeduct <= 0) break;

                if (fish.Weight >= weightToDeduct)
                {
                    fish.Weight -= weightToDeduct;
                    weightToDeduct = 0;
                }
                else
                {
                    weightToDeduct -= fish.Weight;
                    fish.Weight = 0;
                }
            }

            // ပြင်ဆင်ချက် ၃: အလေးချိန် ၀ ဖြစ်သွားသော ငါးများကို စာရင်းမှ ဖယ်ထုတ်ခြင်းအား ဤနေရာတွင် ချက်ချင်းလုပ်ဆောင်ရပါမည်
            fishes.RemoveAll(f => f.Weight <= 0);

            // --- ပြင်ဆင်ချက် ၂: အရောင်းစာရင်းထဲသို့ ထည့်သွင်းသိမ်းဆည်းခြင်း ---
            Fish fis = new Fish
            {
                FishType = selectedFishType,
                Weight = sellWeight, // ဝိတ်ကို ၀ ဖြစ်သွားတဲ့ weightToDeduct အစား user ရိုက်ခဲ့တဲ့ sellWeight ကို သုံးရပါမယ်
                PricePerEachWeigh = sellPrice,
                SellingType = selectedSellingType
                
            };

            sellingFishes.Add(fis);
            displaySellingFishes(sellingFishes);

            MessageBox.Show($"{selectedClientName} ထံသို့ {selectedFishType} {sellWeight} ပိဿာ ရောင်းချပြီးပါပြီ။");

            // UI ကို Refresh ပြန်လုပ်ခြင်း
            txtWeight.Clear();
            txtSellPrice.Clear(); // ဈေးနှုန်းအကွက်ကိုပါ တစ်ခါတည်း ရှင်းပေးလိုက်ပါသည်
            fishTypeCombo_SelectedIndexChanged(null, null);
        }

        string selectedSellingType = "";
        private void buyStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buyStatusCombo.SelectedItem != null)
            {
                selectedSellingType = buyStatusCombo.SelectedItem.ToString();
            }
        }

        private void btnBackWard_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e) { }
        private void txtWeight_TextChanged(object sender, EventArgs e) { }
        private void SellFormForClient_Load(object sender, EventArgs e) { }
    }
}
