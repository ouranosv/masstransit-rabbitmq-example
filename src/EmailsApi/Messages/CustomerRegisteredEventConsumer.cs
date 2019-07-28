using System.Threading.Tasks;
using Common.Services;
using MassTransit;

namespace WebApi.Messages
{
    public class CustomerRegisteredEventConsumer : IConsumer<CustomerRegisteredEvent>
    {
        private readonly ILogger _logger;

        public CustomerRegisteredEventConsumer(ILogger logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<CustomerRegisteredEvent> context)
        {
            _logger.LogInformation("Customer with email: " + context.Message.Email + " registered");

            return Task.CompletedTask;
        }
    }
}
