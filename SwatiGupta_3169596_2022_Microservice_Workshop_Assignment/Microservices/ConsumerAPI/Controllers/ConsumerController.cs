using ConsumerAPI.Entities;
using ConsumerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private readonly ConsumerRepository consumerRepository;
        public ConsumerController()
        {
            consumerRepository = new ConsumerRepository();
        }

        [HttpGet]
        public async Task<ActionResult<List<Consumer>>> GetConsumers()
        {
            var users = consumerRepository.GetConsumers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int id)
        {
            var user = consumerRepository.GetConsumerById(id);
            return Ok(user);
        }      
    }
}
