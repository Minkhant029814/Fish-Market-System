using FishStore.Core.dto.creditPay;
using FishStore.database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FishStore.Core.repository.creditPay
{
    public class CreditSearchRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        // ============================================================
        // ကုန်သည်/ဖောက်သည် နာမည်နဲ့ ရှာခြင်း
        // ============================================================
        public List<CreditSearchResult> SearchCredits(string searchText)
        {
            List<CreditSearchResult> result = new List<CreditSearchResult>();

            string query = @"
        SELECT 
            c.creditId As CreditId,
            m.merchantName AS MerchantName,
            cu.customerName AS CustomerName,
            COUNT(c.creditId) AS TotalRecords,
            
            -- ရိုးရိုးအကြွေး
            COALESCE(SUM(CASE 
                WHEN c.purchaseId IS NOT NULL 
                THEN dp.quantity ELSE 0 END), 0) AS NormalQuantity,
            COALESCE(SUM(CASE 
                WHEN c.purchaseId IS NOT NULL 
                THEN c.totalAmount ELSE 0 END), 0) AS NormalAmount,
            
            -- ဒိုင်ကျန်အကြွေး
            COALESCE(SUM(CASE 
                WHEN c.stockSaleId IS NOT NULL 
                THEN dss.quantity ELSE 0 END), 0) AS StockQuantity,
            COALESCE(SUM(CASE 
                WHEN c.stockSaleId IS NOT NULL 
                THEN c.totalAmount ELSE 0 END), 0) AS StockAmount,
            
            -- အားလုံးပေါင်း
            COALESCE(SUM(CASE 
                WHEN c.purchaseId IS NOT NULL THEN dp.quantity 
                WHEN c.stockSaleId IS NOT NULL THEN dss.quantity 
                ELSE 0 END), 0) AS TotalQuantity,
            COALESCE(SUM(c.totalAmount), 0) AS TotalAmount,
            COALESCE(SUM(c.paidAmount), 0) AS PaidAmount,
            COALESCE(SUM(c.remainingAmount), 0) AS RemainingAmount
            
        FROM credits c
        INNER JOIN merchants m ON c.merchantId = m.merchantId
        INNER JOIN customers cu ON c.customerId = cu.customerId
        LEFT JOIN depotpurchases dp ON c.purchaseId = dp.purchaseId
        LEFT JOIN depot_stock_sales dss ON c.stockSaleId = dss.stockSaleId
        WHERE c.creditType = 'PAYABLE'
            AND (
                @SearchText IS NULL 
                OR @SearchText = ''
                OR m.merchantName COLLATE utf8mb4_unicode_ci LIKE @SearchPattern
                OR cu.customerName COLLATE utf8mb4_unicode_ci LIKE @SearchPattern
            )
        GROUP BY c.creditId, m.merchantId, m.merchantName, 
                 cu.customerId, cu.customerName
        ORDER BY m.merchantName, cu.customerName";

            // Search Pattern ဖန်တီးပါ
            string searchPattern = string.IsNullOrWhiteSpace(searchText)
                ? null
                : $"%{searchText.Trim()}%";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@SearchText",
            string.IsNullOrWhiteSpace(searchText) ? (object)DBNull.Value : searchText.Trim()),
        new MySqlParameter("@SearchPattern",
            searchPattern != null ? (object)searchPattern : DBNull.Value)
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            result.Add(new CreditSearchResult
                            {
                                CreditId = Convert.ToInt32(row["CreditId"]),
                                MerchantName = row["MerchantName"].ToString(),
                                CustomerName = row["CustomerName"].ToString(),
                                TotalRecords = Convert.ToInt32(row["TotalRecords"]),
                                TotalQuantity = Convert.ToDecimal(row["TotalQuantity"]),
                                TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                                PaidAmount = Convert.ToDecimal(row["PaidAmount"]),
                                RemainingAmount = Convert.ToDecimal(row["RemainingAmount"]),
                                NormalCreditAmount = Convert.ToDecimal(row["NormalAmount"]),
                                StockCreditAmount = Convert.ToDecimal(row["StockAmount"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SearchCredits: {ex.Message}");
                throw;
            }

            return result;
        }
    }
}
