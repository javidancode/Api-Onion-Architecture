using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        { 
            List<Group> groups = new List<Group>();

            Group group = new()
            {
                Id = 1,
                Name = "P130",
                Capacity= 100,
            };

            Group group2 = new()
            {
                Id = 2,
                Name = "P131",
                Capacity = 10,
            };

            Group group3 = new()
            {
                Id = 3,
                Name = "P170",
                Capacity = 15,
            };


            groups.Add(group);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);
        }
    }
}
