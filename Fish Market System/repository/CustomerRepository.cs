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
    internal class CustomerRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public bool AddCustomer(Customer cus)
        {
            string query = @"Insert into customers (customername) values (@name)";
            MySqlParameter[] ps =
            {
                new MySqlParameter("@name",cus.CustomerName)
            };

            return dbConn.ExecuteCommand(query, ps);
        }


        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            string query = @"Select customerId,customerName from customers";

            try
            {
                using (DataTable dt = dbConn.GetData(query, null))
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            Customer c = new Customer
                            {
                                CustomerId = Convert.ToInt32(row["customerId"]),
                                CustomerName = row["customerName"].ToString()
                            };
                            customers.Add(c);
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Error in GetAll: {ex.Message}");
                throw; 
            }

            return customers;
        }
    }
}
