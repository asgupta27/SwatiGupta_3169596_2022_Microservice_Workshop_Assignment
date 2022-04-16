
namespace EventBus.Message.Event
{
    public class BookingServiceRequestEvent
    {
        public int Id { get; set; }
        public int ConsumerId { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }
        public string ConsumerName { get; set; }
        public string Address { get; set; }        
        public int ServiceProviderId { get; set; }
    }
}
