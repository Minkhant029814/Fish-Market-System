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
    public partial class AddDailyEntryForm : Form
    {
        private readonly int merchantId;
        private readonly DailyEntryService service = new DailyEntryService();
        private readonly ProductService productService = new ProductService();

        private ComboBox cmbProduct;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtNote;
        private Button btnSave;
        public AddDailyEntryForm(int merchantId)
        {
            this.merchantId = merchantId;
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = productService.GetAllProducts();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "DisplayName";
            cmbProduct.ValueMember = "Id";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedItem == null)
                {
                    MessageBox.Show("ငါးအမျိုးအစားရွေးပါ။", "သတိပေးချက်");
                    return;
                }

                if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
                {
                    MessageBox.Show("အလေးချိန် ၀ ထက်ကြီးတဲ့ ဂဏန်းထည့်ပါ။", "သတိပေးချက်");
                    txtQuantity.Focus();
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("ဈေးနှုန်း ၀ ထက်ကြီးတဲ့ ဂဏန်းထည့်ပါ။", "သတိပေးချက်");
                    txtPrice.Focus();
                    return;
                }

                DailyEntry entry = new DailyEntry
                {
                    MerchantId = merchantId,
                    ProductId = (int)cmbProduct.SelectedValue,
                    Quantity = quantity,
                    PurchasePrice = price,
                    Note = txtNote.Text.Trim()
                };

                if (service.AddEntry(entry))
                {
                    MessageBox.Show("✅ ဒိုင်သွင်းပြီးပါပြီ။", "အောင်မြင်မှု");
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
