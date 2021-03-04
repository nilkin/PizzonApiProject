using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzonApi.Resources.HomePage
{
    public class ProductCategoryResource
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
    }
}
