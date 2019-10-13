using System;
using System.Collections.Generic;

namespace DbLibrary.Entities
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public string ProductName { get; set; }
        public string LocationName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime DateModified { get; set; }
    }
}
