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

        public List<Service> GetServices()
        {
            return services;
        }

        public Service GetServiceById(int id)
        {
            return services.FirstOrDefault(x => x.Id == id);
        }

        public Task<bool> AddService(Service service)
        {
            services.Add(service);
            return Task.FromResult(true);
        }
    }
}
