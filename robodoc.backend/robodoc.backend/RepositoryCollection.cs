using robodoc.backend.Common;
using robodoc.backend.Data;
using robodoc.backend.Repositories;
using Robodoc.Data.Models;

namespace robodoc.backend
{
    public class RepositoryCollection
    {
        private static RepositoryCollection _instance { get; set; }
        public static RepositoryCollection Instance => _instance ??= new RepositoryCollection();

        public IRepository<Medikament> MedikamentRepository { get; private set; }

        private ApplicationDbContext _dbContext { get; set; }
        public RepositoryCollection(ApplicationDbContext dbContext = null)
        {
            _dbContext = new ApplicationDbContextFactory().CreateDbContext(null);
            if (dbContext != null)
                _dbContext = dbContext;

            MedikamentRepository = new MedikamentRepository(_dbContext);
        }
    }
}
