using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using robodoc.backend.Common.Mapper;
using robodoc.backend.Controllers.DTO;
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
        public IEnumerable<MedikamentDTO> Get()
        {
            return _service.GetMedikaments().Select(medikament => _mapper.Map<MedikamentDTO>(medikament));
        }

        // GET api/<MedikamentController>/5
        [HttpGet("{id}")]
        public IEnumerable<MedikamentDTO> Get(string id)
        {
            return _service.GetMedikamentById(id).Select(medikament => _mapper.Map<MedikamentDTO>(medikament));
        }

        // POST api/<MedikamentController>
        [HttpPost]
        public Medikament Post([FromBody] MedikamentDTO entity)
        {
            return _service.Insert(_mapper.Map<Medikament>(entity));
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
            _service.Delete(id);
        }
    }
}
