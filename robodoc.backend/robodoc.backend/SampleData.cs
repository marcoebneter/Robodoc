using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;
using Robodoc.Data.Models;

namespace robodoc.backend
{
    public sealed class SampleData
    {
        public SampleData(ModelBuilder builder)
        {
            var verabreichung = new List<Verabreichungsprozess>();
            var medikament = new List<Medikament>();
            var therapie = new List<Therapie>();
            var therapieMedi = new List<MedikamentTherapie>();
            var therapieVer = new List<Therapieverfahren>();
            var therapieDurch = new List<TherapieverfahrenDurchfuehrung>();
            var patient = new List<Patient>();
            var orte = new List<RoboOrt>();
            var activities = new List<RoboActivity>();

            #region Verabreichungsprozess
            verabreichung.Add(new Verabreichungsprozess() {Id = Guid.NewGuid(), Name = "oral"});
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "lingual" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "sublingual" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "intravenös" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "intraarteriell" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "intramuskulär" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "kutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "subkutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "intrakutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "perkutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "nasal" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "konjunktival" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "rektal" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid(), Name = "vaginal" });
            #endregion

            foreach (Verabreichungsprozess verabproz in verabreichung)
            {
                builder.Entity<Verabreichungsprozess>().HasData(verabproz);
            }

            // maximal 4 Medikamente
            #region Medikament
            medikament.Add(new Medikament() {Id = Guid.NewGuid(),
                Name = "Pantoloc", Einheit = Einheiten.Tabletten, VerabreichungsprozessId = verabreichung.Find(v => v.Name.Equals("lingual")).Id});
            medikament.Add(new Medikament() {Id = Guid.NewGuid(),
                Name = "Daflon", Einheit = Einheiten.Tabletten, VerabreichungsprozessId = verabreichung.Find(v => v.Name.Equals("lingual")).Id});
            #endregion

            foreach (Medikament med  in medikament)
            {
                builder.Entity<Medikament>().HasData(med);
            }

            therapie.Add(new Therapie() {Id = Guid.NewGuid(), Name = "eine Therapie"});

            foreach (Therapie therapy in therapie)
            {
                builder.Entity<Therapie>().HasData(therapy);
            }

            therapieMedi.Add(new MedikamentTherapie() 
                {Id = Guid.NewGuid(),
                    MedikamentId = medikament.Find(m => m.Name.Equals("Pantoloc")).Id, 
                    TherapieId = therapie.Find(t => t.Name.Equals("eine Therapie")).Id,
                    Menge = 5});

            foreach (MedikamentTherapie medikamentTherapy in therapieMedi)
            {
                builder.Entity<MedikamentTherapie>().HasData(medikamentTherapy);
            }

            patient.Add(new Patient() {Id = Guid.NewGuid(), Name = "Zingg", Vorname = "Joel", Anamnese = "isch en gaile siech", EintrittDatum = DateTime.Now});

            foreach (Patient pat in patient)
            {
                builder.Entity<Patient>().HasData(pat);
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
            orte.Add(new RoboOrt() {Id = Guid.NewGuid(), Name = "Apotheke"});
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
            activities.Add(new RoboActivity() {Id = Guid.NewGuid(), Name = "warten"});
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
