using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.model
{
    public class Fish
    {
        public string FishType { get; set; }
        public decimal PricePerEachWeigh { get; set; }
        public decimal Weight { get; set; }

        public decimal TotalPrice => PricePerEachWeigh * Weight;
        
        public string SellingType { get; set; }


    }
}
