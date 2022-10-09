using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    //use the name of the controller itself
    //[Route("Noodles")]
    //[Route("[controller]")]
    //[Route("")]
    [Route("cocktails")]
    public class CocktailsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "It's time to drink something";
        }
    }
}
