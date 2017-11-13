using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace pokeInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int id)
        {
            // PokeObject PokeData;
            WebRequest.GetPokemonDataAsync(id, data =>
            {
                PokeObject PokeData = new PokeObject(data);
                ViewBag.Pokemon = PokeData;
            }).Wait();
            return View();
        }
    }
}
