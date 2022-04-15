using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAPI.Models
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
        /// List of services provided by the service provider
        /// </summary>
        public List<int> Services { get; set; }
    }
}
