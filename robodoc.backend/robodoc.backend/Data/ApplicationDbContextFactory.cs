using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace robodoc.backend.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = "server=127.0.0.1;port=3306;user=root;password=EtaXz3qoappCC0gzbi8r;database=robodoc";

            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString));

            return new ApplicationDbContext(options.Options);
        }
    }
}
