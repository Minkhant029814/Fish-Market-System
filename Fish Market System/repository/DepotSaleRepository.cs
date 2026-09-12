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
            try
            {
                // ၁။ Stock စစ်ဆေးပါ (depotpurchases - depotsales ကနေ)
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

                // ၃။ Query တစ်ခုတည်း (merchantId ပါ)
                string query = @"
            INSERT INTO depotsales 
                (depotId, customerId, merchantId, speciesId, quantity, sellprice, saleDate, paymentType)
            VALUES 
                (@dId, @Cid, @mId, @sId, @q, @sell, @Sdate, @pay)";

                MySqlParameter[] ps = new MySqlParameter[]
                {
            new MySqlParameter("@dId", sale.DepotId),
            new MySqlParameter("@Cid", sale.CustomerId),
            new MySqlParameter("@mId", sale.MerchantId),
            new MySqlParameter("@sId", sale.SpeciesId),
            new MySqlParameter("@q", sale.Quantity),
            new MySqlParameter("@sell", sale.SellPrice),
            new MySqlParameter("@Sdate", sale.SaleDate),
            new MySqlParameter("@pay", dbPaymentType)
                };

                // ၄။ Execute လုပ်ပါ
                List<string> queries = new List<string> { query };
                List<MySqlParameter[]> paramList = new List<MySqlParameter[]> { ps };

                return dbConn.ExecuteTransaction(queries, paramList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddSale: {ex.Message}");
                throw;
            }
        }

        private decimal GetAvailableStock(int depotId, int speciesId)
        {
            string query = @"
        SELECT 
            COALESCE(
                (SELECT SUM(quantity) FROM depotpurchases 
                 WHERE depotId = @dId AND speciesId = @sId), 0
            ) - COALESCE(
                (SELECT SUM(quantity) FROM depotsales 
                 WHERE depotId = @dId AND speciesId = @sId), 0
            ) AS Stock";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@dId", depotId),
        new MySqlParameter("@sId", speciesId)
            };

            try
            {
                DataTable dt = dbConn.GetData(query, ps);

                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["Stock"] != DBNull.Value)
                {
                    return Convert.ToDecimal(dt.Rows[0]["Stock"]);
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAvailableStock: {ex.Message}");
                throw;
            }
        }

        private bool CheckStockAvailability(int depotId, int speciesId, decimal quantity)
        {
            decimal available = GetAvailableStock(depotId, speciesId);
            return available >= quantity;
        }
        public DepotStock GetDepotStockById(int depotId)
        {
            string query = @"
        SELECT 
            d.depotId,
            d.depotname,
            COALESCE(
                (SELECT SUM(quantity) FROM depotpurchases WHERE depotId = d.depotId), 0
            ) - COALESCE(
                (SELECT SUM(quantity) FROM depotsales WHERE depotId = d.depotId), 0
            ) AS TotalQuantity
        FROM 
            depots d
        WHERE 
            d.depotId = @DepotId";

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
                COALESCE(
                    (SELECT SUM(quantity) FROM depotpurchases 
                     WHERE depotId = @depotId AND speciesId = fs.speciesId), 0
                ) - COALESCE(
                    (SELECT SUM(quantity) FROM depotsales 
                     WHERE depotId = @depotId AND speciesId = fs.speciesId), 0
                ) AS total_quantity
            FROM 
                fishspecies fs
            HAVING 
                total_quantity > 0
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
                            DepotFish fish = new DepotFish
                            {
                                FishId = Convert.ToInt32(row["speciesId"]),
                                FishName = row["speciesName"].ToString(),
                                TotalQuantity = Convert.ToDecimal(row["total_quantity"])
                            };
                            fishes.Add(fish);
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

        public List<DepotFish> GetStockByMerchant(int depotId, int merchantId)
        {
            try
            {
                string query = @"
            SELECT 
                fs.speciesId,
                fs.speciesName,
                COALESCE(
                    (SELECT SUM(quantity) FROM depotpurchases 
                     WHERE depotId = @dId AND speciesId = fs.speciesId AND merchantId = @mId), 0
                ) - COALESCE(
                    (SELECT SUM(quantity) FROM depotsales 
                     WHERE depotId = @dId AND speciesId = fs.speciesId AND merchantId = @mId), 0
                ) AS total_quantity
            FROM 
                fishspecies fs
            HAVING 
                total_quantity > 0
            ORDER BY 
                fs.speciesName";

                MySqlParameter[] ps = new MySqlParameter[]
                {
            new MySqlParameter("@dId", depotId),
            new MySqlParameter("@mId", merchantId)
                };

                List<DepotFish> fishes = new List<DepotFish>();

                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DepotFish fish = new DepotFish
                            {
                                FishId = Convert.ToInt32(row["speciesId"]),
                                FishName = row["speciesName"].ToString(),
                                TotalQuantity = Convert.ToDecimal(row["total_quantity"])
                            };
                            fishes.Add(fish);
                        }
                    }
                }

                return fishes;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetStockByMerchant: {ex.Message}");
                throw;
            }
        }


        
    }
}