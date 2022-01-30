using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace robodoc.backend.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=(local);Database=robodoc;MultipleActiveResultSets=True;Trusted_Connection=True";

            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(connectionString);

            return new ApplicationDbContext(options.Options);
        }
    }
}
