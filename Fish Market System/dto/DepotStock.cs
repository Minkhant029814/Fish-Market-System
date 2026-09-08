using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market_System.dto
{
    internal class DepotStock
    {
        public int DepotId { get; set; }
        public string DepotName { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}
