using AdminAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAPI.Repositories
{
    public class ServiceRepository
    {
        private static readonly List<Service> services =  new List<Service>
        {
            new Service { Id = 1, Name = "Cleaning Service"},
            new Service { Id = 2, Name = "AC Repairing Service" },
            new Service { Id = 3, Name = "Grooming Service"},
            new Service { Id = 4, Name = "Car Service"},
            new Service { Id = 5, Name = "Salon for Man"},
            new Service { Id = 6, Name = "Salon for Women"},
            new Service { Id = 7, Name = "Electrical Services"},
        };
        public ServiceRepository()
        {
            
        }

        /// <summary>
        /// Get all services
        /// </summary>
        /// <returns>Returns services</returns>
        public Task<List<Service>> GetServices()
        {
            return Task.FromResult(services);
        }

        /// <summary>
        /// Gets service by service Id
        /// </summary>
        /// <param name="id">The service Id</param>
        /// <returns>Returns the service</returns>
        public Task<Service> GetServiceById(int id)
        {
            var service = services.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(service);
        }

        /// <summary>
        /// Add service 
        /// </summary>
        /// <param name="service">The service model</param>
        /// <returns>Return the success flag</returns>
        public Task<bool> AddService(Service service)
        {
            services.Add(service);
            return Task.FromResult(true);
        }
    }
}
