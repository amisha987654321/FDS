using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDS.DataAccess.Database
{
    [Table("Address")]
    public partial class Address
    {

        public Address()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int? Zip { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        
        //public virtual ICollection<Restaurant> Restaurants { get; set; }
        //public int AddressID { get; set; }
        //public string AddressLine1 { get; set; }
        //public string AddressLine2 { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string Country { get; set; }
        //public int Zip { get; set; }
        //public int CustomerID { get; set; }
       
    }
}
