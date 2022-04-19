using ConsumerAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerAPI
{
    /// <summary>
    /// Consumer Repository
    /// </summary>
    public class ConsumerRepository
    {
        private static readonly List<Consumer> consumers = new List<Consumer>
            {
                new Consumer { Id = 1, Name = "Test Consumer", Username = "Consumer1", EmailId = "Consumer1@test.com" },
                new Consumer { Id = 2, Name = "Sample Consumer", Username = "Consumer2", EmailId = "Consumer2@test.com" },
                new Consumer { Id = 3, Name = "Test Consumer2", Username = "Consumer3", EmailId = "Consumer3@test.com" },
                new Consumer { Id = 4, Name = "Test Consumer3", Username = "Consumer4", EmailId = "Consumer4@test.com" },
                new Consumer { Id = 5, Name = "Test Consumer4", Username = "Consumer5", EmailId = "Consumer5@test.com" },
            };
        public ConsumerRepository()
        {

        }

        /// <summary>
        /// Get consumers
        /// </summary>
        /// <returns>Return consumerlist</returns>
        public Task<List<Consumer>> GetConsumers()
        {
            return Task.FromResult(consumers);
        }

        /// <summary>
        /// Get consumer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Consumer> GetConsumerById(int id)
        {
            var consumer = consumers.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(consumer);
        }

        /// <summary>
        /// Create a consumer
        /// </summary>
        /// <param name="consumer">The consumer</param>
        /// <returns>Return the consumer</returns>
        public Task<Consumer> CreateConsumer(Consumer consumer)
        {
            var maxId = consumers.Select(x => x.Id).Max();
            consumer.Id = maxId;
            consumers.Add(consumer);
            return Task.FromResult(consumer);
        }
    }
}
