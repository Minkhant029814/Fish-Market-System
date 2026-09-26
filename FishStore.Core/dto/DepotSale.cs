using System;

namespace FishStore.dto
{
    public class DepotSale
    {
        public int CustomerId { get; set; }
        public int DepotId { get; set; }

        public int MerchantId { get; set; }
        public int SpeciesId { get; set; }

        public decimal SellPrice { get; set; }
        public decimal Quantity { get; set; }
        public string PaymentType { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
