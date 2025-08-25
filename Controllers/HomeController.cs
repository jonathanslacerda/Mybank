using Microsoft.AspNetCore.Mvc;

namespace MyBank.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Welcome to MyBank API!");
        }
        
        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            return Ok("API is running smoothly!");
        }
        
        [HttpGet("version")]
        public IActionResult Version()
        {
            return Ok("MyBank API Version 1.0.0");
        }
    }
}
