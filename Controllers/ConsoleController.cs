using Microsoft.AspNetCore.Mvc;

namespace MiscellaneousApi.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class ConsoleController: ControllerBase
    {
        [HttpGet]
        public ActionResult<string> HelloWorld()
        {
            return "Hello World!";
        }
    }
}
