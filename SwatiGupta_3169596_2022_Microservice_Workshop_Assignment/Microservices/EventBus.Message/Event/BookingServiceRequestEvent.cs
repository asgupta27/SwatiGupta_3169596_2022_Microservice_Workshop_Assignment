
namespace EventBus.Message.Event
{
    /// <summary>
    /// Booking service request event
    /// </summary>
    public class BookingServiceRequestEvent
    {
        /// <summary>
        /// The BookingId
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// The consumer Id
        /// </summary>
        public int ConsumerId { get; set; }

        /// <summary>
        /// The requested service Id
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// The location Id
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// The service provider Id
        /// </summary>
        public int ServiceProviderId { get; set; }
    }
}
