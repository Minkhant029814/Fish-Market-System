using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class DepotPurchaseService
    {
        private readonly DepotPurchaseRepository purchaseRepo = new DepotPurchaseRepository();

        public bool AddPurchase(DepotPurchase dp)
        {
            return purchaseRepo.AddDepotPurchase(dp);
        }
    }
}
