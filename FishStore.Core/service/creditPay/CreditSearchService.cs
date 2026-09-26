using FishStore.Core.dto.creditPay;
using FishStore.Core.repository.creditPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishStore.Core.service.creditPay
{
   public  class CreditSearchService
    {
        private readonly CreditSearchRepository repo = new CreditSearchRepository();

        public List<CreditSearchResult> SearchCredits(string searchText)
        {
            return repo.SearchCredits(searchText);
        }
    }
}
