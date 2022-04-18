using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceProviderId { get; set; }
        public int LocationId { get; set; }
        public int ServiceId { get; set; }
        public BookingStatus Status { get; set; }
    }
}
