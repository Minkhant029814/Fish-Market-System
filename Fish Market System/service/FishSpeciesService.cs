using Fish_Market_System.model;
using Fish_Market_System.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.service
{
    internal class FishSpeciesService
    {
        private readonly FishSpeciesRepository fishSpeciesRepository = new FishSpeciesRepository();

        public bool AddFish(FishCategory fish)
        {
            return fishSpeciesRepository.AddFish(fish);
        }

        public List<FishCategory> GetAll()
        {
            return fishSpeciesRepository.GetAll();
        }

        public bool AddNewSpecies(FishSpecies fish)
        {
            return fishSpeciesRepository.AddNewFishSpeices(fish);
        }

        public List<FishSpecies> GetAllSpecies(int categoryId)
        {
            return fishSpeciesRepository.GetAllSpeices(categoryId);
        }
    }
}
