using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            CartProducts = new HashSet<CartProduct>();
            Ratings = new HashSet<Rating>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductsId { get; set; }
        public string? ProductName { get; set; }
        public int? ProductCategoryId { get; set; }
        public byte[]? Image { get; set; }
        public decimal? Price { get; set; }
        public bool? IsVeg { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
