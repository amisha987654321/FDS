using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class PaymentViewModel
    {
        public int PaymentID { get; set; }
        public int RestaurantID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public int TransactionID { get; set; }
    }
}
