namespace FishStore.model
{
    public class MerchantCreditSummary
    {
        public string MerchantName { get; set; }

        public string CustomerName { get; set; }

        public string FishName { get; set; }
        public string CreditType { get; set; }      // "ရိုးရိုးအကြွေး" / "ဒိုင်ကျန်အကြွေး"
        public int TotalRecords { get; set; }        // မှတ်တမ်းအရေအတွက်
        public decimal TotalQuantity { get; set; }   // စုစုပေါင်းအရေအတွက်
        public decimal TotalAmount { get; set; }     // စုစုပေါင်းငွေတန်ဖိုး
        public decimal PaidAmount { get; set; }      // ဆပ်ပြီးငွေ
        public decimal RemainingAmount { get; set; }
    }
}
