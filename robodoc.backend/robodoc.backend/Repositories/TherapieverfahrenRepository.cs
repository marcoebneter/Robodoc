using Microsoft.EntityFrameworkCore;
using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class TherapieverfahrenRepository : BaseRepository, IRepository<Therapieverfahren>
    {
        public TherapieverfahrenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Therapieverfahren> GetAll()
        {
            return _dbContext.Therapieverfahren.Include(p => p.Patient).Include(t => t.Therapie);
        }

        public IEnumerable<Therapieverfahren> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Therapieverfahren entity)
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
