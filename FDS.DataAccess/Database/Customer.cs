using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS.DataAccess.Database
{
    [Table("Customer")]
    public partial class Customer
    {

        public Customer()
        {
            Addresses = new List<Address>();
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
            Ratings = new HashSet<Rating>();
        }
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        
        public int CustomerId { get; set; }
        public string? Firstname { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public bool? Subscription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        

        public virtual IList<Address> Addresses { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

        //another
        //public int CustomerId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }
        //public bool Subscription { get; set; }
        //public string Password { get; set; }
        //public virtual Address AddressFK { get; set; }

    }
}
