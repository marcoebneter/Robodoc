using robodoc.backend.Common;
using robodoc.backend.Data;
using Robodoc.Data.Models;

namespace robodoc.backend.Repositories
{
    public class VerabreichungsprozessRepository : BaseRepository, IRepository<Verabreichungsprozess>
    {
        public VerabreichungsprozessRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Verabreichungsprozess> GetAll()
        {
            return _dbContext.Verabreichungsprozesse;
        }

        public Verabreichungsprozess Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Verabreichungsprozess entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Verabreichungsprozess entity)
        {
            throw new NotImplementedException();
        }
    }
}
