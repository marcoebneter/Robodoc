using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        private readonly IMapper _mapper;

        public MedikamentController(IMedikamentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<MedikamentController>
        [HttpGet]
        public IEnumerable<Medikament> Get()
        {
            return _service.GetMedikaments();
        }

        // GET api/<MedikamentController>/5
        [HttpGet("{id}")]
        public IEnumerable<Medikament> Get(Guid id)
        {
            return _service.GetMedikamentById(id);
        }

        // POST api/<MedikamentController>
        [HttpPost]
        public Medikament Post([FromBody] Medikament entity)
        {
            return _service.Insert(_mapper.Map<Medikament>(entity));
        }

        // PUT api/<MedikamentController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Medikament entity)
        {
            _service.Update(_mapper.Map<Medikament>(entity));
        }

        // DELETE api/<MedikamentController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}
