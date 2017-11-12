using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public string Index()
        {
            return "What up with it?!";
        }

        //POST method
        // [HttpPost]
        // [Route("")]
        // public IActionResult Other()
        // {

        // }
    }
}