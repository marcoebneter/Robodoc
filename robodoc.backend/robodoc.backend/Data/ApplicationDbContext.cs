#define SAMPLEDATA

using System.Data.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;
using Robodoc.Data.Models;

namespace robodoc.backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Medikament> Medikamente => Set<Medikament>();
        public DbSet<MedikamentTherapie> MedikamentTherapien => Set<MedikamentTherapie>();
        public DbSet<Therapie> Therapien => Set<Therapie>();
        public DbSet<Patient> Patienten => Set<Patient>();
        public DbSet<Therapieverfahren> Therapieverfahren => Set<Therapieverfahren>();
        public DbSet<TherapieverfahrenDurchfuehrung> Durchfuehrungen => Set<TherapieverfahrenDurchfuehrung>();
        public DbSet<RoboOrt> RoboOrts => Set<RoboOrt>();
        public DbSet<RoboActivity> RoboActivities => Set<RoboActivity>();
        public DbSet<RoboActivityStatus> RoboActivityStatus => Set<RoboActivityStatus>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoboActivityStatus>().ToTable("RoboActivityStatus", e => e.IsTemporal());
            builder.Entity<TherapieverfahrenDurchfuehrung>();
            builder.Entity<Therapieverfahren>()
                .HasOne(t => t.Zustaendigkeit);
            builder.Entity<TherapieverfahrenDurchfuehrung>()
                .HasOne(t => t.Therapieverfahren)
                .WithMany(t => t.TherapieverfahrenDurchfuehrungen)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Therapieverfahren>()
                .HasOne(p => p.Patient)
                .WithMany(t => t.Therapieverfahren);
            builder.Entity<Therapieverfahren>()
                .HasOne(t => t.Therapie)
                .WithMany(t => t.Therapieverfahren);
            builder.Entity<MedikamentTherapie>()
                .HasOne(t => t.Therapie)
                .WithMany(m => m.MedikamentTherapies);
            builder.Entity<MedikamentTherapie>()
                .HasOne(m => m.Medikament)
                .WithMany(m => m.MedikamentTherapies);
            builder.Entity<RoboActivityStatus>()
                .HasOne(a => a.RoboOrt)
                .WithMany(o => o.ActivityStatuses);
            builder.Entity<RoboActivityStatus>()
                .HasOne(a => a.RoboActivity)
                .WithMany(a => a.ActivityStatuses);
            base.OnModelCreating(builder);

#if SAMPLEDATA
            var sampleData = new SampleData(builder);
#endif
        }
    }
}