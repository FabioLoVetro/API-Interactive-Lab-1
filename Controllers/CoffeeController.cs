
using API_Interactive_Lab_1.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string GetLover()
        {
            return "I like coffee!";
        }

        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            if (name == null)
                return new Coffee(-1,"Latte");
            else
                return new Coffee(new Random().Next(), name);
        }
    }
}
