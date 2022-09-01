using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Airlines_API.Models
{


    public class SearchData
    {
           [Key]
            public long FlightId { get; set; }

            public string source_city { get; set; }

            public string destination_city { get; set; }

            public string FlightName { get; set; }

            public DateTime Departure_Time { get; set; }

            public DateTime Arrival_Time{ get; set; }
            public decimal Economy_fare { get; set; }
            public decimal Business_fare { get; set; }


    }
}
