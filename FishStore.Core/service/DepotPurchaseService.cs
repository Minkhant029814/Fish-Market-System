using FishStore.model;
using FishStore.repository;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class DepotPurchaseService
    {
        private readonly DepotPurchaseRepository purchaseRepo = new DepotPurchaseRepository();

        public bool AddPurchase(DepotPurchase dp)
        {
            return purchaseRepo.AddPurchase(dp);
        }


        public bool AddDepotRemainedSale(DepotPurchase purchase)
        {
            return purchaseRepo.AddDepotRemainedStockSale(purchase);
        }

        public List<DepotPurchaseDetails> GetPurchaseByMerchantId(int merchantId)
        {
            return purchaseRepo.GetPurchaseByMerchantId(merchantId);
        }

        
    }
}
