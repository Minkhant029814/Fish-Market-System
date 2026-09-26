using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishStore.Core.dto.creditPay
{
    public class CreditSearchResult
    {
        public int CreditId { get; set; }
        public string MerchantName { get; set; }
        public string CustomerName { get; set; }
        public int TotalRecords { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }       // ရိုးရိုး + ဒိုင်ကျန် ပေါင်း
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }

        // ခွဲပြချင်ရင်
        public decimal NormalCreditAmount { get; set; }    // ရိုးရိုးအကြွေး
        public decimal StockCreditAmount { get; set; }     // ဒိုင်ကျန်အကြွေး
    }
}
