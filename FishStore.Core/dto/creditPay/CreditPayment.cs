using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishStore.Core.dto.creditPay
{
    public class CreditPayment
    {
        public int PaymentId { get; set; }
        public int CreditId { get; set; }
        public string MerchantName { get; set; }
        public string CustomerName { get; set; }
        public decimal PayAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Note { get; set; }
    }
}
