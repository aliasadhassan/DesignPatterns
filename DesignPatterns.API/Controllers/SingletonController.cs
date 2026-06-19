using DesignPatterns.API._01_Creational_Patterns.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet("settings")]
        public IActionResult GetSettings()
        {
            // Hamin 'new' karne ki zaroorat nahi, hum global instance use kar rahe hain
            var settings = AppSettingsManager.Instance;

            return Ok(new
            {
                Message = "Singleton Instance accessed successfully!",
                AppName = settings.ApplicationName,
                AppVersion = settings.Version,
                InstanceHashCode = settings.GetHashCode() // Is se verify hoga ke instance same hai
            });
        }
    }
}
