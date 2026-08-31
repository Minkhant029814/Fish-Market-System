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
            addMarchantPanel.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMarchantName.Text);

        }
    }
}
