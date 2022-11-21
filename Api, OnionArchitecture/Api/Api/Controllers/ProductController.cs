using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            string name = "Cavidan" + id;
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string>() {"Cavidan","Togrul","Orxan","Azer","Esqin","Huseyn"};
            return Ok(names);
        }
    }
}
