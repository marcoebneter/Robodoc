using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Controllers.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapieController : ControllerBase
    {
        // GET: api/<TherapieController>
        [HttpGet]
        public IEnumerable<TherapieDTO> Get()
        {
            return null;
        }

        // GET api/<TherapieController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TherapieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TherapieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TherapieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
