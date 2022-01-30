using robodoc.backend.Data;

namespace robodoc.backend.Repositories
{
    public class BaseRepository
    {
        protected ApplicationDbContext _dbContext { get; set; }

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
