using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Rating")]
    public partial class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RatingId { get; set; }
        public int? ProductsId { get; set; }
        public int? CustomerId { get; set; }
        public int? RestaurantId { get; set; }
        public int? Rating1 { get; set; }
        public string? ServiceReview { get; set; }
        public DateTime? RatingDate { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Product? Products { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
    }
}
