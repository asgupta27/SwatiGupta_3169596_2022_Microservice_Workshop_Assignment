using Microsoft.AspNetCore.Mvc;
using ServiceProviderAPI.Entities;
using ServiceProviderAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceProviderAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ServiceProviderController : ControllerBase
    {
        public IServiceProviderRepository serviceProviderRepository;
        public ServiceProviderController(IServiceProviderRepository serviceProviderRepository)
        {
            this.serviceProviderRepository = serviceProviderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceProvider>>> GetAllServiceProviderByLocationId(int serviceId, int locationId)
        {
            var providers = this.serviceProviderRepository.GetServiceProvidersByServiceAndLocation(serviceId, locationId);
            return Ok(providers);
        }

        [HttpPost]
        public  Task<bool> AddServiceProvider([FromBody] ServiceProvider serviceProvider)
        {
            return this.serviceProviderRepository.AddServiceProvider(serviceProvider);
        }

    }
}
