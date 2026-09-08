using Fish_Market_System.dto;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class SaleReportService
    {
        private readonly SaleReportRepository saleRepo = new SaleReportRepository();

        public List<CustomerSaleReport> GetSalesByCustomerAndPayment(int customerId, string paymentType)
        {
            return saleRepo.GetSalesByCustomerAndPayment(customerId, paymentType);
        }
    }
}
