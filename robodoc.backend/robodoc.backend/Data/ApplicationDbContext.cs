#define SAMPLEDATA

using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;
using Robodoc.Data.Models;

namespace robodoc.backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Medikament> Medikamente => Set<Medikament>();
        public DbSet<MedikamentTherapie> MedikamentTherapien => Set<MedikamentTherapie>();
        public DbSet<Therapie> Therapien => Set<Therapie>();
        public DbSet<Patient> Patienten => Set<Patient>();
        public DbSet<Personal> Personals => Set<Personal>();
        public DbSet<Therapieverfahren> Therapieverfahren => Set<Therapieverfahren>();
        public DbSet<TherapieverfahrenDurchfuehrung> Durchfuehrungen => Set<TherapieverfahrenDurchfuehrung>();
        public DbSet<RoboActivityStatus> RoboActivityStatus => Set<RoboActivityStatus>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<MedikamentTherapie>()
            //    .HasOne(mt => mt.Therapie)
            //    .WithMany(t => t.MedikamentTherapies)
            //    .HasForeignKey(mt => mt.TherapieId);
            //builder.Entity<MedikamentTherapie>()
            //    .HasOne(mt => mt.Medikament)
            //    .WithMany(m => m.MedikamentTherapies)
            //    .HasForeignKey(m => m.MedikamentId);
            //    .HasForeignKey(t => t.MedikamentId);
            //builder.Entity<RoboActivityStatus>().ToTable("RoboActivityStatus", e => e.IsTemporal());
            base.OnModelCreating(builder);

#if SAMPLEDATA
            var sampleData = new SampleData(builder);
#endif
        }
    }
}