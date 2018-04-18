using Microsoft.AspNetCore.Mvc;

namespace OdeToFoodCore.Controllers
{
    [Route("controller")]
    public class AboutController : Controller
    {   
        [Route("")]
        public IActionResult Phone()
        {
            return Content("09000212134");
        }
        [Route("[action]")]
        public string Address()
        {
            return "USA";
        }
    }
}
