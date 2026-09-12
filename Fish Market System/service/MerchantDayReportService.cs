using Fish_Market_System.dto;
using Fish_Market_System.dto.dailyRepot;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class MerchantDayReportService
    {
        private readonly MerchantDayReportRepository repo = new MerchantDayReportRepository();

        public List<MerchantDaySummary> GetMerchantSummaryByDate(DateTime date)
        {
            return repo.GetMerchantSummaryByDate(date);
        }

        public List<PurchaseDetail> GetPurchaseDetails(int merchantId, DateTime date)
        {
            return repo.GetPurchaseDetails(merchantId, date);
        }

        public List<PurchaseDetail> GetPurchaseDetailsByPayment(int merchantId, DateTime date, string paymentType)
        {
            return repo.GetPurchaseDetailsByPayment(merchantId, date, paymentType);
        }
    }
}
