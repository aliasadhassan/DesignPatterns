using DesignPatterns.API._01_Creational_Patterns.Builder;
using DesignPatterns.API._02_Structural_Patterns.Adapter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdapterController : ControllerBase
    {
        [HttpGet("log")]
        public IActionResult TestLogging(string userMessage)
        {
            // Client ko lag raha hai wo purana system use kar raha hai
            ITargetLogger logger = new LoggerAdapter();

            // Lekin backend par Adapter naya advanced logger chala raha hai
            string result = logger.LogMessage(userMessage);

            return Ok(new
            {
                Message = "Adapter Pattern executed successfully!",
                Output = result
            });
        }
    }
}
