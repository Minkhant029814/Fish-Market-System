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
    internal class FishSpeciesRepository
    {
        private readonly DBConnect dbConn = new DBConnect();

        public bool AddFish(FishSpecies fish)
        {
            string query = @"insert into fishspecies (speciesName) value (@name)";
            MySqlParameter[] ps =
            {
                new MySqlParameter("@name",fish.FishSpeciesName)
            };

            return dbConn.ExecuteCommand(query, ps);
        }


        public List<FishSpecies> GetAll()
        {
            try
            {
                List<FishSpecies> fishes = new List<FishSpecies>();

                string query = @"select speciesId,speciesName from fishspecies";

                using (DataTable dt = dbConn.GetData(query, null))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            FishSpecies fish = new FishSpecies
                            {
                                FishSpeciesId = Convert.ToInt32(row["speciesId"]),
                                FishSpeciesName = row["speciesName"].ToString()
                            };
                            fishes.Add(fish);
                        }
                      
                    }
                    return fishes;
                }

            }catch(Exception e)
            {
                Console.WriteLine("Error is " + e.Message);
                throw;
            }
        }
    }
}
