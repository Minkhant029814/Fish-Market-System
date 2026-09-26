using System;

namespace FishStore.dto
{
    public class PurchaseReport
    {
        public string MerchantName { get; set; }
        public string FishName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
