using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private static IList<string> _bikes = new List<string>() { "BMW", "Dugati", "Yamaha", "Bajaj", "TVS", "RoyalEnfield", "JAWA" };
        // GET: api/<BikesController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return _bikes.ToList();
            //return new string[] { "BMW", "Dugati", "Yamaha", "Bajaj", "TVS", "RoyalEnfield", "JAWA" };
            //return Ok(_bikes);
            return _bikes.ToList();
        }

        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public /*ActionResult<string>*/ string Get(int id)
        {
            //if (id < 0 || id >= _bikes.Count)
            //{
            //    return NotFound("Bike not found");
            //}
            //return Ok(_bikes[id]);
            //return "value";
            return _bikes[id];
        }

        // POST api/<BikesController>
        [HttpPost]
        public /*ActionResult*/ void Post([FromBody] string value)
        {
            //if (string.IsNullOrEmpty(value))
            //{
            //    return BadRequest("Bike name cannot be empty.");
            //}

            //_bikes.Add(value); // Add the new bike to the list.
            //return CreatedAtAction(nameof(Get), new { id = _bikes.Count - 1 }, value);
            _bikes.Add(value);
        }

        // PUT api/<BikesController>/5
        [HttpPut("{id}")]
        public /*ActionResult*/ void Put(int id, [FromBody] string value)
        {
            //if (id < 0 || id >= _bikes.Count)
            //{
            //    return NotFound("Bike not found");
            //}

            //if (string.IsNullOrEmpty(value))
            //{
            //    return BadRequest("Bike name cannot be empty.");
            //}

            _bikes[id] = value;
            //return NoContent();
        }

        // DELETE api/<BikesController>/5
        [HttpDelete("{id}")]
        public /*ActionResult*/ void Delete(int id)
        {
            //if (id < 0 || id >= _bikes.Count)
            //{
            //    return NotFound("Bike not found");
            //}

            _bikes.RemoveAt(id);
            //return NoContent();
        }
    }
}
