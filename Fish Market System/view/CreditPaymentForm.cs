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
    public partial class CreditPaymentForm : Form
    {
        private readonly int merchantId;
        private readonly SaleService saleService = new SaleService();
        private DataGridView dgvCredit;
        public CreditPaymentForm(int merchantId)
        {
            this.merchantId = merchantId;
            InitializeComponent();
            LoadCreditSales();
        }

        private void LoadCreditSales()
        {
            var sales = saleService.GetUnpaidCreditSales(merchantId);
            dgvCredit.DataSource = sales;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (dgvCredit.SelectedRows.Count == 0)
            {
                MessageBox.Show("ကြွေးပေးချေလိုသော စာရင်းကို ရွေးပါ။", "သတိပေးချက်");
                return;
            }

            var selectedRow = dgvCredit.SelectedRows[0];
            var sale = (Sale)selectedRow.DataBoundItem;

            if (sale.PaymentStatus == "Paid")
            {
                MessageBox.Show("ဤစာရင်းက ကြွေးပြီးသွားပါပြီ။", "သတိပေးချက်");
                return;
            }

            string amountStr = Microsoft.VisualBasic.Interaction.InputBox(
                $"ကြွေးပေးချေမည့်ငွေ:\n\nစုစုပေါင်းကြွေး: {sale.TotalAmount:N0} ကျပ်",
                "ကြွေးပေးချေခြင်း",
                sale.TotalAmount.ToString()
            );

            if (string.IsNullOrEmpty(amountStr))
                return;

            if (decimal.TryParse(amountStr, out decimal amount) && amount > 0)
            {
                // TODO: Call Credit Payment Service
                MessageBox.Show($"✅ ကြွေးပေးချေပြီးပါပြီ။\nပေးချေငွေ: {amount:N0} ကျပ်", "အောင်မြင်မှု");
                LoadCreditSales();
            }
            else
            {
                MessageBox.Show("ငွေပမာဏ မှန်ကန်စွာထည့်ပါ။", "သတိပေးချက်");
            }
        }
    }
}
