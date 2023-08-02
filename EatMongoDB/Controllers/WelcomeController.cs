using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EatMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "I need TP for my bunghole";
        }
    }
}
