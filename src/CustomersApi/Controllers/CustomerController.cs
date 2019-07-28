using Common.Dtos;
using Common.Services;
using CustomersApi.Dtos;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using WebApi.Messages;

namespace CustomersApi.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly IBus _bus;
        private readonly ILogger _logger;

        public CustomerController(IBus bus, ILogger logger)
        {
            _bus = bus;
            _logger = logger;
        }

        /// <summary>
        /// Registers a customer
        /// </summary>
        [HttpPost("customers/register")]
        public IActionResult RegisterAsync([FromBody] CustomerDto customer)
        {
            _logger.LogInformation("Customer with email: " + customer.Email + " registered");

            _bus.Publish(new CustomerRegisteredEvent { Email = customer.Email }).Wait();

            return Ok(new SuccessMessage());
        }
    }
}
