using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapieverfahrenController : ControllerBase
    {
        private readonly ITherapieverfahrenService _service;

        public TherapieverfahrenController(ITherapieverfahrenService service)
        {
            _service = service;
        }

        // GET: api/<TherapieverfahrenController>
        [HttpGet]
        public IEnumerable<Therapieverfahren> Get()
        {
            return _service.GetTherapieverfahren();
        }

        // GET api/<TherapieverfahrenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TherapieverfahrenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TherapieverfahrenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TherapieverfahrenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
