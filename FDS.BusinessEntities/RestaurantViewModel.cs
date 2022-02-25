using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class RestaurantViewModel
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int AddressID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OwnerName { get; set; }
        public string ShiftInTime { get; set; }
        public string ShiftOutTime { get; set; }
        public string GstNumber { get; set; }
        public byte[] FssaiCertificate { get; set; }
        public string BankAccountNumber { get; set; }
        public byte[] PassbookFirstPage { get; set; }

        public bool Status { get; set; }
        public string Availibility { get; set; }
        public string ContactDetails { get; set; }
    }
}
