
namespace EventBus.Message.Event
{
    /// <summary>
    /// Booking confimation event
    /// </summary>
    public class BookingConfirmationEvent
    {
        /// <summary>
        /// The Booking Id
        /// </summary>
        public int BookingId { get; set; }

        /// <summary>
        /// The consumer Id
        /// </summary>
        public int ConsumerId { get; set; }

        /// <summary>
        /// The service Provider Id
        /// </summary>
        public int ServiceProviderId { get; set; }

        /// <summary>
        /// The requested location Id
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// The requested service Id
        /// </summary>
        public int ServiceId { get; set; }

        //Consumer details
        /// <summary>
        /// Consumer name
        /// </summary>
        public string ConsumerName { get; set; }

        /// <summary>
        /// Consumer address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Consumer contact no
        /// </summary>
        public string ContactNo { get; set; }

        /// <summary>
        /// Consumer emailId
        /// </summary>
        public string ConsumerEmailId { get; set; }

        //Service providers details

        /// <summary>
        /// The service provider name
        /// </summary>
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// The service provider address
        /// </summary>
        public string ServiceProviderAddress { get; set; }

        /// <summary>
        /// The service provider contact no
        /// </summary>
        public string ServiceProviderContactNo { get; set; }

        /// <summary>
        /// The service provider email Id
        /// </summary>
        public string ServiceProviderEmailId { get; set; }
    }
}
