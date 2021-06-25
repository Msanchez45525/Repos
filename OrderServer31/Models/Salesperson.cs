using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace OrderServer31.Models
{
    public class Salesperson
    {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(2)]
        public string StateCode { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
