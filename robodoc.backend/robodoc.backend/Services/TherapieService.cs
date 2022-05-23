using robodoc.backend.Common;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

namespace robodoc.backend.Services
{
    public class TherapieService : ITherapieService
    {
        private readonly IRepository<Therapie> _repository;

        public TherapieService(IRepository<Therapie> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Therapie> GetTherapies()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Therapie> GetTherapieById(Guid id)
        {
            return _repository.Get(id);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public Therapie Insert(Therapie entity)
        {
            return _repository.Insert(entity);
        }

        public Therapie Update(Therapie entity)
        {
            return _repository.Update(entity);
        }
    }
}
