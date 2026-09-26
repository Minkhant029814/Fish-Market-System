using FishStore.database;
using FishStore.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FishStore.repository
{
    public class DepotRepository
    {
        private readonly DBConnect dbConn = new DBConnect();


        public bool AddDepot(Depot depot)
        {
            string query = @"insert into depots (depotname) values (@name)";
            MySqlParameter[] ps =
            {
                new MySqlParameter("@name",depot.DepotName)
            };

            return dbConn.ExecuteCommand(query, ps);
        }

        public List<Depot> GetAll()
        {
            try
            {
                List<Depot> depots = new List<Depot>();
                string query = @"select depotId, depotname from depots";

                using (DataTable dt = dbConn.GetData(query, null))
                {
                    if(dt != null & dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            Depot depot = new Depot
                            {
                                DepotId = Convert.ToInt32(row["depotId"]),
                                DepotName = row["depotName"].ToString()
                            };
                            depots.Add(depot);
                        }
                    }
                    return depots;
                }

            }catch(Exception ex)
            {
                Console.WriteLine("All error get is " + ex.Message);
                throw;
            }
        }
    }
}
