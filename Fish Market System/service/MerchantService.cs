using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class MerchantService
    {
        private readonly MerchantRepository merchantRepository = new MerchantRepository();


        public bool AddMerchant(Merchant m)
        {
            return merchantRepository.AddMerchant(m);
        }

        public List<Merchant> GetAll()
        {
            return merchantRepository.GetAll();
        }
    }
}
