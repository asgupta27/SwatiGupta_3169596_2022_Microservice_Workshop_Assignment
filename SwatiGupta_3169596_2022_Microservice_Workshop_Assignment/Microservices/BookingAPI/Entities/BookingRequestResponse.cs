
namespace BookingAPI
{
    public class BookingRequestResponse
    {
        public int BookingId { get; set; }
        public bool IsAccepted { get; set; }
        public int ServiceProviderId { get; set; }

        //Providers Details
        public string ServiceProviderName { get; set; }
        public string ServiceProviderAddress { get; set; }
        public string ServiceProviderContactNo { get; set; }
        public string ServiceProviderEmailId { get; set; }
    }
}
