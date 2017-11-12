using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MusicApi.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        [HttpGet]
        [Route("artists")]
        public IActionResult AllArtists()
        {
            return Json(allArtists);
        }

        [HttpGetAttribute]
        [Route("artists/name/{name}")]
        public IActionResult ArtistByName(string name)
        {
            return Json(allArtists.Where(a => a.ArtistName == name));
        }

        [HttpGetAttribute]
        [Route("artists/realname/{name}")]
        public IActionResult ArtistByRealName(string name)
        {
            return Json(allArtists.Where(a => a.RealName.Contains(name)));
        }

        [HttpGetAttribute]
        [Route("artists/hometown/{town}")]
        public IActionResult ArtistByHometown(string town)
        {
            return Json(allArtists.Where(a => a.Hometown.Contains(town)));
        }

        [HttpGetAttribute]
        [Route("artists/groupid/{id}")]
        public IActionResult ArtistByGroupId(int id)
        {
            return Json(allArtists.Where(a => a.GroupId == id));
        }
    }
}