using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class MerchantCreditService
    {
        private readonly MerchantCreditRepository repo = new MerchantCreditRepository();

        public List<MerchantCreditSummary> GetMerchantCreditSummary(int merchantId)
        {
            if (merchantId <= 0)
                throw new ArgumentException("မှန်ကန်သော ကုန်သည် ID ကိုထည့်ပါ။");

            return repo.GetMerchantCreditSummary(merchantId);
        }

        public List<MerchantCreditSummary> GetNormalCreditSummary(int merchantId)
        {
            return repo.GetNormalCreditSummary(merchantId);
        }

        public List<MerchantCreditSummary> GetDepotStockCreditSummary(int merchantId)
        {
            return repo.GetDepotStockCreditSummary(merchantId);
        }

        public List<MerchantCreditSummary> GetAllCreditSummary(int merchantId)
        {
            return repo.GetAllCreditSummary(merchantId);
        }
    }
    
}
