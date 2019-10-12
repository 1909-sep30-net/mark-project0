﻿using System;
using System.Collections.Generic;

namespace DbLibrary.Entities
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Products Product { get; set; }
    }
}
