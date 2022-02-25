using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public byte[] Image { get; set; }
        public decimal Price { get; set; }
        public bool IsVeg { get; set; }
        public int RatingId { get; set; }
        public bool Status { get; set; }

    }
}
