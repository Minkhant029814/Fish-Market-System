using Fish_Market_System.repository;
using FishStore.dto.dailyRepot;
using System;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class MerchantDayReportService
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
