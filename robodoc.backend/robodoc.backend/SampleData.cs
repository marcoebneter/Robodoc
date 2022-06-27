using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;
using Robodoc.Data.Models;

namespace robodoc.backend
{
    public sealed class SampleData
    {
        public SampleData(ModelBuilder builder)
        {
            var medikament = new List<Medikament>();
            var therapie = new List<Therapie>();
            var therapieMedi = new List<MedikamentTherapie>();
            var therapieVer = new List<Therapieverfahren>();
            var therapieDurch = new List<TherapieverfahrenDurchfuehrung>();
            var patient = new List<Patient>();
            var personal = new List<Personal>();
            var orte = new List<RoboOrt>();
            var activities = new List<RoboActivity>();

            // maximal 4 Medikamente
            #region Medikament
            medikament.Add(new Medikament()
            {
                Id = Guid.NewGuid(),
                Name = "Pantoloc",
                Einheit = Einheiten.Tabletten,
                Verabreichungsprozess = Verabreichungsprozesse.lingual
            });
            medikament.Add(new Medikament()
            {
                Id = Guid.NewGuid(),
                Name = "Daflon",
                Einheit = Einheiten.Tabletten,
                Verabreichungsprozess = Verabreichungsprozesse.kutan
            });
            medikament.Add(new Medikament()
            {
                Id = Guid.NewGuid(),
                Name = "Vivotif",
                Einheit = Einheiten.Kapseln,
                Verabreichungsprozess = Verabreichungsprozesse.lingual
            });
            medikament.Add(new Medikament()
            {
                Id = Guid.NewGuid(),
                Name = "Hepatec",
                Einheit = Einheiten.Ampullen,
                Verabreichungsprozess = Verabreichungsprozesse.intravenoes
            });
            #endregion

            foreach (Medikament med in medikament)
            {
                builder.Entity<Medikament>().HasData(med);
            }

            #region Therapie
            therapie.Add(new Therapie() { Id = Guid.NewGuid(), Name = "Diät" });
            therapie.Add(new Therapie() { Id = Guid.NewGuid(), Name = "Elektrotherapie" });
            therapie.Add(new Therapie() { Id = Guid.NewGuid(), Name = "Hydrotherapie" });
            therapie.Add(new Therapie() { Id = Guid.NewGuid(), Name = "Atlaslogie" });
            #endregion

            foreach (Therapie therapy in therapie)
            {
                builder.Entity<Therapie>().HasData(therapy);
            }

            #region MedikamentTerapie
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Pantoloc")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Diät")).Id,
                Menge = 5
            });
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Daflon")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Diät")).Id,
                Menge = 3
            });
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Daflon")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Elektrotherapie")).Id,
                Menge = 2
            });
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Vivotif")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Elektrotherapie")).Id,
                Menge = 1
            });
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Vivotif")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Hydrotherapie")).Id,
                Menge = 5
            });
            therapieMedi.Add(new MedikamentTherapie()
            {
                Id = Guid.NewGuid(),
                MedikamentId = medikament.Find(m => m.Name.Equals("Hepatec")).Id,
                TherapieId = therapie.Find(t => t.Name.Equals("Atlaslogie")).Id,
                Menge = 2
            });
            #endregion

            foreach (MedikamentTherapie medikamentTherapy in therapieMedi)
            {
                builder.Entity<MedikamentTherapie>().HasData(medikamentTherapy);
            }

            #region Patienten
            patient.Add(new Patient() { Id = Guid.NewGuid(), Name = "Zingg", Vorname = "Joel", Anamnese = "Velounfall", EintrittDatum = DateTime.Now });
            #endregion

            foreach (Patient pat in patient)
            {
                builder.Entity<Patient>().HasData(pat);
            }

            #region Personal
            personal.Add(new Personal()
            {
                Id = Guid.NewGuid(),
                Username = "Marco",
                Password = "marco",
                IsArzt = true
            });
            #endregion

            foreach (Personal pers in personal)
            {
                builder.Entity<Personal>().HasData(pers);
            }

            //therapieVer.Add(new Therapieverfahren() 
            //    {Id = Guid.NewGuid(),
            //        PatientId = patient.Find(p => p.Name.Equals("Zingg")).Id,
            //        TherapieId = therapie.Find(t => t.Name.Equals("eine Therapie")).Id,
            //        StartDate = DateTime.Today,
            //        EndDate = DateTime.Today.AddDays(5),
            //        Intervall = TimeSpan.FromHours(1),
            //        PersonalId = Guid.NewGuid().ToString()
            //    });

            //foreach (Therapieverfahren therapieverfahren in therapieVer)
            //{
            //    builder.Entity<Therapieverfahren>().HasData(therapieverfahren);
            //}

            //therapieDurch.Add(new TherapieverfahrenDurchfuehrung() 
            //    { Id = Guid.NewGuid(),
            //        TherapieverfahrenId = therapieVer.Find(t => t.PatientId.Equals(patient.Find(p => p.Name.Equals("Zingg")).Id)).Id,
            //        Zeitpunkt = DateTime.Now});

            //foreach (TherapieverfahrenDurchfuehrung durchfuehrung in therapieDurch)
            //{
            //    builder.Entity<TherapieverfahrenDurchfuehrung>().HasData(durchfuehrung);
            //}

            #region Orte
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Apotheke" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Parkposition" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Zimmer 1" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Zimmer 2" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Zimmer 3" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid(), Name = "Zimmer 4" });
            #endregion

            foreach (RoboOrt ort in orte)
            {
                builder.Entity<RoboOrt>().HasData(ort);
            }

            #region Activities
            activities.Add(new RoboActivity() { Id = Guid.NewGuid(), Name = "warten" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid(), Name = "einfahren" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid(), Name = "verlassen" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid(), Name = "Medikament abgeben" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid(), Name = "Medikament aufnehmen" });
            #endregion

            foreach (RoboActivity activity in activities)
            {
                builder.Entity<RoboActivity>().HasData(activity);
            }
        }
    }
}
