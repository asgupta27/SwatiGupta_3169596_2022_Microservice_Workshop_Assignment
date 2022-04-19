using ServiceProviderAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    public interface IServiceProviderRepository
    {
        /// <summary>
        /// Get all service providers
        /// </summary>
        /// <returns>Return service providers</returns>
        Task<IList<ServiceProvider>> GetServiceProviders();

        /// <summary>
        /// Return service providers by location and service Id
        /// </summary>
        /// <param name="serviceId">The service Id</param>
        /// <param name="locationId">The location Id</param>
        /// <returns>The service provider</returns>
        Task<List<ServiceProvider>> GetServiceProvidersByServiceAndLocation(int serviceId, int locationId);

        /// <summary>
        /// Return service providers by location and service Id
        /// </summary>
        /// <param name="serviceId">The service Id</param>
        /// <param name="locationId">The location Id</param>
        /// <returns>The service provider</returns>
        Task<bool> AddServiceProvider(ServiceProvider serviceProvider);
    }
}
