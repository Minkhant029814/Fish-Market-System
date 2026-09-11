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
    public partial class AddSaleForm : Form
    {
        private readonly int merchantId;
        private readonly DailyEntryService entryService = new DailyEntryService();
        private readonly CustomerService customerService = new CustomerService();
        private readonly SaleService saleService = new SaleService();

        private ComboBox cmbEntry;
        private ComboBox cmbCustomer;
        private ComboBox cmbCustomerType;
        private TextBox txtQuantity;
        private TextBox txtSalePrice;
        private TextBox txtTotal;
        private TextBox txtNote;
        private Button btnSave;

        private List<DailyEntry> availableEntries;
        public AddSaleForm(int merchantId)
        {
            this.merchantId = merchantId;
            InitializeComponent();
            LoadEntries();
            LoadCustomers();
        }

      

        private void LoadEntries()
        {
            availableEntries = entryService.GetRemainingEntries(merchantId);
            cmbEntry.DataSource = availableEntries;
            cmbEntry.DisplayMember = "DisplayName";
            cmbEntry.ValueMember = "Id";
        }

        private void LoadCustomers()
        {
            var customers = customerService.GetAllCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
        }

        private void CmbEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEntry.SelectedItem != null)
            {
                var entry = (DailyEntry)cmbEntry.SelectedItem;
                Label lblInfo = (Label)this.Controls["lblEntryInfo"];
                lblInfo.Text = $"📦 {entry.FishTypeName} - {entry.SizeName} | ကျန်: {entry.RemainingQuantity} ပိဿာ | ဝယ်ဈေး: {entry.PurchasePrice:N0} ကျပ်";

                Label lblRemaining = (Label)this.Controls["lblRemaining"];
                lblRemaining.Text = $"ဒိုင်ကျန်: {entry.RemainingQuantity} ပိဿာ";
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtQuantity.Text, out decimal qty) &&
                decimal.TryParse(txtSalePrice.Text, out decimal price))
            {
                txtTotal.Text = (qty * price).ToString("N0");
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEntry.SelectedItem == null)
                {
                    MessageBox.Show("ဒိုင်ရွေးပါ။", "သတိပေးချက်");
                    return;
                }

                if (cmbCustomer.SelectedItem == null)
                {
                    MessageBox.Show("ဝယ်သူရွေးပါ။", "သတိပေးချက်");
                    return;
                }

                if (!decimal.TryParse(txtQuantity.Text, out decimal qty) || qty <= 0)
                {
                    MessageBox.Show("အလေးချိန် ၀ ထက်ကြီးတဲ့ ဂဏန်းထည့်ပါ။", "သတိပေးချက်");
                    return;
                }

                if (!decimal.TryParse(txtSalePrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("ရောင်းဈေး ၀ ထက်ကြီးတဲ့ ဂဏန်းထည့်ပါ။", "သတိပေးချက်");
                    return;
                }

                var entry = (DailyEntry)cmbEntry.SelectedItem;
                if (entry.RemainingQuantity < qty)
                {
                    MessageBox.Show($"ဒိုင်ကျန် ({entry.RemainingQuantity} ပိဿာ) ထက် ပိုမရောင်းနိုင်ပါ။", "သတိပေးချက်");
                    return;
                }

                Sale sale = new Sale
                {
                    MerchantId = merchantId,
                    DailyEntryId = (int)cmbEntry.SelectedValue,
                    CustomerId = (int)cmbCustomer.SelectedValue,
                    CustomerType = cmbCustomerType.SelectedItem.ToString(),
                    Quantity = qty,
                    SalePrice = price,
                    Note = txtNote.Text.Trim()
                };

                if (saleService.AddSale(sale))
                {
                    MessageBox.Show("✅ ရောင်းချမှုပြီးပါပြီ။", "အောင်မြင်မှု");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ {ex.Message}", "အမှား");
            }
        }
    }
}
