using Microsoft.EntityFrameworkCore;
using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class TherapieRepository : BaseRepository, IRepository<Therapie>
    {
        public TherapieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Therapie> GetAll()
        {
            return _dbContext.Therapien.Include(t => t.MedikamentTherapies);
        }

        public IEnumerable<Therapie> Get(Guid id)
        {
            return _dbContext.Therapien.Include(t => t.MedikamentTherapies)
                .Where(t => t.Id.Equals(id));
        }

        public void Delete(Therapie entity)
        {
            _dbContext.Therapien.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Delete(Get(id).FirstOrDefault());
        }

        public Therapie Insert(Therapie entity)
        {
            _dbContext.Therapien.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Therapie Update(Therapie entity)
        {
            _dbContext.Therapien.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
