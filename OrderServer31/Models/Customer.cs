using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace OrderServer31.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required, StringLength(10)]
        public string Code { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        public bool IsNational { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
