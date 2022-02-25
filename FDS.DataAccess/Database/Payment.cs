using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PaymentId { get; set; }
        public int? RestaurantId { get; set; }
        public int? CustomerId { get; set; }
        public int? OrderId { get; set; }
        public decimal? Amount { get; set; }
        public string? TransactionId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
    }
}
