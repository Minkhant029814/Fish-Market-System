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
            MySqlConnection conn = null;
            MySqlTransaction transaction = null;

            try
            {
                conn = dbConn.GetConnection();
                conn.Open();
                transaction = conn.BeginTransaction();

                // ၁။ DepotPurchases ထဲထည့်ပါ
                string insertPurchaseQuery = @"INSERT INTO depotpurchases 
                                        (depotId, merchantId, speciesId, quantity, 
                                         buyprice, purchaseDate)
                                        VALUES 
                                        (@dId, @mId, @sId, @q, @price, @pDate);
                                        SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(insertPurchaseQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@dId", purchase.DepotId);
                    cmd.Parameters.AddWithValue("@mId", purchase.MerchantId);
                    cmd.Parameters.AddWithValue("@sId", purchase.SpeciesId);
                    cmd.Parameters.AddWithValue("@q", purchase.Quantity);
                    cmd.Parameters.AddWithValue("@price", purchase.Price);
                    cmd.Parameters.AddWithValue("@pDate", purchase.PurchaseDate);

                    int purchaseId = Convert.ToInt32(cmd.ExecuteScalar());

                    // ၂။ Inventory Transaction ထည့်ပါ (IN)
                    string insertTransactionQuery = @"INSERT INTO inventory_transactions 
                                               (depotId, speciesId, transactionType, 
                                                referenceId, referenceType, quantity, transactionDate)
                                               VALUES 
                                               (@dId, @sId, 'IN', @refId, 'PURCHASE', @q, @pDate)";

                    using (MySqlCommand transCmd = new MySqlCommand(insertTransactionQuery, conn, transaction))
                    {
                        transCmd.Parameters.AddWithValue("@dId", purchase.DepotId);
                        transCmd.Parameters.AddWithValue("@sId", purchase.SpeciesId);
                        transCmd.Parameters.AddWithValue("@q", purchase.Quantity);
                        transCmd.Parameters.AddWithValue("@refId", purchaseId);
                        transCmd.Parameters.AddWithValue("@pDate", purchase.PurchaseDate);
                        transCmd.ExecuteNonQuery();
                    }

                    // ၃။ Current Stock ကို Update လုပ်ပါ (ပေါင်း)
                    string updateStockQuery = @"INSERT INTO current_stock (depotId, speciesId, quantity)
                                        VALUES (@dId, @sId, @q)
                                        ON DUPLICATE KEY UPDATE quantity = quantity + @q";

                    using (MySqlCommand stockCmd = new MySqlCommand(updateStockQuery, conn, transaction))
                    {
                        stockCmd.Parameters.AddWithValue("@dId", purchase.DepotId);
                        stockCmd.Parameters.AddWithValue("@sId", purchase.SpeciesId);
                        stockCmd.Parameters.AddWithValue("@q", purchase.Quantity);
                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine($"Error in AddPurchase: {ex.Message}");
                throw;
            }
            finally
            {
                conn?.Close();
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
                    d.depotName,
                    dp.purchaseDate AS purchaseDate
                FROM depotpurchases dp
                INNER JOIN fishSpecies fs ON dp.speciesId = fs.speciesId
                INNER JOIN Depots d ON d.depotId = dp.depotId
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
                                DepotName = row["depotName"].ToString(),
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
    
