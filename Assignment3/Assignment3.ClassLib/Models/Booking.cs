using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.ClassLib.Models
{
    public class Booking
    {
        public Customer customer { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}