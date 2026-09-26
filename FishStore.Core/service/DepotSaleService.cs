using Fish_Market_System.Repositories;
using FishStore.dto;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class DepotSaleService
    {
        private readonly DepotSaleRepository saleRepo = new DepotSaleRepository();

        public bool AddSale(DepotSale sale)
        {
            return saleRepo.AddSale(sale);
        }

       

        public List<DepotFish> GetFishByDepot(int depotId)
        {
            return saleRepo.GetFishByDepot(depotId);
        }

        
    }
}
