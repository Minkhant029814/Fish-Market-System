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
    public partial class Dashboard : Form
    {
        
        private List<Fish> fishes = new List<Fish>();
        private List<string> clientsName = new List<string>();

        public Dashboard(string name)
        {
            InitializeComponent();
            lblName.Text = name + "ကုန်စာရင်း";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Fish fish = new Fish();

            fish.FishType = txtFishType.Text;
            fish.Weight = decimal.Parse(txtWeight.Text);
            fish.PricePerEachWeigh = decimal.Parse(txtpricePerOne.Text);

            fishes.Add(fish);

            txtFishType.Clear();
            txtWeight.Clear();
            txtpricePerOne.Clear();
            DisplayData(fishes);
        }

        private void DisplayData(List<Fish> fishes)
        {
            guna2DataGridView2.Rows.Clear();
            decimal totalWeight = 0;
            decimal totalPrice = 0;

            foreach (Fish f in fishes)
            {
                guna2DataGridView2.Rows.Add(
                    f.FishType,
                    f.PricePerEachWeigh.ToString("#,##0"),
                    f.Weight.ToString("#,##0.##"),
                    f.TotalPrice.ToString("#,##0.##"));
                totalPrice += f.TotalPrice;
                totalWeight += f.Weight;
            }

           
            lblTotalWeight.Text = "စုစုပေါင်းအလေးချိန် = " + totalWeight.ToString("#,##0.##") + " ကီလို/ပိဿာ";
            lblTotalPrice.Text = "စုစုပေါင်း တန်ဖိုး = " + totalPrice.ToString("#,##0.##") + " ကျပ်";
        }

        private void btnBackWard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!addClientPanel.Visible)
            {
                addClientPanel.Visible = true;
            }
        }

        private void btnAddClientName_Click(object sender, EventArgs e)
        {
            clientsName.Add(txtClientName.Text);
            MessageBox.Show("ဖောက်သည်အားထည့်သွင်းပြီးပါပြီ");
            txtClientName.Clear();

            addClientPanel.Visible = false;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new SellFormForClient(clientsName,fishes).Show();
        }
    }
}
