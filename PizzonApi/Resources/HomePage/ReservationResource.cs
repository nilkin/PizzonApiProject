using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzonApi.Resources.HomePage
{
    public class ReservationResource
    {
        [Required(ErrorMessage = "Please Enter book date")]
        [DataType(DataType.Date)]
        public DateTime BookDate { get; set; }
        [Required(ErrorMessage = "Please enter people count")]
        public int PeopleCount { get; set; }
        [Required(ErrorMessage = "Please Enter you Name")]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please Enter your Email")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
