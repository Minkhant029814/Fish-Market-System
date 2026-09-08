using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto
{
    internal class DepotSale
    {
        public int CustomerId { get; set; }
        public int DepotId { get; set; }
        public int SpeciesId { get; set; }

        public decimal SellPrice { get; set; }
        public decimal Quantity { get; set; }
        public string PaymentType { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
