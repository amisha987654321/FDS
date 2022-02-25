using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.BusinessEntities
{
    public class DeliveryPartnerViewModel
    {
        public int ID { get; set; }
        public string RCbookNumber { get; set;}
        public string LicenceNumber { get; set;}
        public byte[] HealthCertificate { get; set;}
        public DateTime BirthDate { get; set; }
        public byte[] AadharCard { get; set; }
        public byte[] PanCard { get; set; }
        public string BankAccountNumber { get; set; }
        public byte[] PassbookFirstPage { get; set; }
        public byte[] Photograph { get; set; }
        public bool IsSmartPhone { get; set; }



    }
}
