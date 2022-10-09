using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    //use the name of the controller itself
    //[Route("Noodles")]
    [Route("[controller]")]
    [Route("")]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}
