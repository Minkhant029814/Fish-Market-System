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
                // ၁။ Stock စစ်ဆေးပါ
                if (!CheckStockAvailability(sale.DepotId, sale.SpeciesId, sale.Quantity))
                {
                    decimal available = GetAvailableStock(sale.DepotId, sale.SpeciesId);
                    throw new Exception($"Stock မလုံလောက်ပါ။ ရှိသော ပမာဏ: {available:N2}, လိုအပ်သော ပမာဏ: {sale.Quantity:N2}");
                }

                // ၂။ PaymentType ကို သေချာစစ်ပါ
                string paymentType = sale.PaymentType?.ToUpper() ?? "CASH";

                // ENUM မှာ ပါတဲ့တန်ဖိုးတွေပဲဖြစ်ရမယ်
                if (paymentType != "CASH" && paymentType != "CREDIT" && paymentType != "DELI")
                {
                    paymentType = "CASH"; // Default
                }

                // ၃။ Insert Query
                string insertSaleQuery = @"INSERT INTO depotsales 
                                    (depotId, customerId, speciesId, quantity, 
                                     sellprice, saleDate, paymentType)
                                    VALUES 
                                    (@dId, @Cid, @sId, @q, @sell, @Sdate, @pay)";

                string updateStockQuery = @"UPDATE depotpurchases 
                                    SET quantity = quantity - @q 
                                    WHERE depotId = @dId 
                                    AND speciesId = @sId 
                                    AND quantity >= @q
                                    ORDER BY purchaseDate ASC 
                                    LIMIT 1";

                // ၄။ Parameters
                MySqlParameter[] insertParams = new MySqlParameter[]
                {
            new MySqlParameter("@dId", sale.DepotId),
            new MySqlParameter("@Cid", sale.CustomerId),
            new MySqlParameter("@sId", sale.SpeciesId),
            new MySqlParameter("@q", sale.Quantity),
            new MySqlParameter("@sell", sale.SellPrice),
            new MySqlParameter("@Sdate", sale.SaleDate),
            new MySqlParameter("@pay", paymentType) // String အတိုင်း
                };

                MySqlParameter[] updateParams = new MySqlParameter[]
                {
            new MySqlParameter("@dId", sale.DepotId),
            new MySqlParameter("@sId", sale.SpeciesId),
            new MySqlParameter("@q", sale.Quantity)
                };

                // ၅။ Transaction
                List<string> queries = new List<string> { insertSaleQuery, updateStockQuery };
                List<MySqlParameter[]> paramList = new List<MySqlParameter[]> { insertParams, updateParams };

                return dbConn.ExecuteTransaction(queries, paramList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddSale: {ex.Message}");
                throw;
            }
        }
        // Stock စစ်ဆေးမယ်
        private bool CheckStockAvailability(int depotId, int speciesId, decimal quantity)
        {
            decimal available = GetAvailableStock(depotId, speciesId);
            return available >= quantity;
        }

        // ရှိသော Stock ပမာဏကို ယူမယ်
        private decimal GetAvailableStock(int depotId, int speciesId)
        {
            string query = @"SELECT COALESCE(SUM(quantity), 0) AS TotalQuantity 
                             FROM depotpurchases 
                             WHERE depotId = @dId 
                             AND speciesId = @sId 
                             AND quantity > 0";

            MySqlParameter[] ps = new MySqlParameter[]
            {
                new MySqlParameter("@dId", depotId),
                new MySqlParameter("@sId", speciesId)
            };

            DataTable dt = dbConn.GetData(query, ps);

            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalQuantity"] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0]["TotalQuantity"]);
            }

            return 0;
        }


        public DepotStock GetDepotStockById(int depotId)
        {
            string query = @"SELECT 
                                d.depotId,
                                d.depotname,
                                COALESCE(SUM(dp.quantity), 0) AS TotalQuantity
                            FROM 
                                depots d
                            LEFT JOIN 
                                depotpurchases dp ON d.depotId = dp.depotId
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
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            return null;
        }


        public List<DepotFish> GetFishByDepot(int depotId)
        {
            try
            {
                string query = @"select fs.speciesId, fs.speciesName,Sum(dp.quantity) as total_quantity from depotpurchases dp join fishspecies fs on dp.speciesId = fs.speciesId 
where dp.depotId = @depotId group by fs.speciesId,fs.speciesName order by fs.speciesName;";

                MySqlParameter[] ps =
                {
                    new MySqlParameter("@depotId",depotId)
                };

                List<DepotFish> fishes = new List<DepotFish>();
                using(DataTable dt = dbConn.GetData(query, ps))
                {
                    if(dt.Rows != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
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
            catch (Exception e)
            {
                Console.WriteLine("error is " + e.Message);

                throw;
            }
        }

    }
}