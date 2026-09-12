using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto.dailyRepot
{
   internal class PurchaseDetail
    {
        public int PurchaseId { get; set; }
        public string CustomerName { get; set; }
        public string FishName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
