using Fish_Market_System.dto;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class PurchaseReportService
    {
        private readonly PurchaseReportRepository repo = new PurchaseReportRepository();

        public List<PurchaseReport> GetPurchasesByDateRange(DateTime startDate, DateTime endDate)
        {
            if(startDate > endDate)
            {
                throw new ArgumentException("စတင်ရက်သည် နောက်ဆုံးရက်ထက် မကျော်လွန်ရပါ။");
            }
            return repo.GetPurchasesByDateRange(startDate, endDate);
        }

        public List<PurchaseReport> GetPurchasesByMerchantAndDateRange(int merchantId, DateTime startDate, DateTime endDate)
        {
            if (merchantId <= 0)
            {
                throw new ArgumentException("မှန်ကန်သော ကုန်သည် ID ကိုထည့်ပါ။");
            }

            if (startDate > endDate)
            {
                throw new ArgumentException("စတင်ရက်သည် နောက်ဆုံးရက်ထက် မကျော်လွန်ရပါ။");
            }

            return repo.GetPurchasesByMerchantAndDateRange(merchantId, startDate, endDate);
        }
    }
}
