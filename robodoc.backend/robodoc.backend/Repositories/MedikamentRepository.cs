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
            return _dbContext.Medikamente;
        }

        public Medikament Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Medikament entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Medikament entity)
        {
            throw new NotImplementedException();
        }
    }
}
