using System;

namespace FishStore.dto
{
    public class CustomerSaleReport
    {
        public string MerchantName  { get; set; }
        public string FishName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
