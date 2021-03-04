using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Contact : BaseEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
