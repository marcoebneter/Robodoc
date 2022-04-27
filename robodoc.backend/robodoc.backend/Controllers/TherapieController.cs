using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Controllers.DTO;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapieController : ControllerBase
    {
        private readonly ITherapieService _service;
        private readonly IMapper _mapper;

        public TherapieController(ITherapieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<TherapieController>
        [HttpGet]
        public IEnumerable<Therapie> Get()
        {
            return _service.GetMedikaments();
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
