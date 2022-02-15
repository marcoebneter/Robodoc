using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class MedikamentRepository : BaseRepository, IRepository<Medikament>
    {
        public MedikamentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Medikament> GetAll()
        {
            return _dbContext.Medikamente
                .Include(m => m.Verabreichungsprozess);
        }

        public IEnumerable<Medikament> Get(Guid id)
        {
            return _dbContext.Medikamente
                .Include(m => m.Verabreichungsprozess)
                .Where(m => m.Id.Equals(id));
        }

        public void Delete(Medikament entity)
        {
            _dbContext.Medikamente.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Delete(Get(id).FirstOrDefault());
        }

        public Medikament Insert(Medikament entity)
        {
            var newMedikament = new Medikament
            {
                Id = Guid.NewGuid(),
                Name = entity.Name,
                Einheit = entity.Einheit,
                VerabreichungsprozessId = entity.VerabreichungsprozessId
            };
            _dbContext.Medikamente.Add(newMedikament);
            _dbContext.SaveChanges();
            return newMedikament;
        }

        public Medikament Update(Medikament entity)
        {
            if (entity == null || entity.Id == null)
            {
                return entity;
            }

            var oldMedikament = Get(entity.Id).FirstOrDefault();
            oldMedikament.Name = entity.Name;
            oldMedikament.Einheit = entity.Einheit;
            oldMedikament.VerabreichungsprozessId = entity.VerabreichungsprozessId;
            oldMedikament.Verabreichungsprozess =
                _dbContext.Verabreichungsprozesse.FirstOrDefault(v => v.Id == entity.VerabreichungsprozessId);
            _dbContext.Medikamente.Update(oldMedikament);
            _dbContext.SaveChanges();
            return oldMedikament;
        }
    }
}
