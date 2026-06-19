using DesignPatterns.API._01_Creational_Patterns.Prototype;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrototypeController : ControllerBase
    {
        [HttpGet("duplicate-product")]
        public IActionResult DuplicateProduct()
        {
            // 1. Consider karein yeh original product database se load hua hai (Heavy Operation)
            Product originalProduct = new Product("iPhone 15", "Electronics", 250000);
            originalProduct.Features.Add("Dynamic Island");
            originalProduct.Features.Add("A16 Bionic Chip");

            // 2. Client chahta hai is product ko duplicate karein bina DB ko hit kiye
            // Hum memory me hi Prototype pattern ke zariye clone kar rahe hain
            Product duplicatedProduct = (Product)originalProduct.Clone();

            // 3. Duplicate product me thori si tabdeeli (Modification) kar dete hain
            duplicatedProduct.Name = "iPhone 15 Pro (Cloned Version)";
            duplicatedProduct.Price = 320000;
            duplicatedProduct.Features.Add("Titanium Body"); // Yeh sirf duplicate me add hoga

            return Ok(new
            {
                Message = "Product duplicated using Prototype Pattern successfully!",
                Original = originalProduct,
                ClonedAndModified = duplicatedProduct
            });
        }
    }
}
