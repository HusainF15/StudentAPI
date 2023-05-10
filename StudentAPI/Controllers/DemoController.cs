using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Greetings()
        {
            //if
            return "Hello BiBf,"; //200 , 
            //else
            return NoContent();
        }

     
    }
}
