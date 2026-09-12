using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto
{
    internal class MerchantDaySummary
    {
        public int MerchantId { get; set; }
        public string MerchantName { get; set; }
        public decimal CashQuantity { get; set; }      // လက်ငင်းအရေအတွက်
        public decimal CashAmount { get; set; }        // လက်ငင်းငွေ
        public decimal CreditQuantity { get; set; }    // အကြွေးအရေအတွက်
        public decimal CreditAmount { get; set; }      // အကြွေးငွေ
        public decimal TotalQuantity => CashQuantity + CreditQuantity;
        public decimal TotalAmount => CashAmount + CreditAmount;
    }
}
