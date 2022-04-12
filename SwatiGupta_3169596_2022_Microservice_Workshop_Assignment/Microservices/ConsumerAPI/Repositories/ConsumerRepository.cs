using ConsumerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerAPI.Repositories
{
    public class ConsumerRepository
    {
        private readonly List<Consumer> consumers;
        public ConsumerRepository()
        {
            consumers = new List<Consumer>
            {
                new Consumer { Id = 1, Name = "Test Consumer", Username = "Consumer1", EmailId = "Consumer1@test.com" },
                new Consumer { Id = 2, Name = "Sample Consumer", Username = "Consumer2", EmailId = "Consumer2@test.com" },
                new Consumer { Id = 3, Name = "Test Consumer2", Username = "Consumer3", EmailId = "Consumer3@test.com" },
                new Consumer { Id = 4, Name = "Test Consumer3", Username = "Consumer4", EmailId = "Consumer4@test.com" },
                new Consumer { Id = 5, Name = "Test Consumer4", Username = "Consumer5", EmailId = "Consumer5@test.com" },
            };
        }

        public List<Consumer> GetConsumers()
        {
            return consumers;
        }

        public Consumer GetConsumerById(int id)
        {
            return consumers.FirstOrDefault(x => x.Id == id);
        }
    }
}
