namespace ConsumerAPI.Entities
{
    /// <summary>
    /// The consumer entity
    /// </summary>
    public class Consumer
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of consumer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User name of registered consumer
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public int Location { get; set; }

        /// <summary>
        /// The email Id
        /// </summary>
        public string EmailId { get; set; }

        /// <summary>
        /// The address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The contact no
        /// </summary>
        public string ContactNo { get; set; }
    }
}
