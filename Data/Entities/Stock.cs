using System.Collections.Generic;

namespace Data.Entities
{
    public class Stock : BaseEntity
    {
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
