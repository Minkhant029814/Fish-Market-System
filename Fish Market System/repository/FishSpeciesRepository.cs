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

        public bool AddFish(FishCategory fish)
        {
            string query = @"insert into fish_categories (categoryName) value (@name)";
            MySqlParameter[] ps =
            {
                new MySqlParameter("@name",fish.CategoryName)
            };

            return dbConn.ExecuteCommand(query, ps);
        }


        public List<FishCategory> GetAll()
        {
            try
            {
                List<FishCategory> fishes = new List<FishCategory>();

                string query = @"select categoryId,categoryName from fish_categories";

                using (DataTable dt = dbConn.GetData(query, null))
                {
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            FishCategory fish = new FishCategory
                            {
                                CategoryId = Convert.ToInt32(row["categoryId"]),
                                CategoryName = row["categoryName"].ToString()
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

        public bool AddNewFishSpeices(FishSpecies fish)
        {
            try
            {
                string query = "Insert into fishspecies (categoryId,speciesName) values (@cateId,@name) ";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@cateId",fish.CategoryId),
                    new MySqlParameter("@name",fish.FishSpeciesName)
                };

                return dbConn.ExecuteCommand(query, ps);

            }
            catch (Exception ex)
            {


                throw new Exception($"{ex.Message }ဒေတာထည့်သွင်းရာတွင် အမှားယွင်းဖြစ်ခဲ့သည်။");
            }
        }

        public List<FishSpecies> GetAllSpeices(int categoryId)
        {
            try
            {
                List<FishSpecies> fishes = new List<FishSpecies>();
                string query = @"Select speciesId,speciesName from fishSpecies where categoryId = @cateId";
                MySqlParameter[] ps =
                {
                    new MySqlParameter("@cateId",categoryId)
                };

                DataTable dt = dbConn.GetData(query, ps);
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
            catch (Exception ex)
            {

                throw new Exception($"‌ေဒေတာရယူရာတွင် အမှားယွင်းဖြစ်ပွားခဲ့သည်။ {ex.Message}");
            }
        }
    }
}
