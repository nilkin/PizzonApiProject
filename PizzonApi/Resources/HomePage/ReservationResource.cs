﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzonApi.Resources.HomePage
{
    public class ReservationResource
    {
        public DateTime BookDate { get; set; }
        public int PeopleCount { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
    }
}
