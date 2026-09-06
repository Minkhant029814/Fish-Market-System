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

        public bool AddFish(FishSpecies fish)
        {
            return fishSpeciesRepository.AddFish(fish);
        }

        public List<FishSpecies> GetAll()
        {
            return fishSpeciesRepository.GetAll();
        }
    }
}
