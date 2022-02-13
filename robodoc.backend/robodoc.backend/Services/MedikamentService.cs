using robodoc.backend.Common;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

namespace robodoc.backend.Services
{
    public class MedikamentService : IMedikamentService
    {
        private readonly IRepository<Medikament> _repository;

        public MedikamentService(IRepository<Medikament> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Medikament> GetMedikaments()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Medikament> GetMedikamentById(string id)
        {
            return _repository.Get(id);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public Medikament Insert(Medikament entity)
        {
            return _repository.Insert(entity);
        }

        public Medikament Update(Medikament entity)
        {
            return _repository.Update(entity);
        }
    }
}
