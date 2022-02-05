using Microsoft.EntityFrameworkCore;
using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class PatientRepository : BaseRepository, IRepository<Patient>
    {
        public PatientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Patient> GetAll()
        {
            return _dbContext.Patienten;
        }

        public Patient Get(string id)
        {
            return _dbContext.Patienten.First(p => p.Id == id);
        }

        public void Delete(string id)
        {
            var patient = _dbContext.Patienten.First(p => p.Id == id);
            _dbContext.Remove(patient);
            _dbContext.SaveChanges();
        }

        public Patient Insert(Patient entity)
        {
            throw new NotImplementedException();
        }

        public Patient Update(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}
