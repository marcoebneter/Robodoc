using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;
        private readonly IMapper _mapper;

        public PatientController(IPatientService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _service.GetPatients();
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public IEnumerable<Patient> Get(Guid id)
        {
            return _service.GetPatientById(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public Patient Post([FromBody] Patient entity)
        {
            return _service.Insert(entity);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public Patient Put(Guid id, [FromBody] Patient entity)
        {
            return _service.Update(entity);
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}
