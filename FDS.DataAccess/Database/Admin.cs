using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FDS.DataAccess.Database
{
    [Table("Admin")]

    public partial class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
