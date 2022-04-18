
namespace BookingAPI
{
    public class BookingServiceRequest
    {
        public int Id { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }

        //Consumer Details
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string ConsumerEmailId { get; set; }
    }
}
