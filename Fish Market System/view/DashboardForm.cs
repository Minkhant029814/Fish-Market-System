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
    public partial class DashboardForm : Form
    {
        private readonly int merchantId;
        private readonly string merchantName;
        private readonly DailyEntryService entryService = new DailyEntryService();
        private readonly SaleService saleService = new SaleService();
        private DataGridView dgvEntries;
        private DataGridView dgvSales;
        public DashboardForm(int id,string name)
        {
            merchantId = id;
            merchantName = name;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load Daily Entries
            var entries = entryService.GetEntriesByMerchant(merchantId);
            dgvEntries.DataSource = entries;

            // Load Sales
            var sales = saleService.GetSalesByMerchant(merchantId);
            dgvSales.DataSource = sales;

        }

        private void BtnAddEntry_Click(object sender, EventArgs e)
        {
            AddDailyEntryForm form = new AddDailyEntryForm(merchantId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void BtnAddSale_Click(object sender, EventArgs e)
        {
            AddSaleForm form = new AddSaleForm(merchantId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void BtnCredit_Click(object sender, EventArgs e)
        {
            CreditPaymentForm form = new CreditPaymentForm(merchantId);
            form.ShowDialog();
            LoadData();
        }
    }
}
