using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        [Route("{FirstName}/{LastName}/{Age}/{FavColor}")]
        public IActionResult Index(string FirstName, string LastName, string Age, string FavColor)
        {
            var card = new {
                FirstName,
                LastName,
                Age,
                FavColor
            };
            return Json(card);
        }
    }
}