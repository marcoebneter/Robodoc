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

        public IEnumerable<Patient> Get(Guid id)
        {
            return _dbContext.Patienten.Where(p => p.Id.Equals(p));
        }

        public void Delete(Patient entity)
        {
            _dbContext.Patienten.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Delete(Get(id).FirstOrDefault());
        }

        public Patient Insert(Patient entity)
        {
            _dbContext.Patienten.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Patient Update(Patient entity)
        {
            _dbContext.Patienten.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
