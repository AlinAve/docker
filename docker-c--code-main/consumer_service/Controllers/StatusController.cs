
using Microsoft.AspNetCore.Mvc;

namespace CSharpService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("C# Service Running");
    }
}
