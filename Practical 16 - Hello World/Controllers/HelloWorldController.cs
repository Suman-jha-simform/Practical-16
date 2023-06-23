using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practical_16___Hello_World.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        // api/HelloWorld
        public IActionResult Get()
        {
            _logger.LogInformation("Hello World api is called.");
            return Ok("Hello world");
        }
    }
}
