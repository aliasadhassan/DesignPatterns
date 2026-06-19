using DesignPatterns.API._01_Creational_Patterns.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuilderController : ControllerBase
    {
        [HttpGet("send-welcome-email")]
        public IActionResult SendWelcomeEmail(string userEmail)
        {
            // Fluent API syntax ke sath step-by-step email object build ho raha hai
            var emailBuilder = new EmailBuilder();

            EmailNotification welcomeEmail = emailBuilder
                .SetRecipient(userEmail)
                .SetSubject("Welcome to Design Patterns API!")
                .SetBody("<h1>Hi!</h1><p>Thanks for joining our platform.</p>", isHtml: true)
                .AddAttachment("WelcomeGuide.pdf")
                .AddAttachment("TermsOfService.pdf")
                .Build();

            return Ok(new
            {
                Success = true,
                Message = "Email built using Builder Pattern successfully",
                Details = welcomeEmail
            });
        }
    }
}
