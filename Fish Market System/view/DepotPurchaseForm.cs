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
    public partial class DepotPurchaseForm : Form
    {
        private readonly int merchantId;
        private readonly List<Depot> depots;
        private readonly List<FishSpecies> fishes;
        private readonly DepotPurchaseService purchaseService = new DepotPurchaseService();
        public DepotPurchaseForm(int mid,List<Depot> ds,List<FishSpecies> fs)
        {
            this.merchantId = mid;
            this.depots = ds;
            this.fishes = fs;
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            // ComboBox တွေကို ရှင်းပါ
            cmbDepot.Items.Clear();
            cmbSpecies.Items.Clear();

            // Display/Value Member သတ်မှတ်ပါ
            cmbDepot.DisplayMember = "DepotName";
            cmbDepot.ValueMember = "DepotId";
            cmbSpecies.DisplayMember = "FishSpeciesName";
            cmbSpecies.ValueMember = "SpeciesId";

            // ဒေတာတွေ ထည့်ပါ
            foreach (Depot depot in depots)
            {
                cmbDepot.Items.Add(depot);
            }

            foreach (FishSpecies fish in fishes)
            {
                cmbSpecies.Items.Add(fish);
            }

            // Default Selection
            if (cmbDepot.Items.Count > 0)
                cmbDepot.SelectedIndex = 0;

            if (cmbSpecies.Items.Count > 0)
                cmbSpecies.SelectedIndex = 0;
        }




        private void btnAddPurchases_Click(object sender, EventArgs e)
        {

            Depot selectedDepot = (Depot)cmbDepot.SelectedItem;
            FishSpecies selectedSpecies = (FishSpecies)cmbSpecies.SelectedItem;

            DepotPurchase purchase = new DepotPurchase
            {
                DepotId = selectedDepot.DepotId,
                SpeciesId = selectedSpecies.FishSpeciesId,
                MerchantId = this.merchantId,
                Price = Convert.ToDecimal(txtBuyPrice.Text),
                Quantity = Convert.ToDecimal(txtQuantity.Text),
                PurchaseDate = DateTime.Now


            };
            if (purchaseService.AddPurchase(purchase))
            {
                MessageBox.Show("ဝယ်ယူမှုအောင်မြင်ပါသည်။", "အောင်မြင်သည်",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuyPrice.Clear();
                txtBuyPrice.Focus();

                txtQuantity.Clear();
                txtQuantity.Focus();

            }

            MessageBox.Show("Depot id is " + purchase.DepotId + "\n " + "fish species " + purchase.SpeciesId + "\n " + "merchant Id " + purchase.MerchantId);
           
        }
    }
}
