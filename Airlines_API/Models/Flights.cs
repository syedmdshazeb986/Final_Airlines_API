using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines_API.Models
{
    public class Flights
    {
        [Key]
        [Required]
        public Int64 FlightId { get; set; }

        [Required]
        public string FlightName { get; set; }


        [Required]
        public Int64 Depart_airport_Id { get; set; }

        [Required]
        public Int64 Arrival_airport_Id { get; set; }


        [Required]
        public Nullable<DateTime> Departure_Time { get; set; }

        [Required]
        public Nullable<DateTime> Arrival_Time { get; set; }

        [Required]
        public decimal Economy_fare { get; set; }


        [Required]
        public decimal Business_fare { get; set; }

        [Required]
        public Int64 Total_Business_Seats { get; set; }


        [Required]
        public Int64 Total_Economy_Seats { get; set; }




    }
}
