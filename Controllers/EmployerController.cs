using Microsoft.AspNetCore.Mvc;

namespace employer_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("PINTO");
        }
    }
}
