using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MusicApi.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
        }

        [HttpGet]
        [Route("groups")]
        public IActionResult AllGroups()
        {
            return Json(allGroups);
        }

        [HttpGet]
        [Route("groups/name/{name}")]
        public IActionResult GroupsByName(string name)
        {
            return Json(allGroups.Where(g => g.GroupName == name));
        }

        [HttpGet]
        [Route("groups/id/{id}")]
        public IActionResult GroupsById(int id)
        {
            return Json(allGroups.Where(g => g.Id == id));
        }
    }
}