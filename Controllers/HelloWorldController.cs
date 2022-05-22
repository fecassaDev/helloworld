using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public HelloMessage ShowMessage()
        {
            return new HelloMessage() { Message = "Hello World" };
        }
    }
}
