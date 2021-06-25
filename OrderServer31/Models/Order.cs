using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace OrderServer31.Models
{
    public class Order
    {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Description { get; set; }
        [Required, StringLength(30)]
        public string Status { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public int SalespersonId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Salesperson Salesperson { get; set; }
        public virtual ICollection<Orderline> Orderlines { get; set; }
    }
}
