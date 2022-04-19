using ConsumerAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumerAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
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
            var consumers = await consumerRepository.GetConsumers();
            return Ok(consumers);
        }

        /// <summary>
        /// Get consumer by Id
        /// </summary>
        /// <param name="id">The consumer id</param>
        /// <returns>The consumer</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int id)
        {
            var consumer = await consumerRepository.GetConsumerById(id);
            return Ok(consumer);
        }

        /// <summary>
        /// Create Consumer
        /// </summary>
        /// <param name="consumer">The consumer model</param>
        /// <returns>The consumer</returns>
        [HttpPost]
        public async Task<ActionResult<Consumer>> createConsumer([FromBody] Consumer consumer)
        {
            var model = await consumerRepository.CreateConsumer(consumer);
            return Ok(model);
        }
    }
}
