using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Cart")]
    public partial class Cart
    {
        public Cart()
        {
            CartProducts = new HashSet<CartProduct>();
            Orders = new HashSet<Order>();
        }

        [Key]       
        
        public int CartId { get; set; }
        public int? TotalPrice { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
