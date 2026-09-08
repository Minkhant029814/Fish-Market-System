using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto
{
    internal class DepotSpeciesStock
    {
        public int SpeciesId { get; set; }
        public string SpeciesName { get; set; }
        public decimal Quantity { get; set; }
    }
}
