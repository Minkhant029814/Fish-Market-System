using Fish_Market_System.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Market_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addMarchantPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddnewMarchant_Click(object sender, EventArgs e)
        {
            if (!addMarchantPanel.Visible)
            {
                addMarchantPanel.Visible = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarchantName.Text))
            {
                MessageBox.Show("ကုန်သည်နာမည် ထည့်ပါဦး။", "သတိပေးချက်",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button newMerchantBtn = new Button();
            newMerchantBtn.Text = txtMarchantName.Text;
            newMerchantBtn.Width = 150;
            newMerchantBtn.Height = 40;
            newMerchantBtn.BackColor = Color.LightBlue;
            newMerchantBtn.Font = new Font("Myanmar Text", 12);

           
            newMerchantBtn.Click += (s, ev) =>
            {
                
                string name = newMerchantBtn.Text;
                MessageBox.Show($"ရွေးချယ်ထားတဲ့ ကုန်သည်: {name}");
                new Dashboard(name).Show();
            };

          
            marchantDisplayLayout.Controls.Add(newMerchantBtn);

            txtMarchantName.Clear();
            txtMarchantName.Focus();
        }

      
        

       

    }
}
