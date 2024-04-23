using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {


        [Route("{name}")]
        [HttpGet]
        public string GetGreetings(string name)
        {
            return $"Hello {name} , welcome to web api";
        }


    }
}
