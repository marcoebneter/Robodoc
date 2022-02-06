using robodoc.backend.Common;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

namespace robodoc.backend.Services
{
    public class VerabreichungsprozessService : IVerabreichungsprozessService
    {
        private readonly IRepository<Verabreichungsprozess> _repository;
        public VerabreichungsprozessService(IRepository<Verabreichungsprozess> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Verabreichungsprozess> GetVerabreichungsprozesses()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Verabreichungsprozess> GetVerabreichungsprozessById(string id)
        {
            return _repository.Get(id);
        }
    }
}
