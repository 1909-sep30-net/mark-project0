using System;
using System.Collections.Generic;

namespace DbLibrary.Entities
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
