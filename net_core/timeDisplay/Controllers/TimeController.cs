using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace timeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            DateTime ct = DateTime.Now;
            ct.ToString("MMM d yyyy");

            ViewBag.currTime = ct;
            return View();
        }
    }
}