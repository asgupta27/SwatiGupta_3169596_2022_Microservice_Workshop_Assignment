using AdminAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        [Route("service")]
        public async Task<ActionResult<List<Service>>> GetServices()
        {
            var services = serviceRepository.GetServices();
            return Ok(services);
        }

        [HttpGet]
        [Route("service/{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = serviceRepository.GetServiceById(id);
            return Ok(service);
        }

        [HttpPost]
        [Route("addService")]
        public Task<bool> AddService(Service service)
        {
            return serviceRepository.AddService(service);
        }
    }
}
