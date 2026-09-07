using Fish_Market_System.database;
using Fish_Market_System.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

       public List<DepotPurchaseDetails> GetPurchaseByMerchantId(int merchantId)
        {
            List<DepotPurchaseDetails> purchases = new List<DepotPurchaseDetails>();
            string query = @"SELECT
                    dp.purchaseId,
                     fs.speciesName as FishName,
                    dp.quantity as Quantity,
dp.buyprice as Buyprice,
dp.totalBuyAmount as TotalAmount,
dp.purchaseDate as purchaseDate

FROM depotpurchases dp
Inner Join
    fishSpecies fs on dp.speciesId = fs.speciesId
where 
    dp.merchantId = @MerchantId
order By
    dp.purchaseDate DESC
";

            try
            {
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@MerchantId",merchantId)
                };
                using(DataTable dt = dbConn.GetData(query, ps))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            DepotPurchaseDetails purchase = new DepotPurchaseDetails
                            {
                                PurchaseId = Convert.ToInt32(row["purchaseId"]),
                                FishName = row["FishName"].ToString(),
                                Quantity = Convert.ToDecimal(row["Quantity"]),
                                BuyPrice = Convert.ToDecimal(row["Buyprice"]),
                                TotalBuyAmount = Convert.ToDecimal(row["TotalAmount"]),
                                PurchaseDate = Convert.ToDateTime(row["PurchaseDate"])

                            };

                            purchases.Add(purchase);
                        }
                    }
                    return purchases;
                }

            }catch(Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
                throw;
            }
        }
    }
}
