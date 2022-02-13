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
            var orte = new List<RoboOrt>();
            var activities = new List<RoboActivity>();

            #region Verabreichungsprozess
            verabreichung.Add(new Verabreichungsprozess() {Id = Guid.NewGuid().ToString(), Name = "oral"});
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "lingual" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "sublingual" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "intravenös" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "intraarteriell" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "intramuskulär" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "kutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "subkutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "intrakutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "perkutan" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "nasal" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "konjunktival" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "rektal" });
            verabreichung.Add(new Verabreichungsprozess() { Id = Guid.NewGuid().ToString(), Name = "vaginal" });
            #endregion

            foreach (Verabreichungsprozess verabproz in verabreichung)
            {
                builder.Entity<Verabreichungsprozess>().HasData(verabproz);
            }

            #region Medikament
            medikament.Add(new Medikament() {Id = Guid.NewGuid().ToString(),
                Name = "Pantoloc", Einheit = Einheiten.Tabletten, VerabreichungsprozessId = verabreichung.Find(v => v.Name.Equals("lingual")).Id});
            medikament.Add(new Medikament() {Id = Guid.NewGuid().ToString(),
                Name = "Daflon", Einheit = Einheiten.Tabletten, VerabreichungsprozessId = verabreichung.Find(v => v.Name.Equals("lingual")).Id});
            #endregion

            foreach (Medikament med  in medikament)
            {
                builder.Entity<Medikament>().HasData(med);
            }

            #region Orte
            orte.Add(new RoboOrt() {Id = Guid.NewGuid().ToString(), Name = "Apotheke"});
            orte.Add(new RoboOrt() { Id = Guid.NewGuid().ToString(), Name = "Parkposition" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid().ToString(), Name = "Zimmer 1" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid().ToString(), Name = "Zimmer 2" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid().ToString(), Name = "Zimmer 3" });
            orte.Add(new RoboOrt() { Id = Guid.NewGuid().ToString(), Name = "Zimmer 4" });
            #endregion

            foreach (RoboOrt ort in orte)
            {
                builder.Entity<RoboOrt>().HasData(ort);
            }

            #region Activities
            activities.Add(new RoboActivity() {Id = Guid.NewGuid().ToString(), Name = "warten"});
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "einfahren" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "verlassen" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "Medikament abgeben" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "Medikament aufnehmen" });
            #endregion

            foreach (RoboActivity activity in activities)
            {
                builder.Entity<RoboActivity>().HasData(activity);
            }
        }
    }
}
