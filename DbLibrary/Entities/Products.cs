using System;
using System.Collections.Generic;

namespace DbLibrary.Entities
{
    public partial class Products
    {
        public Products()
        {
            ProductsFromOrder = new HashSet<ProductsFromOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<ProductsFromOrder> ProductsFromOrder { get; set; }
    }
}
