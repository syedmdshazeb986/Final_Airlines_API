using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines_API.Models
{
    public class GetBookingId
    {
        [Key]
        public Int64 BookingId { get; set; }
    }
}
