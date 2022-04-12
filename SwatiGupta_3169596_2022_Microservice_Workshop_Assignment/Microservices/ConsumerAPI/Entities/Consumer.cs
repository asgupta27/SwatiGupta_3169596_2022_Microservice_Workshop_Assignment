using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerAPI.Entities
{
    public class Consumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Location { get; set; }
        public string EmailId { get; set; }
    }
}
