using System;
using System.Collections.Generic;

namespace ServiceProviderAPI.Entities
{
    public class ServiceProvider
    {
        public int Id { get; set; }

        /// <summary>
        /// Name of the service provider
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Username of service provider
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Location of service provider
        /// </summary>
        public int Location { get; set; }

        /// <summary>
        /// Address of service provider
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Get or set contact no
        /// </summary>
        public string ContactNo { get; set; }

        /// <summary>
        /// List of services provided by the service provider
        /// </summary>
        public List<int> Services { get; set; }
    }
}
