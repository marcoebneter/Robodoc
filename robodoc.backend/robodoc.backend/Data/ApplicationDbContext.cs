using System.Data.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;
using Robodoc.Data.Models;

namespace robodoc.backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Verabreichungsprozess> Verabreichungsprozesse => Set<Verabreichungsprozess>();
        public DbSet<Medikament> Medikamente => Set<Medikament>();
        //public DbSet<MedikamentTherapie> MedikamentTherapien => Set<MedikamentTherapie>();
        //public DbSet<Therapie> Therapien => Set<Therapie>();
        //public DbSet<Patient> Patienten => Set<Patient>();
        //public DbSet<Therapieverfahren> Therapieverfahren => Set<Therapieverfahren>();
        //public DbSet<TherapieverfahrenDurchfuehrung> Durchfuehrungen => Set<TherapieverfahrenDurchfuehrung>();
        public DbSet<RoboActivityStatus> RoboActivityStatus => Set<RoboActivityStatus>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medikament>()
                .HasOne(e => e.Verabreichungsprozess)
                .WithMany(v => v.Medikamente);
            base.OnModelCreating(modelBuilder);
        }
    }
}