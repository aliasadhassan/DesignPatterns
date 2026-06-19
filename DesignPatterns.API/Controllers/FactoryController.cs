using DesignPatterns.API._01_Creational_Patterns.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        [HttpGet("process-payment")]
        public IActionResult Checkout(string method, decimal amount)
        {
            try
            {
                // Controller ko nahi pata backend pr kaun si class chalegi
                // Factory runtime pr decision le gi
                IPaymentProcessor processor = PaymentProcessorFactory.CreateProcessor(method);

                string result = processor.ProcessPayment(amount);

                return Ok(new { Success = true, Message = result });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Success = false, Message = ex.Message });
            }
        }
    }
}
