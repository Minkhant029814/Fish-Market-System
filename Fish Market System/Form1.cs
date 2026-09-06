using Fish_Market_System.model;
using Fish_Market_System.repository;
using Fish_Market_System.service;
using Fish_Market_System.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fish_Market_System
{
    public partial class Form1 : Form
    {

        private readonly MerchantService merchantService = new MerchantService();
        private readonly CustomerService customerService = new CustomerService();
        private readonly DepotService depotService = new DepotService();
        private readonly FishSpeciesService fishSpeciesService = new FishSpeciesService();

        private  List<Merchant> merchants;
        private  List<Depot> depots;
        private  List<FishSpecies> fishes;

        public Form1()
        {
            InitializeComponent();
            displayAndRefreshMerchant();
            displayAndRefreshCustomer();
            displayAndRefreshDepot();
            displayAndRefreshFish();


        }

        private void btnAddMerchant_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMerchantName.Text))
            {
                MessageBox.Show("ကုန်သည်နာမည်ကို ထည့်သွင်းပေးပါ။");
                return;
            };
            Merchant m = new Merchant
            {
                MerchantName = txtMerchantName.Text
            };

            if (merchantService.AddMerchant(m))
            {
                MessageBox.Show("ကုန်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ");
                displayAndRefreshMerchant();
                txtMerchantName.Clear();
                txtMerchantName.Focus();
            }
        }

        private void displayAndRefreshMerchant()
        {
            // Panel ကို ရှင်းထုတ်တယ်
            merchantPanel.Controls.Clear();

             merchants = merchantService.GetAll();
            
            lblMerchantCounts.Text = $" ကုန်သည်အရေအတွက် {merchants.Count} ဦး";

            foreach (Merchant m in merchants)
            {
                Button btn = new Button
                {
                    Text = m.MerchantName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = m.MerchantId // Merchant ID ကို သိမ်းထားတယ်
                };

                // Click Event ထည့်တယ်
                btn.Click += (sender, e) =>
                {
                    MessageBox.Show($"Selected: {m.MerchantName} (ID: {m.MerchantId})");

                    DepotPurchaseForm form = new DepotPurchaseForm(m.MerchantId,depots,fishes);
                    form.Show();




                };

                merchantPanel.Controls.Add(btn);
            }
        }

        private void displayAndRefreshCustomer()
        {
            customerPanel.Controls.Clear();
            List<Customer> customers = customerService.GetAll();
            lblCustomerCounts.Text = $" ဖောက်သည်အရေအတွက် {customers.Count} ဦး" ;

            foreach (Customer c in customers)
            {
                Button btn = new Button
                {
                    Text = c.CustomerName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    Tag = c.CustomerName // 
                };

                // Click Event ထည့်တယ်
                btn.Click += (sender, e) =>
                {
                    MessageBox.Show($"Selected: {c.CustomerName} (ID: {c.CustomerId})");
                    // ဒီမှာ ခင်ဗျားလုပ်စေချင်တဲ့ action ထည့်ပါ
                };

               customerPanel .Controls.Add(btn);
            }
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClientName.Text))
            {
                MessageBox.Show("ဖောက်သည်နာမည်ကို ထည့်သွင်းပေးပါ။");
                return;
            }
            ;

            Customer customer = new Customer
            {
                CustomerName = txtClientName.Text
            };

            if (customerService.AddCustomer(customer))
            {
                MessageBox.Show("ဖောက်သည်နာမည်အား ထည့်သွင်းပြီးပါပြီ");
                displayAndRefreshCustomer();
                txtClientName.Clear();
                txtClientName.Focus();
            }

        }

        private void btnAddDepot_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdepotName.Text))
            {
                MessageBox.Show("ဒိုင် နာမည်ကို ထည့်သွင်းပေးပါ။");
                return;
            }
            ;



            Depot depot = new Depot
            {
                DepotName = txtdepotName.Text
            };

            if (depotService.AddDepot(depot))
            {
                MessageBox.Show(" ဒိုင် နာမည်အား ထည့်သွင်းပြီးပါပြီ");
                displayAndRefreshDepot();
                txtdepotName.Clear();
                txtdepotName.Focus();
            }

        }


        private void displayAndRefreshDepot()
        {
            depotPanel.Controls.Clear();
           depots = depotService.GetAll();
            //lblCustomerCounts.Text = $" ဖောက်သည်အရေအတွက် {customers.Count} ဦး";

            foreach (Depot depot in depots)
            {
                Button btn = new Button
                {
                    Text = depot.DepotName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                   
                };

                // Click Event ထည့်တယ်
                btn.Click += (sender, e) =>
                {
                    MessageBox.Show($"Selected: {depot.DepotName} (ID: {depot.DepotId})");
                    // ဒီမှာ ခင်ဗျားလုပ်စေချင်တဲ့ action ထည့်ပါ
                };

                depotPanel.Controls.Add(btn);
            }
        }

        private void btnAddNewFish_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtFishName.Text))
            {
                MessageBox.Show("ငါးအမျိုးစား နာမည်ကို ထည့်သွင်းပေးပါ။");
                return;
            }
            ;



           
            FishSpecies fish = new FishSpecies
            {
                FishSpeciesName = txtFishName.Text
            };

            if (fishSpeciesService.AddFish(fish))
            {
                MessageBox.Show(" ငါးအမျိုးစား နာမည်အား ထည့်သွင်းပြီးပါပြီ");
                displayAndRefreshFish();
                txtFishName.Clear();
                txtFishName.Focus();
            }

        }

        private void displayAndRefreshFish()
        {
            // Panel ကို ရှင်းထုတ်တယ်
            fishPanel.Controls.Clear();

           fishes =fishSpeciesService.GetAll();
            //lblMerchantCounts.Text = $" ကုန်သည်အရေအတွက် {merchants.Count} ဦး";

            foreach (FishSpecies f in fishes)
            {
                Button btn = new Button
                {
                    Text = f.FishSpeciesName,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    BackColor = Color.LightBlue,
                    FlatStyle = FlatStyle.Flat,
                    
                };

                // Click Event ထည့်တယ်
                btn.Click += (sender, e) =>
                {
                    MessageBox.Show($"Selected: {f.FishSpeciesName} (ID: {f.FishSpeciesId})");
                    // ဒီမှာ ခင်ဗျားလုပ်စေချင်တဲ့ action ထည့်ပါ
                };

                fishPanel.Controls.Add(btn);
            }
        }
    }
}