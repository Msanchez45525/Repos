﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrderServer31.Models
{
    public partial class Orderline
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
