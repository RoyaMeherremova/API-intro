using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase   //ControllerBase-icinde view olmur oncun istifade olunur
    {

        [HttpGet]    //API-da mecburidi Get.Post yazmaq method ustunde(tanimasi ucun)
        public IActionResult GetAll()
        {
            string[] names = { "Eli", "Jale", "Pervin" };
            return Ok(names);
        }

        [HttpGet]
        public IActionResult GetById(int? id)
        {
            if (id == null) return BadRequest();
            return Ok("Eli - " + ""  + id);
        }
    }
}
