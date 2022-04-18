
namespace EventBus.Message.Event
{
    public class BookingConfirmationEvent
    {
        public int BookingId { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceProviderId { get; set; }
        public int LocationId { get; set; }
        public int ServiceId { get; set; }

        //Consumer details
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string ConsumerEmailId { get; set; }

        //Service providers details
        public string ServiceProviderName { get; set; }
        public string ServiceProviderAddress { get; set; }
        public string ServiceProviderContactNo { get; set; }
        public string ServiceProviderEmailId { get; set; }
    }
}
