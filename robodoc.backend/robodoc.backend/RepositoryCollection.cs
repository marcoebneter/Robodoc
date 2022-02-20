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

        public IRepository<Verabreichungsprozess> VerabreichungsprozessRepository { get; private set; }
        public IRepository<Medikament> MedikamentRepository { get; private set; }
        public IRepository<Therapie> TherapieRepository { get; private set; }

        private ApplicationDbContext _dbContext { get; set; }
        public RepositoryCollection(ApplicationDbContext dbContext = null)
        {
            _dbContext = new ApplicationDbContextFactory().CreateDbContext(null);
            if (dbContext != null)
                _dbContext = dbContext;

            VerabreichungsprozessRepository = new VerabreichungsprozessRepository((_dbContext));
            MedikamentRepository = new MedikamentRepository(_dbContext);
            TherapieRepository = new TherapieRepository(_dbContext);
        }
    }
}
