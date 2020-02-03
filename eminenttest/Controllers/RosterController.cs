using Microsoft.AspNetCore.Mvc;

namespace eminenttest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RosterController : ControllerBase
    {
        // GET: api/Roster
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET: api/Roster/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Roster
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /*Contoler method to add a colour from the roster*/
        [HttpPost]
        [Route("api/Router/{id}/Colour")]
        public IActionResult AddColour()
        {

        }


        [HttpDelete]
        /*Controller method to delete a colour from the roster*/
        [Route("api/Router/{id}/Colour")]
        public IActionResult DeleteColour()
        {

        }


        /*Controller method to delete roster*/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
