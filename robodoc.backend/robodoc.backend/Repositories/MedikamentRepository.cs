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
            return _dbContext.Medikamente.Where(m => true);
        }

        public IEnumerable<Medikament> Get(Guid id)
        {
            return _dbContext.Medikamente
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
            _dbContext.Medikamente.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Medikament Update(Medikament entity)
        {
            _dbContext.Medikamente.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
