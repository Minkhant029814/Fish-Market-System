using Fish_Market_System.repository;
using FishStore.model;
using System.Collections.Generic;

namespace Fish_Market_System.service
{
    public class FishSpeciesService
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
