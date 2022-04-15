using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI.Entities
{
    public class BookingServiceRequest
    {
        public int Id { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }
        public string ConsumerName { get; set; }
    }
}
