using Fish_Market_System.database;
using Fish_Market_System.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Fish_Market_System.Repositories
{
    internal class DepotSaleRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public bool AddSale(DepotSale sale)
        {
            MySqlConnection conn = null;
            MySqlTransaction transaction = null;

            try
            {
                // ၁။ Stock စစ်ဆေးပါ (Current Stock ကနေ)
                if (!CheckStockAvailability(sale.DepotId, sale.SpeciesId, sale.Quantity))
                {
                    decimal available = GetAvailableStock(sale.DepotId, sale.SpeciesId);
                    throw new Exception($"Stock မလုံလောက်ပါ။ ရှိသော ပမာဏ: {available:N2}, လိုအပ်သော ပမာဏ: {sale.Quantity:N2}");
                }

                // ၂။ PaymentType ပြောင်းပါ
                string paymentType = sale.PaymentType?.ToUpper() ?? "CASH";
                string dbPaymentType;
                switch (paymentType)
                {
                    case "CASH": dbPaymentType = "cash"; break;
                    case "CREDIT": dbPaymentType = "credit"; break;
                    case "DELI":
                    case "DELIVERY": dbPaymentType = "deli"; break;
                    default: dbPaymentType = "cash"; break;
                }

                // ၃။ Connection နဲ့ Transaction စတင်ပါ
                conn = dbConn.GetConnection();
                conn.Open();
                transaction = conn.BeginTransaction();

                // =========================================================
                // ၄။ DepotSales ထဲထည့်ပြီး SaleId ကိုပြန်ရယူပါ
                // =========================================================
                string insertSaleQuery = @"
            INSERT INTO depotsales 
                (depotId, customerId, speciesId, quantity, sellprice, saleDate, paymentType)
            VALUES 
                (@dId, @Cid, @sId, @q, @sell, @Sdate, @pay);
            SELECT LAST_INSERT_ID();";

                int saleId;
                using (MySqlCommand cmd = new MySqlCommand(insertSaleQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@dId", sale.DepotId);
                    cmd.Parameters.AddWithValue("@Cid", sale.CustomerId);
                    cmd.Parameters.AddWithValue("@sId", sale.SpeciesId);
                    cmd.Parameters.AddWithValue("@q", sale.Quantity);
                    cmd.Parameters.AddWithValue("@sell", sale.SellPrice);
                    cmd.Parameters.AddWithValue("@Sdate", sale.SaleDate);
                    cmd.Parameters.AddWithValue("@pay", dbPaymentType);

                    saleId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // =========================================================
                // ၅။ Inventory Transactions ထဲထည့် (SaleId ကိုသုံးပါ)
                // =========================================================
                string insertTransactionQuery = @"
            INSERT INTO inventory_transactions 
                (depotId, speciesId, transactionType, referenceId, referenceType, quantity, transactionDate)
            VALUES 
                (@dId, @sId, 'OUT', @refId, 'SALE', @q, @Sdate)";

                using (MySqlCommand cmd = new MySqlCommand(insertTransactionQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@dId", sale.DepotId);
                    cmd.Parameters.AddWithValue("@sId", sale.SpeciesId);
                    cmd.Parameters.AddWithValue("@q", sale.Quantity);
                    cmd.Parameters.AddWithValue("@refId", saleId);
                    cmd.Parameters.AddWithValue("@Sdate", sale.SaleDate);
                    cmd.ExecuteNonQuery();
                }

                // =========================================================
                // ၆။ Current Stock ကို Update လုပ်ပါ
                // =========================================================
                string updateStockQuery = @"
            UPDATE current_stock 
            SET quantity = quantity - @q 
            WHERE depotId = @dId 
            AND speciesId = @sId";

                using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@dId", sale.DepotId);
                    cmd.Parameters.AddWithValue("@sId", sale.SpeciesId);
                    cmd.Parameters.AddWithValue("@q", sale.Quantity);
                    cmd.ExecuteNonQuery();
                }

                // =========================================================
                // ၇။ အကုန်အောင်မြင်ရင် Commit
                // =========================================================
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine($"Error in AddSale: {ex.Message}");
                throw;
            }
            finally
            {
                conn?.Close();
            }
        }
        private decimal GetAvailableStock(int depotId, int speciesId)
        {
            string query = @"SELECT quantity 
                     FROM current_stock 
                     WHERE depotId = @dId 
                     AND speciesId = @sId";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@dId", depotId),
        new MySqlParameter("@sId", speciesId)
            };

            DataTable dt = dbConn.GetData(query, ps);

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["quantity"] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0]["quantity"]);
            }

            return 0;
        }

        private bool CheckStockAvailability(int depotId, int speciesId, decimal quantity)
        {
            decimal available = GetAvailableStock(depotId, speciesId);
            return available >= quantity;
        }
        public DepotStock GetDepotStockById(int depotId)
        {
            string query = @"SELECT 
                        d.depotId,
                        d.depotname,
                        COALESCE(SUM(cs.quantity), 0) AS TotalQuantity
                    FROM 
                        depots d
                    LEFT JOIN 
                        current_stock cs ON d.depotId = cs.depotId
                    WHERE 
                        d.depotId = @DepotId
                    GROUP BY 
                        d.depotId, d.depotname";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@DepotId", depotId)
            };

            try
            {
                DataTable dt = dbConn.GetData(query, ps);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DepotStock
                    {
                        DepotId = Convert.ToInt32(row["depotId"]),
                        DepotName = row["depotname"].ToString(),
                        TotalQuantity = Convert.ToDecimal(row["TotalQuantity"])
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetDepotStockById: {ex.Message}");
                throw;
            }

            return null;
        }
        public List<DepotFish> GetFishByDepot(int depotId)
        {
            try
            {
                string query = @"
            SELECT 
                fs.speciesId,
                fs.speciesName,
                COALESCE(cs.quantity, 0) AS total_quantity
            FROM 
                fishspecies fs
            LEFT JOIN 
                current_stock cs ON fs.speciesId = cs.speciesId AND cs.depotId = @depotId
            WHERE 
                cs.quantity > 0 OR cs.quantity IS NULL
            ORDER BY 
                fs.speciesName";

                MySqlParameter[] ps = new MySqlParameter[]
                {
            new MySqlParameter("@depotId", depotId)
                };

                List<DepotFish> fishes = new List<DepotFish>();

                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            decimal quantity = row["total_quantity"] != DBNull.Value
                                ? Convert.ToDecimal(row["total_quantity"])
                                : 0;

                            // quantity 0 ထက်ကြီးမှပဲထည့်ပါ (သို့) အကုန်ထည့်ချင်ရင် ဒီအတိုင်းထားပါ
                            if (quantity > 0)
                            {
                                DepotFish fish = new DepotFish
                                {
                                    FishId = Convert.ToInt32(row["speciesId"]),
                                    FishName = row["speciesName"].ToString(),
                                    TotalQuantity = quantity
                                };
                                fishes.Add(fish);
                            }
                        }
                    }
                }

                return fishes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetFishByDepot: {ex.Message}");
                throw;
            }
        }
    }
}