using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto
{
    internal class MerchantSalesSummary
    {
        public string CustomerName { get; set; }
        public string FishName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; } // Sellprice
        public decimal TotalAmount { get; set; }
        
       public string PaymentType { get; set; }
    }
}
