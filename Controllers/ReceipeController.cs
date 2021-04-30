using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceipeController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDishes([FromQuery]int Count)
        {
            string[] dishes = { "Idli", "Dosa", "Pongal" };
            if (dishes.Any())
            {
                return NotFound();
            }
            return Ok(dishes.Take(Count));
        }

        [HttpDelete]
        public ActionResult DeleteReceipes()
        {
            bool badhappend = false;
            if (badhappend)
                return BadRequest();

            return NoContent();
        }
    }
}
