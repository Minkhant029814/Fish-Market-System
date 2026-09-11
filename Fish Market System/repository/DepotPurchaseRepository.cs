using Fish_Market_System.database;
using Fish_Market_System.dto;
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

        public bool AddPurchase(DepotPurchase purchase)
        {
            try
            {
                // Query တစ်ခုတည်း
                string query = @"
            INSERT INTO depotpurchases 
                (depotId, merchantId, customerId, speciesId, quantity, buyprice,paymentType, purchaseDate)
            VALUES 
                (@dId, @mId, @cId, @sId, @q, @price,@payment, @pDate)";

                MySqlParameter[] ps = new MySqlParameter[]
                {
            new MySqlParameter("@dId", purchase.DepotId),
            new MySqlParameter("@mId", purchase.MerchantId),
            new MySqlParameter("@cId",purchase.CustomerId),
            new MySqlParameter("@sId", purchase.SpeciesId),
            new MySqlParameter("@q", purchase.Quantity),
            new MySqlParameter("@price", purchase.Price),
            new MySqlParameter("@payment",purchase.PaymentType),
            new MySqlParameter("@pDate", purchase.PurchaseDate)
                };

                List<string> queries = new List<string> { query };
                List<MySqlParameter[]> paramList = new List<MySqlParameter[]> { ps };

                return dbConn.ExecuteTransaction(queries, paramList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddPurchase: {ex.Message}");
                throw;
            }
        }
        public List<DepotPurchaseDetails> GetPurchaseByMerchantId(int merchantId)
        {
            List<DepotPurchaseDetails> purchases = new List<DepotPurchaseDetails>();
            string query = @"SELECT
                    dp.purchaseId,
                    fs.speciesName AS FishName,
                    dp.quantity AS Quantity,
                    dp.buyprice AS Buyprice,
                    dp.totalBuyAmount AS TotalAmount,
                    c.CustomerName,
                    dp.paymentType
                FROM depotpurchases dp
                INNER JOIN fishSpecies fs ON dp.speciesId = fs.speciesId
                INNER JOIN Customers c ON c.customerId = dp.customerId
                WHERE dp.merchantId = @MerchantId
                ORDER BY dp.purchaseDate DESC";

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
                                CustomerName = row["CustomerName"].ToString(),
                                PaymentType = row["PaymentType"].ToString()


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
    
