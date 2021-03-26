using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzonApi.Resources.HomePage
{
    public class BlogResource
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public bool IsNew { get; set; }
        public string Text { get; set; }
        public string PhotoUrl { get; set; }
        public int OrderBy { get; set; }
    }
}
