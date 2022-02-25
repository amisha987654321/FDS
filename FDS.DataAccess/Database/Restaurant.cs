using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess.Database
{
    [Table("Restaurant")]

    public partial class Restaurant
    {

        public Restaurant()
        {
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
            ProductCategories = new HashSet<ProductCategory>();
            Ratings = new HashSet<Rating>();
        }

        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? OwnerName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public int? AddressId { get; set; }
        public byte[]? FssaiCertificate { get; set; }
        public string? GstNumber { get; set; }
        public string? ShiftInTime { get; set; }
        public string? ShiftOutTime { get; set; }
        public bool? Status { get; set; }
        public string? BankAccountNumber { get; set; }
        public byte[]? PassbookFirstPage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }


        
        //public int RestaurantId { get; set; }
        //public string RestaurantName { get; set; }
        //public int AddressID { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }        
        //public string OwnerName { get; set; }
        //public string ShiftInTime { get; set; }
        //public string ShiftOutTime { get; set; }
        //public string GstNumber { get; set; }
        //public byte[] FssaiCertificate { get; set; }
        //public string BankAccountNumber { get; set; }     
        //public byte[] PassbookFirstPage { get; set; }
        //public bool Status { get; set; }
    }
}
