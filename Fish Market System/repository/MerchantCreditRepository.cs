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
    internal class MerchantCreditRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public List<MerchantCreditSummary> GetMerchantCreditSummary(int merchantId)
        {
            List<MerchantCreditSummary> result = new List<MerchantCreditSummary>();
            string query = @"
                        SELECT m.merchantName,
                        Count(c.creditId) as TotalRecords,
            COALESCE(SUM(dp.quantity),0) as TotalQuantity,
            COALESCE(SUM(c.totalAmount),0) as TotalAmount,
            COALESCE(SUM(c.paidAmount),0) as PaidAmount,
            COALESCE(SUM(c.remainingAmount),0) as RemainingAmount
            FROM credits c
            INNER JOIN merchants m on c.merchantId = m.merchantId
            LEFT JOIN depotPurchases dp on c.purchaseId = dp.purchaseId
            WHERE c.merchantID = @MerchantId
            AND c.purchaseId is not null
            GROUP By m.merchantId,m.merchantName

            UNION ALL

            SELECT m.merchantName As MerchantName,
            Count(c.creditId) as TotalRecords,
             COALESCE(SUM(dss.quantity), 0) AS TotalQuantity,
                            COALESCE(SUM(c.totalAmount), 0) AS TotalAmount,
                            COALESCE(SUM(c.paidAmount), 0) AS PaidAmount,
                            COALESCE(SUM(c.remainingAmount), 0) AS RemainingAmount
                        FROM credits c
                        INNER JOIN merchants m ON c.merchantId = m.merchantId
                        LEFT JOIN depot_stock_sales dss ON c.stockSaleId = dss.stockSaleId
                        WHERE c.merchantId = @MerchantId
                            AND c.stockSaleId IS NOT NULL
               
                        GROUP BY m.merchantId, m.merchantName";

            MySqlParameter[] ps =
            {
                new MySqlParameter("MerchantId",merchantId)
            };

            try
            {
                using(DataTable dt = dbConn.GetData(query,ps))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            result.Add(
                                new MerchantCreditSummary
                                {
                                    MerchantName = row["merchantName"].ToString(),
                                    TotalRecords = Convert.ToInt32(row["TotalRecords"]),
                                    TotalQuantity = row["TotalQuantity"] != DBNull.Value ? Convert.ToDecimal(row["TotalQuantity"]) : 0,
                                    TotalAmount = row["TotalAmount"] != DBNull.Value
                                ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                                    PaidAmount = row["PaidAmount"] != DBNull.Value
                                ? Convert.ToDecimal(row["PaidAmount"]) : 0,
                                    RemainingAmount = row["RemainingAmount"] != DBNull.Value
                                ? Convert.ToDecimal(row["RemainingAmount"]) : 0
                                }
                             );
                        }
                    }
                }

                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error is GetMerchantCreditSummary :  { ex.Message}");
                throw;
            }


        }

        // ============================================================
        // ၁။ ရိုးရိုးအကြွေး (ဖောက်သည်အလိုက်)
        // ============================================================
        public List<MerchantCreditSummary> GetNormalCreditSummary(int merchantId)
        {
            List<MerchantCreditSummary> result = new List<MerchantCreditSummary>();

            string query = @"
            SELECT 
                m.merchantName AS MerchantName,
                COALESCE(cu.customerName, 'ဖောက်သည်မသတ်မှတ်') AS CustomerName,
                COALESCE(f.speciesName, 'ငါးမသတ်မှတ်') AS FishName,
                'ရိုးရိုးအကြွေး' AS CreditType,
                COUNT(c.creditId) AS TotalRecords,
                COALESCE(SUM(dp.quantity), 0) AS TotalQuantity,
                COALESCE(SUM(c.totalAmount), 0) AS TotalAmount,
                COALESCE(SUM(c.paidAmount), 0) AS PaidAmount,
                COALESCE(SUM(c.remainingAmount), 0) AS RemainingAmount
            FROM credits c
            INNER JOIN merchants m ON c.merchantId = m.merchantId
            INNER JOIN customers cu ON c.customerId = cu.customerId
            LEFT JOIN depotpurchases dp ON c.purchaseId = dp.purchaseId
            LEFT JOIN fishspecies f ON dp.speciesId = f.speciesId
            WHERE c.merchantId = @MerchantId
                AND c.purchaseId IS NOT NULL
                AND c.creditType = 'PAYABLE'
            GROUP BY m.merchantId, m.merchantName, 
                     cu.customerId, cu.customerName, 
                     f.speciesId, f.speciesName
            ORDER BY cu.customerName";

            MySqlParameter[] ps = new MySqlParameter[]
            {
            new MySqlParameter("@MerchantId", merchantId)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(MapRowToSummary(row));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetNormalCreditSummary: {ex.Message}");
                throw;
            }

            return result;
        }

        // ============================================================
        // ၂။ ဒိုင်ကျန်အကြွေး (ဖောက်သည်အလိုက်)
        // ============================================================
        public List<MerchantCreditSummary> GetDepotStockCreditSummary(int merchantId)
        {
            List<MerchantCreditSummary> result = new List<MerchantCreditSummary>();

            string query = @"
            SELECT 
                m.merchantName AS MerchantName,
                COALESCE(cu.customerName, 'ဖောက်သည်မသတ်မှတ်') AS CustomerName,
                COALESCE(f.speciesName, 'ငါးမသတ်မှတ်') AS FishName,
                'ဒိုင်ကျန်အကြွေး' AS CreditType,
                COUNT(c.creditId) AS TotalRecords,
                COALESCE(SUM(dss.quantity), 0) AS TotalQuantity,
                COALESCE(SUM(c.totalAmount), 0) AS TotalAmount,
                COALESCE(SUM(c.paidAmount), 0) AS PaidAmount,
                COALESCE(SUM(c.remainingAmount), 0) AS RemainingAmount
            FROM credits c
            INNER JOIN merchants m ON c.merchantId = m.merchantId
            INNER JOIN customers cu ON c.customerId = cu.customerId
            LEFT JOIN depot_stock_sales dss ON c.stockSaleId = dss.stockSaleId
            LEFT JOIN fishspecies f ON dss.speciesId = f.speciesId
            WHERE c.merchantId = @MerchantId
                AND c.stockSaleId IS NOT NULL
                AND c.creditType = 'PAYABLE'
            GROUP BY m.merchantId, m.merchantName, 
                     cu.customerId, cu.customerName, 
                     f.speciesId, f.speciesName
            ORDER BY cu.customerName";

            MySqlParameter[] ps = new MySqlParameter[]
            {
            new MySqlParameter("@MerchantId", merchantId)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(MapRowToSummary(row));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetDepotStockCreditSummary: {ex.Message}");
                throw;
            }

            return result;
        }

        // ============================================================
        // ၃။ အားလုံးပေါင်း (ရိုးရိုး + ဒိုင်ကျန် + Total Row)
        // ============================================================
        public List<MerchantCreditSummary> GetAllCreditSummary(int merchantId)
        {
            List<MerchantCreditSummary> result = new List<MerchantCreditSummary>();

            // ၁။ ရိုးရိုးအကြွေး
            List<MerchantCreditSummary> normalCredits = GetNormalCreditSummary(merchantId);
            result.AddRange(normalCredits);

            // ၂။ ဒိုင်ကျန်အကြွေး
            List<MerchantCreditSummary> stockCredits = GetDepotStockCreditSummary(merchantId);
            result.AddRange(stockCredits);

            // ၃။ အားလုံးပေါင်း Row ထည့်
            if (result.Count > 0)
            {
                string merchantName = result[0].MerchantName;

                MerchantCreditSummary totalRow = new MerchantCreditSummary
                {
                    MerchantName = merchantName,
                    CustomerName = "-",
                    FishName = "-",
                    CreditType = "အားလုံးပေါင်း",
                    TotalRecords = result.Sum(r => r.TotalRecords),
                    TotalQuantity = result.Sum(r => r.TotalQuantity),
                    TotalAmount = result.Sum(r => r.TotalAmount),
                    PaidAmount = result.Sum(r => r.PaidAmount),
                    RemainingAmount = result.Sum(r => r.RemainingAmount)
                };

                result.Add(totalRow);
            }

            return result;
        }

        private MerchantCreditSummary MapRowToSummary(DataRow row)
        {
            return new MerchantCreditSummary
            {
                MerchantName = row["MerchantName"].ToString(),
                CustomerName = row["CustomerName"]?.ToString() ?? "",
                FishName = row["FishName"]?.ToString() ?? "",
                CreditType = row["CreditType"].ToString(),
                TotalRecords = row["TotalRecords"] != DBNull.Value
                    ? Convert.ToInt32(row["TotalRecords"]) : 0,
                TotalQuantity = row["TotalQuantity"] != DBNull.Value
                    ? Convert.ToDecimal(row["TotalQuantity"]) : 0,
                TotalAmount = row["TotalAmount"] != DBNull.Value
                    ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                PaidAmount = row["PaidAmount"] != DBNull.Value
                    ? Convert.ToDecimal(row["PaidAmount"]) : 0,
                RemainingAmount = row["RemainingAmount"] != DBNull.Value
                    ? Convert.ToDecimal(row["RemainingAmount"]) : 0
            };

            }
        }
}
