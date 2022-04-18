using AutoMapper;
using EventBus.Message.Event;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace NotificationAPI
{
    public class BookingConfirmationEventConsumer : IConsumer<BookingConfirmationEvent>
    {
        private readonly IMapper _mapper;
        public BookingConfirmationEventConsumer(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task Consume(ConsumeContext<BookingConfirmationEvent> context)
        {
            var obj = _mapper.Map<BookingConfirmationDetail>(context.Message);
            if(obj != null)
            {
                //send email to consumer
                Console.WriteLine($" Dear {obj.ServiceProviderName} , Booking has been confirmed! Details of Consumer - Name :- {obj.ConsumerName}, Contactno - {obj.ContactNo}");

                //send email to provider
                Console.WriteLine($" Dear {obj.ConsumerName} , Booking has been confirmed! Details of Service Provider - Name :- {obj.ServiceProviderName}, Contactno - {obj.ServiceProviderAddress}");
            }
        }
    }
}
