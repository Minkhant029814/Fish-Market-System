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
    internal class MerchantRepository
    {

        private readonly DBConnect dbConn = new DBConnect();

        public bool AddMerchant(Merchant m)
        {

            string query = @"INSERT INTO merchants  (merchantName) values (@name)  ";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@name",m.MerchantName)
            };

            return dbConn.ExecuteCommand(query, ps);
        }


        public List<Merchant> GetAll()
        {
            List<Merchant> merchants = new List<Merchant>();
            string query = "select merchantId,merchantname from merchants";

            DataTable dt = dbConn.GetData(query, null);
            
            foreach(DataRow row in dt.Rows)
            {
                Merchant m = new Merchant
                {
                    MerchantId = Convert.ToInt32(row["merchantId"]),
                    MerchantName = row["merchantName"].ToString()
                };
                merchants.Add(m);

            }
            return merchants;
        }

        public List<MerchantSalesSummary> GetSalesByMerchantIdAndDate(
     int merchantId,
     DateTime startDate
     )
        {
            List<MerchantSalesSummary> resultList = new List<MerchantSalesSummary>();

            string query = @"
        SELECT 
            c.customerName AS CustomerName,
            f.speciesName AS FishName,
            dp.quantity AS Quantity,
            dp.buyprice AS Amount,
            dp.TotalBuyAmount AS TotalAmount,
            dp.paymentType AS PaymentType,
            dp.purchaseDate AS PurchaseDate
        FROM depotpurchases dp
        INNER JOIN customers c ON dp.customerId = c.customerId
        INNER JOIN fishspecies f ON dp.speciesId = f.speciesId
        WHERE dp.merchantId = @MerchantId
            AND dp.purchaseDate = @StartDate 
        ORDER BY dp.purchaseDate DESC";

            MySqlParameter[] ps = new MySqlParameter[]
            {
        new MySqlParameter("@MerchantId", merchantId),
        new MySqlParameter("@StartDate", startDate),
       
            };

            try
            {
                using (DataTable dt = dbConn.GetData(query, ps))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            MerchantSalesSummary summary = new MerchantSalesSummary
                            {
                                CustomerName = row["CustomerName"]?.ToString() ?? "",
                                FishName = row["FishName"]?.ToString() ?? "",
                                Quantity = row["Quantity"] != DBNull.Value ? Convert.ToDecimal(row["Quantity"]) : 0,
                                Amount = row["Amount"] != DBNull.Value ? Convert.ToDecimal(row["Amount"]) : 0,
                                TotalAmount = row["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(row["TotalAmount"]) : 0,
                                PaymentType = row["PaymentType"]?.ToString() ?? "cash",
                                //PurchaseDate = row["PurchaseDate"] != DBNull.Value ? Convert.ToDateTime(row["PurchaseDate"]) : DateTime.Now
                            };

                            resultList.Add(summary);
                        }
                    }
                }

                return resultList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSalesByMerchantIdAndDate: {ex.Message}");
                throw new Exception("ဒေတာရယူရာတွင် အမှားအယွင်းဖြစ်ပွားခဲ့သည်။", ex);
            }
        }
    }
}
