using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Testimonial : BaseEntity
    {
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string PhotoUrl { get; set; }
        public string Thought { get; set; }
    }
}
