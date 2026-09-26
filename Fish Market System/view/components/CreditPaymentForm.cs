using Fish_Market_System.utilis;
using FishStore.Core.dto.creditPay;
using FishStore.Core.service.creditPay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Market_System.view.components
{
    public partial class CreditPaymentForm : Form
    {
        private readonly CreditSearchResult _credit;
        private readonly CreditPaymentService _paymentService = new CreditPaymentService();
        public bool IsSuccess { get; private set; } = false;

       
        public CreditPaymentForm( CreditSearchResult credit)
        {
            InitializeComponent();
            if(credit == null)
            {
                CustomMessageBox.Show("အကြွေးအချက်အလက် မရှိပါ။", "Error",
                                      CustomMessageBox.MessageType.Error);
                this.Close();
                return;
            }
            _credit = credit;
            LoadData();
        }

        //========================
        // Load Data
        //========================
        private void LoadData()
        {
            try
            {
                lblMerchant.Text = _credit.MerchantName ?? "မသိ";
                lblCustomer.Text = _credit.CustomerName ?? "မသိ";
                lblTotalLabel.Text = $"{_credit.TotalAmount:#,##0.00} ကျပ်";
                lblPaidLabel.Text = $"{_credit.PaidAmount:#,##0.00} ကျပ်";
                lblRemainingLabel.Text = $"{_credit.RemainingAmount:#,##0.00} ကျပ်";

                // ကျန်ငွေ အနီရောင်
                lblRemainingLabel.ForeColor = Color.Red;
                lblRemainingLabel.Font = new Font("Pyidaungsu", 12, FontStyle.Bold);

                // ============================================
                // ၂။ Payment Method ComboBox ဖြည့်ပါ
                // ============================================
                cmbPaymentMethod.Items.Clear();
                cmbPaymentMethod.Items.Add("ငွေသား");
                cmbPaymentMethod.Items.Add("ဘဏ်လွှဲ");
                cmbPaymentMethod.Items.Add("မိုဘိုင်းငွေလွှဲ");
                cmbPaymentMethod.SelectedIndex = 0;

                // ============================================
                // ၃။ Default Pay Amount = Remaining
                // ============================================
                txtPayAmount.Text = _credit.RemainingAmount.ToString("0.00");
                txtPayAmount.Focus();
                txtPayAmount.SelectAll();
            }
            catch (Exception ex)
            {

                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                      CustomMessageBox.MessageType.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtPayAmount.Text))
                {
                    CustomMessageBox.Show("ဆပ်မည့်ငွေ ထည့်ပါ။",
                                          "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    txtPayAmount.Focus();
                    return;
                }
                decimal payAmount;
                if(!decimal.TryParse(txtPayAmount.Text, out payAmount))
                {
                    CustomMessageBox.Show("ဆပ်မည့်ငွေကို ကိန်းဂဏန်းဖြင့် ထည့်ပါ။",
                                          "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    txtPayAmount.Focus();
                    return;
                }

                if(payAmount <= 0)
                {
                    CustomMessageBox.Show("ဆပ်မည့်ငွေသည် ၀ ထက် ကြီးရပါမည်။",
                                          "သတိပေးချက်",
                                          CustomMessageBox.MessageType.Warning);
                    txtPayAmount.Focus();
                    return;
                }
                if (payAmount > _credit.RemainingAmount)
                {
                    CustomMessageBox.Show(
                        $"ဆပ်မည့်ငွေသည် ကျန်ငွေထက် ကျော်နေပါသည်။\n" +
                        $"ကျန်ငွေ: {_credit.RemainingAmount:#,##0.00} ကျပ်",
                        "သတိပေးချက်",
                        CustomMessageBox.MessageType.Warning);
                    txtPayAmount.Focus();
                    return;
                }

                // ============================================
                // ၂။ Confirm Message
                // ============================================
                var confirmResult = MessageBox.Show(
                    $"အကြွေးဆပ်မှာ သေချာပါသလား?\n\n" +
                    $"ကုန်သည်: {_credit.MerchantName}\n" +
                    $"ဖောက်သည်: {_credit.CustomerName}\n" +
                    $"ဆပ်မည့်ငွေ: {payAmount:#,##0.00} ကျပ်\n" +
                    $"ကျန်ငွေ: {(_credit.RemainingAmount - payAmount):#,##0.00} ကျပ်",
                    "အတည်ပြုပါ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes) return;

                // ============================================
                // ၃။ Payment Record ဆောက်ပါ
                // ============================================
                CreditPayment payment = new CreditPayment
                {
                    CreditId = _credit.CreditId,
                    MerchantName = _credit.MerchantName,
                    CustomerName = _credit.CustomerName,
                    PayAmount = payAmount,
                    PaymentDate = DateTime.Now,
                    PaymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "ငွေသား",
                    Note = txtNote.Text.Trim()
                };

                if (_paymentService.PayCredit(payment))
                {
                    CustomMessageBox.Show(
                        $"အကြွေးဆပ်မှု အောင်မြင်ပါသည်။\n" +
                        $"ဆပ်ငွေ: {payAmount:#,##0.00} ကျပ်",
                        "အောင်မြင်သည်",
                        CustomMessageBox.MessageType.Success);

                    IsSuccess = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    CustomMessageBox.Show("အကြွေးဆပ်မှု မအောင်မြင်ပါ။",
                                          "Error",
                                          CustomMessageBox.MessageType.Error);
                }

            }
            catch (Exception ex)
            {

                CustomMessageBox.Show($"Error: {ex.Message}", "Error",
                                                      CustomMessageBox.MessageType.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPayAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
