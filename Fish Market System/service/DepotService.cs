using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class DepotService
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
