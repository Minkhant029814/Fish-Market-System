using Fish_Market_System.database;
using Fish_Market_System.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.repository
{
    internal class PurchaseReportRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public List<PurchaseReport> GetPurchasesByDateRange(DateTime startDate,DateTime endDate)
        {
            List<PurchaseReport> reports = new List<PurchaseReport>();

            string query = @" 

            SELECT 
                    m.merchantName,
                    fs.speciesName,
                    dp.buyprice ,
                    dp.quantity,
                    dp.TotalBuyAmount,
                    dp.purchaseDate 

                    from 
                    depotpurchases dp
                    Inner join
                    merchants m on dp.merchantId = m.merchantId
                    inner join
                    fishspecies fs on dp.speciesId = fs.speciesId
                    where 
                    dp.purchaseDate Between @StartDate AND @EndDate
                    Order by
                    dp.purchaseDate DESC ";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@StartDate",startDate),
                new MySqlParameter("@EndDate",endDate)
            };

            try
            {
                using(DataTable dt  = dbConn.GetData(query, ps))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            PurchaseReport report = new PurchaseReport
                            {
                                MerchantName = row["merchantName"].ToString(),
                                FishName = row["speciesName"].ToString(),
                                Price = Convert.ToDecimal(row["buyPrice"]),
                                Quantity = Convert.ToDecimal(row["quantity"]),
                                TotalAmount = Convert.ToDecimal(row["TotalBuyAmount"]),
                                PurchaseDate = Convert.ToDateTime(row["purchaseDate"])
                            };
                            reports.Add(report);
                        }
                    }
                }
                return reports;

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in GetPurchasesByDateRange :  { ex.Message}");
                throw;
            }
        }

        //Filter with Merchants

        public List<PurchaseReport> GetPurchasesByMerchantAndDateRange(int merchantId, DateTime startDate, DateTime endDate)
        {
            List<PurchaseReport> reports = new List<PurchaseReport>();

            string query = @"
                SELECT 
                    m.merchantName AS MerchantName,
                    fs.speciesName AS FishName,
                    dp.buyprice AS Price,
                    dp.quantity AS Quantity,
                    dp.TotalBuyAmount AS TotalAmount,
                    dp.purchaseDate AS PurchaseDate
                FROM 
                    depotPurchases dp
                INNER JOIN 
                    merchants m ON dp.merchantId = m.merchantId
                INNER JOIN 
                    fishspecies fs ON dp.speciesId = fs.speciesId
                WHERE 
                    dp.merchantId = @MerchantId
                    AND dp.purchaseDate BETWEEN @StartDate AND @EndDate
                ORDER BY 
                    dp.purchaseDate DESC";

            MySqlParameter[] ps = new MySqlParameter[]
            {
                new MySqlParameter("@MerchantId", merchantId),
                new MySqlParameter("@StartDate", startDate),
                new MySqlParameter("@EndDate", endDate)
            };

            try
            {
                DataTable dt = dbConn.GetData(query, ps);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        PurchaseReport report = new PurchaseReport
                        {
                            MerchantName = row["MerchantName"]?.ToString() ?? "",
                            FishName = row["FishName"]?.ToString() ?? "",
                            Price = row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0,
                            Quantity = row["Quantity"] != DBNull.Value ? Convert.ToDecimal(row["Quantity"]) : 0,
                            TotalAmount = row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                            PurchaseDate = row["PurchaseDate"] != DBNull.Value ? Convert.ToDateTime(row["PurchaseDate"]) : DateTime.Now
                        };
                        reports.Add(report);
                    }
                }

                return reports;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetPurchasesByMerchantAndDateRange: {ex.Message}");
                throw;
            }
        }
    }
}
