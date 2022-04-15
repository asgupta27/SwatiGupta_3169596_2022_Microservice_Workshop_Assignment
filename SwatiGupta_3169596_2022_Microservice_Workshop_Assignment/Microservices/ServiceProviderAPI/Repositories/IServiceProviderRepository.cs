using ServiceProviderAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProviderAPI.Repositories
{
    public interface IServiceProviderRepository
    {
        IList<ServiceProvider> GetServiceProviders();

        IList<ServiceProvider> GetServiceProvidersByServiceAndLocation(int serviceId, int locationId);

        Task<bool> AddServiceProvider(ServiceProvider serviceProvider);
    }
}
