namespace FishStore.model
{
    public class DepotPurchaseDetails
    {
        public int PurchaseId { get; set; }
        public string FishName { get; set; } 
        public decimal Quantity { get; set; } 
        public decimal BuyPrice { get; set; } 
        public decimal TotalBuyAmount { get; set; } 

        public string CustomerName { get; set; }
        public string PaymentType { get; set; }
    }
}
