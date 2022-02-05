using Microsoft.EntityFrameworkCore;
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
            return _dbContext.Medikamente.Include(m => m.Verabreichungsprozess);
        }

        public Medikament Get(string id)
        {
            return _dbContext.Medikamente.Include(m => m.Verabreichungsprozess).First(m => m.Id == id);
        }

        public void Delete(string id)
        {
            var medikament = _dbContext.Medikamente.First(m => m.Id == id);
            _dbContext.Remove(medikament);
            _dbContext.SaveChanges();
        }

        public Medikament Insert(Medikament entity)
        {
            var newMedikament = new Medikament
            {
                Id = new Guid().ToString(),
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

            var oldMedikament = _dbContext.Medikamente.First(m => m.Id == entity.Id);
            oldMedikament.Name = entity.Name;
            oldMedikament.Einheit = entity.Einheit;
            oldMedikament.VerabreichungsprozessId = entity.VerabreichungsprozessId;
            oldMedikament.Verabreichungsprozess =
                _dbContext.Verabreichungsprozesse.FirstOrDefault(v => v.Id == entity.VerabreichungsprozessId);
            _dbContext.Update(oldMedikament);
            _dbContext.SaveChanges();
            return oldMedikament;
        }
    }
}
