using Fish_Market_System.repository;
using FishStore.dto;
using FishStore.model;
using System;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class MerchantService
    {
        private readonly MerchantRepository merchantRepository = new MerchantRepository();


        public bool AddMerchant(Merchant m)
        {
            return merchantRepository.AddMerchant(m);
        }

        public List<Merchant> GetAll(string name = null)
        {
            return merchantRepository.GetAll(name);
        }

        public List<MerchantSalesSummary> GetSalesByMerchantId(int merchantId,DateTime date)
        {
            return merchantRepository.GetSalesByMerchantIdAndDate(merchantId, date);
        }
    }
}
