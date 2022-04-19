using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Entities
{
    /// <summary>
    /// The services provided by the application
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Service Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        public string Name { get; set; }
    }
}
