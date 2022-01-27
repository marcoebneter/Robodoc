using System.Data.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Robodoc.Data.Models;

namespace robodoc.backend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Verabreichungsprozess> Verabreichungsprozesse => Set<Verabreichungsprozess>();
        public DbSet<Medikament> Medikamente => Set<Medikament>();
        public DbSet<MedikamentTherapie> MedikamentTherapien => Set<MedikamentTherapie>();
        public DbSet<Therapie> Therapien => Set<Therapie>();
        public DbSet<Patient> Patienten => Set<Patient>();
        public DbSet<Therapieverfahren> Therapieverfahren => Set<Therapieverfahren>();
        public DbSet<TherapieverfahrenDurchfuehrung> Durchfuehrungen => Set<TherapieverfahrenDurchfuehrung>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}