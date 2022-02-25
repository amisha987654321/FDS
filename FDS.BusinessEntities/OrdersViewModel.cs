using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class OrdersViewModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int DeliveryParnerId { get; set; }
        public int RestaurantId { get; set; }
        public bool Status { get; set; }


    }
}
