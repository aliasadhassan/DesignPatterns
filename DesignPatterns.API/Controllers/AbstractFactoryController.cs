using DesignPatterns.API._01_Creational_Patterns.AbstractFactory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DesignPatterns.API._01_Creational_Patterns.AbstractFactory.ThemeFactories;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbstractFactoryController : ControllerBase
    {
        [HttpGet("theme/{type}")]
        public IActionResult GetThemeComponents(string type)
        {
            IThemeFactory factory;

            // Decide which variant family to instantiate at runtime
            if (type?.ToLower() == "dark")
            {
                factory = new DarkThemeFactory();
            }
            else
            {
                factory = new LightThemeFactory();
            }

            // Client code works purely with interfaces, completely decoupled from concrete classes
            IButton button = factory.CreateButton();
            ITextBox textBox = factory.CreateTextBox();

            return Ok(new
            {
                ThemeMode = type?.ToUpper() ?? "LIGHT",
                ButtonAction = button.Render(),
                TextBoxAction = textBox.Display()
            });
        }
    }
}
