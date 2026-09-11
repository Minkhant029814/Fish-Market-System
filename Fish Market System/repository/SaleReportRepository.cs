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

            // PaymentType ကို Database ENUM နဲ့ကိုက်ညီအောင် ပြောင်းပါ
            string type = paymentType.ToUpper();
            string dbPaymentType;

            if (type == "CASH")
                dbPaymentType = "cash";
            else if (type == "CREDIT")
                dbPaymentType = "credit";
            else if (type == "DELI" || type == "DELIVERY")
                dbPaymentType = "deli";
            else
                dbPaymentType = "cash";

            // depotPurchases တစ်ခုတည်းကနေ တိုက်ရိုက်ထုတ်
            string query = @"
        SELECT 
            m.merchantName AS MerchantName,
            fs.speciesName AS FishName,
            dp.buyprice AS Price,
            dp.quantity AS Quantity,
            dp.TotalBuyAmount AS TotalAmount,
            dp.purchaseDate AS SaleDate
        FROM 
            depotpurchases dp
        INNER JOIN 
            merchants m ON dp.merchantId = m.merchantId
        INNER JOIN 
            fishspecies fs ON dp.speciesId = fs.speciesId
        WHERE 
            dp.customerId = @CustomerId
            AND dp.paymentType = @PaymentType
        ORDER BY 
            dp.purchaseDate DESC";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@CustomerId", customerId),
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
                            CustomerSaleReport report = new CustomerSaleReport
                            {
                                MerchantName = row["MerchantName"]?.ToString() ?? "",
                                FishName = row["FishName"]?.ToString() ?? "",
                                Price = row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0,
                                Quantity = row["Quantity"] != DBNull.Value ? Convert.ToDecimal(row["Quantity"]) : 0,
                                TotalAmount = row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                                SaleDate = row["SaleDate"] != DBNull.Value ? Convert.ToDateTime(row["SaleDate"]) : DateTime.Now
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
