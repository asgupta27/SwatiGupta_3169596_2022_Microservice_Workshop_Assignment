using ServiceProviderAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProviderAPI
{
    public class ServiceProviderRepository : IServiceProviderRepository
    {
        private static readonly IList<ServiceProvider> serviceProviders = new List<ServiceProvider>
        {
            new ServiceProvider {Address = "Jaipur", Location = 1, Name = "Tejas Mens Salon", Services = new List<int>{5}, Username = "serviceprovider1", ContactNo ="123456789"},
            new ServiceProvider {Address = "Udaipur", Location = 2, Name = "Neeru Parlour", Services = new List<int>{ 3, 6} , Username = "serviceprovider2" ,  ContactNo ="123456789"},
            new ServiceProvider {Address = "Delhi", Location = 301, Name = "Car and Rental Service", Services = new List<int>{ 4 }, Username = "serviceprovider3",  ContactNo ="123456789" },
            new ServiceProvider {Address = "Delhi", Location = 302, Name = "Cleaning Service", Services = new List<int>{ 1 }, Username = "serviceprovider4",  ContactNo ="123456789"},
            new ServiceProvider {Address = "Noida", Location = 303, Name = "Repairing Services", Services = new List<int>{ 2, 7} , Username = "serviceprovider5",  ContactNo ="123456789"}
        };
        public ServiceProviderRepository()
        {
            
        }

        /// <summary>
        /// Get all service providers
        /// </summary>
        /// <returns>Return service providers</returns>
        public Task<IList<ServiceProvider>> GetServiceProviders()
        {
            return Task.FromResult(serviceProviders);
        }

        /// <summary>
        /// Return service providers by location and service Id
        /// </summary>
        /// <param name="serviceId">The service Id</param>
        /// <param name="locationId">The location Id</param>
        /// <returns>The service provider</returns>
        public Task<List<ServiceProvider>> GetServiceProvidersByServiceAndLocation(int serviceId, int locationId)
        {
            var providers = serviceProviders.Where(provider => provider.Location == locationId && provider.Services.Any(service => service == serviceId))
                            .ToList();
            return Task.FromResult(providers);
        }


        /// <summary>
        /// Add service Provider
        /// </summary>
        /// <param name="serviceProvider">The service provider</param>
        /// <returns>Success flag</returns>
        public Task<bool> AddServiceProvider(ServiceProvider serviceProvider)
        {
            serviceProviders.Add(serviceProvider);
            return Task.FromResult(true);
        }       
    }
}
