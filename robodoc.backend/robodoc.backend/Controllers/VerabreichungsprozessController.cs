using Microsoft.AspNetCore.Mvc;
using robodoc.backend.Services;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace robodoc.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerabreichungsprozessController : ControllerBase
    {
        private readonly IVerabreichungsprozessService _service;
        public VerabreichungsprozessController(IVerabreichungsprozessService service)
        {
            _service = service;
        }

        // GET: api/<VerabreichungsprozessController>
        [HttpGet]
        public IEnumerable<Verabreichungsprozess> Get()
        {
            return _service.GetVerabreichungsprozesses();
        }

        // GET api/<VerabreichungsprozessController>/5
        [HttpGet("{id}")]
        public Verabreichungsprozess Get(string id)
        {
            return _service.GetVerabreichungsprozessById(id);
        }
    }
}
