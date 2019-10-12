using System;
using System.Collections.Generic;

namespace DbLibrary.Entities
{
    public partial class Inventory
    {
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        public decimal? ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Locations Location { get; set; }
    }
}
