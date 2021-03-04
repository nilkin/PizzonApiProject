using Data.Enum;
using System.Collections.Generic;

namespace Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public ProductSize Size { get; set; }
        public string ProductType { get; set; }
        public bool IsPromo { get; set; }
        public int OrderBy { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
    }
}
