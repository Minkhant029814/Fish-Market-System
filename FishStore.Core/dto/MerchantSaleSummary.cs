namespace FishStore.dto
{
    public class MerchantSalesSummary
    {
        public string CustomerName { get; set; }
        public string FishName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; } // Sellprice
        public decimal TotalAmount { get; set; }
        
       public string PaymentType { get; set; }
    }
}
