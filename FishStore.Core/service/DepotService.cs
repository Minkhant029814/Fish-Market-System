using FishStore.model;
using FishStore.repository;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
   public  class DepotService
    {
        private readonly DepotRepository depotRepository = new DepotRepository();

        public bool AddDepot(Depot depot)
        {
            return depotRepository.AddDepot(depot);
        }

        public List<Depot> GetAll()
        {
            return depotRepository.GetAll();
        }
    }
}
