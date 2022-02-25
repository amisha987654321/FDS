using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class RatingViewModel
    {
        public int RatingID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int RestaurantID { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
