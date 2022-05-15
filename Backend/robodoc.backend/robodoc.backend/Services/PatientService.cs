using robodoc.backend.Common;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

namespace robodoc.backend.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _repository;

        public PatientService(IRepository<Patient> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Patient> GetPatientById(Guid id)
        {
            return _repository.Get(id);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public Patient Insert(Patient entity)
        {
            return _repository.Insert(entity);
        }

        public Patient Update(Patient entity)
        {
            return _repository.Update(entity);
        }
    }
}
