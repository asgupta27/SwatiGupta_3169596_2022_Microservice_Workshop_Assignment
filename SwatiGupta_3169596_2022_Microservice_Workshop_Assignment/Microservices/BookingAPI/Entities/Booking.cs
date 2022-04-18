
namespace BookingAPI
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceProviderId { get; set; }
        public int LocationId { get; set; }
        public int ServiceId { get; set; }
        public BookingStatus Status { get; set; }

        //Providers Details
        public string ServiceProviderName { get; set; }
        public string ServiceProviderAddress { get; set; }
        public string ServiceProviderContactNo { get; set; }
        public string ServiceProviderEmailId { get; set; }

        //Consumer Details
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string ConsumerEmailId { get; set; }
    }
}
