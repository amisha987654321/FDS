using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class AddressViewModel
    {
        public int AddressID { get; set; }
        public string AddressAsStringFromAddressModel { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zip { get; set; }
        public CustomerViewModel Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
