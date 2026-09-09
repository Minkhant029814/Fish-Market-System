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

        public List<MerchantSalesSummary> GetSalesByMerchantId(int merchantId)
        {
            List<MerchantSalesSummary> resultList = new List<MerchantSalesSummary>();
            string query = @"
            SELECT 
                c.customerName AS CustomerName,
                f.speciesName AS FishName,
                s.quantity AS Quantity,
                s.Sellprice AS Amount,
                s.totalsellAmount AS TotalAmount,
                s.paymentType AS PaymentType
            FROM depotpurchases p
            JOIN depotsales s 
                ON p.depotId = s.depotId 
               AND p.speciesId = s.speciesId
            JOIN customers c 
                ON s.customerId = c.customerId
            JOIN fishspecies f 
                ON s.speciesId = f.speciesId
            WHERE p.merchantId = @MerchantId;";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@MerchantId",merchantId)
            };
            try
            {
                using(DataTable dt = dbConn.GetData(query, ps))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            MerchantSalesSummary list = new MerchantSalesSummary
                            {
                                CustomerName = row["CustomerName"].ToString(),
                                FishName = row["FishName"].ToString(),
                                Quantity = Convert.ToDecimal(row["Quantity"]),
                                Amount = Convert.ToDecimal(row["Amount"]),
                                TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                                PaymentType = row["PaymentType"].ToString()
                            };

                            resultList.Add(list);
                        }
                    }
                }

                return resultList;

            }
            catch (Exception)
            {


                throw new Exception("Something went wrong to fetch data");
            }
        }
    }
}
