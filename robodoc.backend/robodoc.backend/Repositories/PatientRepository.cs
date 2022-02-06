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

        public IEnumerable<Patient> Get(string id)
        {
            return _dbContext.Patienten.Where(p => p.Id.Equals(p));
        }

        public void Delete(Patient entity)
        {
            _dbContext.Patienten.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            Delete(Get(id).FirstOrDefault());
        }

        public Patient Insert(Patient entity)
        {
            var newPatient = new Patient()
            {
                Id = new Guid().ToString(),
                Name = entity.Name,
                Vorname = entity.Vorname,
                Anamnese = entity.Anamnese,
                EintrittDatum = entity.EintrittDatum,
                AustrittDatum = entity.AustrittDatum,
            };
            _dbContext.Patienten.Add(newPatient);
            _dbContext.SaveChanges();
            return newPatient;
        }

        public Patient Update(Patient entity)
        {
            if (entity == null || entity.Id == null)
            {
                return entity;
            }

            var oldPatient = Get(entity.Id).FirstOrDefault();
            oldPatient.Name = entity.Name;
            oldPatient.Vorname = entity.Vorname;
            oldPatient.Anamnese = entity.Anamnese;
            oldPatient.EintrittDatum = entity.EintrittDatum;
            oldPatient.AustrittDatum = entity.AustrittDatum;
            _dbContext.Patienten.Update(oldPatient);
            _dbContext.SaveChanges();
            return oldPatient;
        }
    }
}
