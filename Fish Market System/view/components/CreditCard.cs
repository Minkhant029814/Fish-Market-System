using FishStore.Core.dto.creditPay;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System.view.components
{
    public partial class CreditCard : UserControl
    {
        // ============================================================
        // Event - Card ကို Click လုပ်ရင် Parent ကို အသိပေး
        // ============================================================
        public event EventHandler<CreditSearchResult> PayCreditClicked;

        private CreditSearchResult _result;

        // ============================================================
        // Constructor
        // ============================================================
        public CreditCard()
        {
            InitializeComponent();
        }

        public CreditCard(CreditSearchResult result)
        {
            InitializeComponent();

            if (result == null)
            {
                LoadEmptyData();
                return;
            }

            _result = result;
            LoadData(result);
        }

        // ============================================================
        // Load Data
        // ============================================================
        private void LoadData(CreditSearchResult result)
        {
            try
            {
                // ကုန်သည်နာမည်
                lblMerchantName.Text = $"👤 {result.MerchantName ?? "မသိ"}";
                lblMerchantName.Font = new Font("Pyidaungsu", 11, FontStyle.Bold);
                lblMerchantName.ForeColor = Color.FromArgb(42, 157, 143);

                // ဖောက်သည်နာမည်
                lblCustomerName.Text = $"🏪 {result.CustomerName ?? "မသိ"}";
                lblCustomerName.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
                lblCustomerName.ForeColor = Color.FromArgb(52, 73, 94);

                // စုစုပေါင်းတန်ဖိုး
                lblCreditAmount.Text = $"💰 {result.TotalAmount:#,##0.00} ကျပ်";
                lblCreditAmount.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
                lblCreditAmount.ForeColor = Color.FromArgb(41, 128, 185);

                // ကျန်ငွေ
                lblRemainingAmount.Text = $"⏳ {result.RemainingAmount:#,##0.00} ကျပ်";
                lblRemainingAmount.Font = new Font("Pyidaungsu", 10, FontStyle.Bold);
                lblRemainingAmount.ForeColor = result.RemainingAmount > 0
                    ? Color.FromArgb(231, 76, 60)  // အနီ
                    : Color.FromArgb(39, 174, 96); // အစိမ်း

                // Card အရောင်
                if (result.RemainingAmount > 0)
                {
                    this.BackColor = Color.FromArgb(255, 245, 220); // ဝါဖျော့
                }
                else
                {
                    this.BackColor = Color.FromArgb(230, 255, 230); // စိမ်းဖျော့
                }

                // Card Border
                this.BorderStyle = BorderStyle.FixedSingle;
                this.Padding = new Padding(5);
                this.Margin = new Padding(5);
                this.Size = new Size(300, 130);

                // ✅ ကျန်ငွေ မရှိရင် Button ကို Disable
                btnCreditPay.Enabled = result.RemainingAmount > 0;
                btnCreditPay.Text = result.RemainingAmount > 0
                    ? "အကြွေးဆပ်"
                    : "ဆပ်ပြီး";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreditCard.LoadData: {ex.Message}");
            }
        }

        // ============================================================
        // Empty Data
        // ============================================================
        private void LoadEmptyData()
        {
            lblMerchantName.Text = "👤 -";
            lblCustomerName.Text = "🏪 -";
            lblCreditAmount.Text = "💰 0.00 ကျပ်";
            lblRemainingAmount.Text = "⏳ 0.00 ကျပ်";
            btnCreditPay.Enabled = false;
            this.BackColor = Color.LightGray;
        }

        // ============================================================
        // Button Click Event - Parent ကို အသိပေး
        // ============================================================
        private void btnPayCredit_Click(object sender, EventArgs e)
        {
            // ✅ Parent ကို Event နဲ့ အသိပေး
            PayCreditClicked?.Invoke(this, _result);
        }

        // ============================================================
        // Property - Result ကို ပြန်ယူဖို့
        // ============================================================
        public CreditSearchResult Result
        {
            get { return _result; }
        }

        private void btnCreditPay_Click(object sender, EventArgs e)
        {
            new CreditPaymentForm(_result).Show();
        }
    }
}