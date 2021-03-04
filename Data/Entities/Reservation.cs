using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
   public class Reservation : BaseEntity
    {
        public DateTime BookTime { get; set; }
        public DateTime BookDate { get; set; }
        public int PeopleCount { get; set; }
        public string PhoneNumber { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}
