
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "I like coffee!";
        }
    }
}
