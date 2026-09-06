using Fish_Market_System.database;
using Fish_Market_System.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.repository
{
    internal class DepotPurchaseRepository
    {

        private readonly DBConnect dbConn = new DBConnect();

        public bool AddDepotPurchase(DepotPurchase dp)
        {
            string query = "Insert into depotPurchases (depotId,merchantId,speciesId,quantity,buyPrice,purchaseDate) " +
                "values (@did,@mid,@sid,@q,@buy,@date) ";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@did",dp.DepotId),
                new MySqlParameter("@mid",dp.MerchantId),
                new MySqlParameter("@sid",dp.SpeciesId),
                new MySqlParameter("@q",dp.Quantity),
                new MySqlParameter("@buy",dp.Price),
                new MySqlParameter("@date",dp.PurchaseDate)
            };

            return dbConn.ExecuteCommand(query, ps);
            
        }
    }
}
