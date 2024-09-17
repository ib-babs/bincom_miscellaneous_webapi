using Microsoft.AspNetCore.Mvc;
using MiscellaneousApi.Models;

namespace MiscellaneousApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {

        [HttpGet]
        public ActionResult<CVItem> GetCV()
        {

            return CVResult.GetCVItem();
        }
    }
}
