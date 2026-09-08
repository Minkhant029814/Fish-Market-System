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

            // PaymentType ကို စစ်ဆေးပါ
            if (string.IsNullOrEmpty(paymentType))
            {
                throw new ArgumentException("PaymentType မပါပါ။");
            }

            string query = @"
        SELECT 
            d.depotname AS DepotName,
            fs.speciesName AS FishName,
            ds.Sellprice AS Price,
            ds.quantity AS Quantity,
            ds.totalsellAmount AS TotalAmount,
            ds.saleDate AS SaleDate
        FROM 
            depotsales ds
        INNER JOIN 
            depots d ON ds.depotId = d.depotId
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
                            reports.Add(MapDataRowToReport(row));
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

        private CustomerSaleReport MapDataRowToReport(DataRow row)
        {
            return new CustomerSaleReport
            {
                DepotName = row["DepotName"]?.ToString() ?? "",
                FishName = row["FishName"]?.ToString() ?? "",
                Price = GetDecimalValue(row, "Price"),
                Quantity = GetDecimalValue(row, "Quantity"),
                TotalAmount = GetDecimalValue(row, "TotalAmount"),
                SaleDate = GetDateTimeValue(row, "SaleDate")
            };
        }

        private decimal GetDecimalValue(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToDecimal(row[columnName]) : 0;
        }

        private DateTime GetDateTimeValue(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToDateTime(row[columnName]) : DateTime.Now;
        }
    }
}
