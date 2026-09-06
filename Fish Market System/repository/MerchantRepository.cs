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
    }
}
