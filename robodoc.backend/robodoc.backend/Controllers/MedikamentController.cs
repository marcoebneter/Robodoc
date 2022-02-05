using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedikamentController : ControllerBase
    {
        private readonly IMedikamentService _service;
        public MedikamentController(IMedikamentService service)
        {
            _service = service;
        }

        // GET: api/<MedikamentController>
        [HttpGet]
        public IEnumerable<Medikament> Get()
        {
            return _service.GetMedikaments();
        }

        // GET api/<MedikamentController>/5
        [HttpGet("{id}")]
        public Medikament Get(string id)
        {
            return _service.GetMedikamentById(id);
        }

        // POST api/<MedikamentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedikamentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedikamentController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
