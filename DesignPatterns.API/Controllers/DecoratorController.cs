using DesignPatterns.API._02_Structural_Patterns.Decorator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecoratorController : ControllerBase
    {
        [HttpGet("send")]
        public IActionResult SendNotification([FromQuery] string msg = "Hello World")
        {
            // 1. Plain standard baseline service
            IMessageService service = new BaseMessageService();

            // 2. Wrap it dynamically with Logging capabilities
            service = new LoggingMessageDecorator(service);

            // 3. Wrap it again dynamically with Encryption layer
            service = new EncryptedMessageDecorator(service);

            // Executes the entire chain dynamically
            string finalResult = service.Send(msg);

            return Ok(new
            {
                Input = msg,
                ExecutedResult = finalResult
            });
        }
    }
}
