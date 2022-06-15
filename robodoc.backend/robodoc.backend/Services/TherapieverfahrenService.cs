using robodoc.backend.Common;
using robodoc.backend.Repositories;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

namespace robodoc.backend.Services
{
    public class TherapieverfahrenService : ITherapieverfahrenService
    {
        private readonly IRepository<Therapieverfahren> _repository;

        public TherapieverfahrenService(IRepository<Therapieverfahren> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Therapieverfahren> GetTherapieverfahren()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Therapieverfahren> GetTherapieverfahrenById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Therapieverfahren Insert(Therapieverfahren entity)
        {
            throw new NotImplementedException();
        }

        public Therapieverfahren Update(Therapieverfahren entity)
        {
            throw new NotImplementedException();
        }
    }
}
