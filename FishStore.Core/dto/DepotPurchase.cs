using System;

namespace FishStore.model
{
    public class DepotPurchase
    {

        public int MerchantId { get; set; }
        public int SpeciesId { get; set; }

        public int CustomerId { get; set; }
        public int DepotId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public string PaymentType { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
