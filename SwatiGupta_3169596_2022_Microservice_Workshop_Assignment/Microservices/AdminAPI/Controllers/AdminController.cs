using AdminAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ServiceRepository serviceRepository;
        public AdminController()
        {
            serviceRepository = new ServiceRepository();
        }

        /// <summary>
        /// Get list of all services
        /// </summary>
        /// <returns>Get all services</returns>
        [HttpGet]
        [Route("service")]        
        public async Task<ActionResult<List<Service>>> GetServices()
        {
            var services = await serviceRepository.GetServices();
            return Ok(services);
        }

        /// <summary>
        /// Get service detail by service Id
        /// </summary>
        /// <param name="id">The service Id</param>
        /// <returns>Returns the service</returns>
        [HttpGet]
        [Route("service/{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = await serviceRepository.GetServiceById(id);
            return Ok(service);
        }

        /// <summary>
        /// Add service
        /// </summary>
        /// <param name="service">The service</param>
        /// <returns>Return the success flag</returns>
        [HttpPost]
        [Route("addService")]
        public async Task<bool> AddService(Service service)
        {
            return await serviceRepository.AddService(service);
        }
    }
}
