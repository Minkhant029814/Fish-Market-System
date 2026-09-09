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
    internal class SaleReportRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public List<CustomerSaleReport> GetSalesByCustomerAndPayment(int customerId, string paymentType)
        {
            List<CustomerSaleReport> reports = new List<CustomerSaleReport>();

            if (string.IsNullOrEmpty(paymentType))
            {
                throw new ArgumentException("PaymentType မပါပါ။");
            }

            string query = @"
SELECT 
    m.merchantName AS MerchantName,
    fs.speciesName AS FishName,
    ds.Sellprice AS Price,
    ds.quantity AS Quantity,
    ds.totalsellAmount AS TotalAmount,
    ds.saleDate AS SaleDate
FROM 
    depotsales ds
INNER JOIN 
    depotpurchases dp ON ds.depotId = dp.depotId AND ds.speciesId = dp.speciesId
INNER JOIN 
    merchants m ON dp.merchantId = m.merchantId
INNER JOIN 
    fishspecies fs ON ds.speciesId = fs.speciesId
WHERE 
    ds.customerId = @CustomerId
    AND ds.paymentType = @PaymentType
ORDER BY 
    ds.saleDate DESC";

            MySqlParameter[] ps =
            {
        new MySqlParameter("@CustomerId", customerId),
        new MySqlParameter("@PaymentType", paymentType)
    };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            CustomerSaleReport report = new CustomerSaleReport
                            {
                                MerchantName = row["MerchantName"].ToString(),
                                FishName = row["FishName"].ToString(),
                                Price = Convert.ToDecimal(row["Price"]),
                                Quantity = Convert.ToDecimal(row["Quantity"]),
                                TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                                SaleDate = Convert.ToDateTime(row["SaleDate"])
                            };

                            reports.Add(report);
                        }
                    }
                }

                return reports;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSalesByCustomerAndPayment: {ex.Message}");
                throw new Exception("ဒေတာရယူရာတွင် အမှားအယွင်းဖြစ်ပွားခဲ့သည်။", ex);
            }
        }
       
    }
}
