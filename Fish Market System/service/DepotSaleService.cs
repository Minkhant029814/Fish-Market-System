using Fish_Market_System.dto;
using Fish_Market_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class DepotSaleService
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
