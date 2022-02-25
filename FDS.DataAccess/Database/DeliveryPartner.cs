using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("DeliveryPartner")]
    public partial class DeliveryPartner
    {
        public DeliveryPartner()
        {
            Orders = new HashSet<Order>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public byte[]? RcbookNumber { get; set; }
        public string? LicenseNumber { get; set; }
        public byte[]? HealthCertificate { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte[]? AadharCard { get; set; }
        public bool? PanCard { get; set; }
        public string? BankAccountNumber { get; set; }
        public byte[]? PassbookFirstPage { get; set; }
        public byte[]? PhotoGraph { get; set; }
        public bool? SmartPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
