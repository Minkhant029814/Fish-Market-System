using Fish_Market_System.repository;
using FishStore.dto;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class SaleReportService
    {
        private readonly SaleReportRepository saleRepo = new SaleReportRepository();

        public List<CustomerSaleReport> GetSalesByCustomerAndPayment(int customerId, string paymentType)
        {
            return saleRepo.GetSalesByCustomerAndPayment(customerId, paymentType);
        }
    }
}
