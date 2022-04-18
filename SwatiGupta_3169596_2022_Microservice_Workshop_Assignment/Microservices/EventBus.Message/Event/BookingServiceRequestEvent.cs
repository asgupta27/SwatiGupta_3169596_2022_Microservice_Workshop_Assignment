
namespace EventBus.Message.Event
{
    public class BookingServiceRequestEvent
    {
        public int BookingId { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }
        public int ServiceProviderId { get; set; }
    }
}
