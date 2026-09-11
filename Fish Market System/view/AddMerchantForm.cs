using Fish_Market_System.repository;
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
    public partial class AddMerchantForm : Form
    {
        private readonly MerchantService service = new MerchantService();
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnSave;
        public AddMerchantForm()
        {
            InitializeComponent();
        }

      

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("ကုန်သည်အမည် ထည့်ပါ။", "သတိပေးချက်");
                    txtName.Focus();
                    return;
                }

                Merchant merchant = new Merchant
                {
                    Name = name,
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };
                if (service.AddMerchant(merchant))
                {
                    MessageBox.Show("✅ ကုန်သည်ထည့်သွင်းပြီးပါပြီ။", "အောင်မြင်မှု");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ {ex.Message}", "အမှား");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
