using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            Payments = new HashSet<Payment>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? Amount { get; set; }
        public int? Quantity { get; set; }
        public int? CartId { get; set; }
        public int? DeliveryPartnerId { get; set; }
        public int? RestaurantId { get; set; }
        public bool? Status { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual DeliveryPartner? DeliveryPartner { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
