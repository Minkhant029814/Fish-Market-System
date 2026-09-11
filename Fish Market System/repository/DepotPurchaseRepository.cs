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

                // =========================================================
                // ၁။ PaymentType ပြောင်းပါ
                // =========================================================
                string paymentType = purchase.PaymentType?.ToUpper() ?? "CASH";
                string dbPaymentType;
                switch (paymentType)
                {
                    case "CASH": dbPaymentType = "cash"; break;
                    case "CREDIT": dbPaymentType = "credit"; break;
                    case "DELI":
                    case "DELIVERY": dbPaymentType = "deli"; break;
                    default: dbPaymentType = "cash"; break;
                }

                // =========================================================
                // ၂။ DepotPurchases ထဲထည့်ပြီး PurchaseId ကိုရယူပါ
                // =========================================================
                string insertPurchaseQuery = @"
            INSERT INTO depotpurchases 
                (depotId, merchantId, customerId, speciesId, quantity, buyprice, purchaseDate, paymentType)
            VALUES 
                (@dId, @mId, @Cid, @sId, @q, @price, @pDate, @pay);
            SELECT LAST_INSERT_ID();";

                int purchaseId;
                using (MySqlCommand cmd = new MySqlCommand(insertPurchaseQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@dId", purchase.DepotId);
                    cmd.Parameters.AddWithValue("@mId", purchase.MerchantId);
                    cmd.Parameters.AddWithValue("@Cid", purchase.CustomerId);
                    cmd.Parameters.AddWithValue("@sId", purchase.SpeciesId);
                    cmd.Parameters.AddWithValue("@q", purchase.Quantity);
                    cmd.Parameters.AddWithValue("@price", purchase.Price);
                    cmd.Parameters.AddWithValue("@pDate", purchase.PurchaseDate);
                    cmd.Parameters.AddWithValue("@pay", dbPaymentType);

                    purchaseId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // =========================================================
                // ၃။ အကြွေးဆိုရင် credits ဇယားထဲထည့်ပါ
                // =========================================================
                if (dbPaymentType == "credit")
                {
                    string insertCreditQuery = @"
                INSERT INTO credits 
                    (purchaseId,customerId, merchantId, creditType, totalAmount, creditDate, status)
                VALUES 
                    (@pId,@cId, @mId, 'PAYABLE', @total, @cDate, 'unpaid')";

                    using (MySqlCommand cmd = new MySqlCommand(insertCreditQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@pId", purchaseId);
                        cmd.Parameters.AddWithValue("@mId", purchase.MerchantId);
                        cmd.Parameters.AddWithValue("@cId", purchase.CustomerId);
                        cmd.Parameters.AddWithValue("@total", purchase.Quantity * purchase.Price);
                        cmd.Parameters.AddWithValue("@cDate", purchase.PurchaseDate);
                        cmd.ExecuteNonQuery();
                    }
                }

                // =========================================================
                // ၄။ Commit
                // =========================================================
                transaction.Commit();
                return true;
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
    
