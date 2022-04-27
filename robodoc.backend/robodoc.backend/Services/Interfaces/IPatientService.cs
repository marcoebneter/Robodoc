using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetPatients();
        IEnumerable<Patient> GetPatientById(Guid id);
        void Delete(Guid id);
        Patient Insert(Patient entity);
        Patient Update(Patient entity);
    }
}
