using Fish_Market_System.database;
using Fish_Market_System.dto;
using Fish_Market_System.dto.dailyRepot;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.repository
{
    internal class MerchantDayReportRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        // ============================================================
        // ၁။ ရက်စွဲအလိုက် ကုန်သည်တစ်ယောက်ချင်းစီရဲ့ Summary
        // ============================================================
        public List<MerchantDaySummary> GetMerchantSummaryByDate(DateTime date)
        {
            List<MerchantDaySummary> result = new List<MerchantDaySummary>();

            string query = @"
            SELECT 
                m.merchantId,
                m.merchantName,
                COALESCE(SUM(CASE WHEN dp.paymentType = 'cash' THEN dp.quantity ELSE 0 END), 0) AS CashQuantity,
                COALESCE(SUM(CASE WHEN dp.paymentType = 'cash' THEN dp.TotalBuyAmount ELSE 0 END), 0) AS CashAmount,
                COALESCE(SUM(CASE WHEN dp.paymentType = 'credit' THEN dp.quantity ELSE 0 END), 0) AS CreditQuantity,
                COALESCE(SUM(CASE WHEN dp.paymentType = 'credit' THEN dp.TotalBuyAmount ELSE 0 END), 0) AS CreditAmount
            FROM depotpurchases dp
            INNER JOIN merchants m ON dp.merchantId = m.merchantId
            WHERE dp.purchaseDate = @PurchaseDate
            GROUP BY m.merchantId, m.merchantName
            ORDER BY m.merchantName";

            MySqlParameter[] ps = new MySqlParameter[]
            {
            new MySqlParameter("@PurchaseDate", date.Date)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(new MerchantDaySummary
                            {
                                MerchantId = Convert.ToInt32(row["merchantId"]),
                                MerchantName = row["merchantName"].ToString(),
                                CashQuantity = row["CashQuantity"] != DBNull.Value ? Convert.ToDecimal(row["CashQuantity"]) : 0,
                                CashAmount = row["CashAmount"] != DBNull.Value ? Convert.ToDecimal(row["CashAmount"]) : 0,
                                CreditQuantity = row["CreditQuantity"] != DBNull.Value ? Convert.ToDecimal(row["CreditQuantity"]) : 0,
                                CreditAmount = row["CreditAmount"] != DBNull.Value ? Convert.ToDecimal(row["CreditAmount"]) : 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetMerchantSummaryByDate: {ex.Message}");
                throw;
            }

            return result;
        }

        // ============================================================
        // ၂။ ကုန်သည်တစ်ယောက်ရဲ့ ရက်စွဲအလိုက် အသေးစိတ်
        // ============================================================
        public List<PurchaseDetail> GetPurchaseDetails(int merchantId, DateTime date)
        {
            List<PurchaseDetail> result = new List<PurchaseDetail>();

            string query = @"
            SELECT 
                dp.purchaseId,
                COALESCE(c.customerName, 'ဖောက်သည်မသတ်မှတ်') AS CustomerName,
                f.speciesName AS FishName,
                dp.quantity AS Quantity,
                dp.buyprice AS Price,
                dp.TotalBuyAmount AS TotalAmount,
                dp.paymentType AS PaymentType,
                dp.purchaseDate AS PurchaseDate
            FROM depotpurchases dp
            LEFT JOIN customers c ON dp.customerId = c.customerId
            INNER JOIN fishspecies f ON dp.speciesId = f.speciesId
            WHERE dp.merchantId = @MerchantId
                AND dp.purchaseDate = @PurchaseDate
            ORDER BY dp.purchaseId DESC";

            MySqlParameter[] ps = new MySqlParameter[]
            {
            new MySqlParameter("@MerchantId", merchantId),
            new MySqlParameter("@PurchaseDate", date.Date)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(new PurchaseDetail
                            {
                                PurchaseId = Convert.ToInt32(row["purchaseId"]),
                                CustomerName = row["CustomerName"].ToString(),
                                FishName = row["FishName"].ToString(),
                                Quantity = row["Quantity"] != DBNull.Value ? Convert.ToDecimal(row["Quantity"]) : 0,
                                Price = row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0,
                                TotalAmount = row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                                PaymentType = row["PaymentType"]?.ToString() ?? "cash",
                                PurchaseDate = row["PurchaseDate"] != DBNull.Value ? Convert.ToDateTime(row["PurchaseDate"]) : DateTime.Now
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetPurchaseDetails: {ex.Message}");
                throw;
            }

            return result;
        }

        // ============================================================
        // ၃။ PaymentType အလိုက် Filter လုပ်ချင်ရင် (Optional)
        // ============================================================
        public List<PurchaseDetail> GetPurchaseDetailsByPayment(int merchantId, DateTime date, string paymentType)
        {
            List<PurchaseDetail> result = new List<PurchaseDetail>();

            string query = @"
            SELECT 
                dp.purchaseId,
                COALESCE(c.customerName, 'ဖောက်သည်မသတ်မှတ်') AS CustomerName,
                f.speciesName AS FishName,
                dp.quantity AS Quantity,
                dp.buyprice AS Price,
                dp.TotalBuyAmount AS TotalAmount,
                dp.paymentType AS PaymentType,
                dp.purchaseDate AS PurchaseDate
            FROM depotpurchases dp
            LEFT JOIN customers c ON dp.customerId = c.customerId
            INNER JOIN fishspecies f ON dp.speciesId = f.speciesId
            WHERE dp.merchantId = @MerchantId
                AND dp.purchaseDate = @PurchaseDate
                AND dp.paymentType = @PaymentType
            ORDER BY dp.purchaseId DESC";

            string dbPaymentType = paymentType.ToLower();

            MySqlParameter[] ps = new MySqlParameter[]
            {
            new MySqlParameter("@MerchantId", merchantId),
            new MySqlParameter("@PurchaseDate", date.Date),
            new MySqlParameter("@PaymentType", dbPaymentType)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(new PurchaseDetail
                            {
                                PurchaseId = Convert.ToInt32(row["purchaseId"]),
                                CustomerName = row["CustomerName"].ToString(),
                                FishName = row["FishName"].ToString(),
                                Quantity = row["Quantity"] != DBNull.Value ? Convert.ToDecimal(row["Quantity"]) : 0,
                                Price = row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0,
                                TotalAmount = row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                                PaymentType = row["PaymentType"]?.ToString() ?? "cash",
                                PurchaseDate = row["PurchaseDate"] != DBNull.Value ? Convert.ToDateTime(row["PurchaseDate"]) : DateTime.Now
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetPurchaseDetailsByPayment: {ex.Message}");
                throw;
            }

            return result;
        }
    }
}
