using Microsoft.EntityFrameworkCore;
using robodoc.backend.Data.Models;

namespace robodoc.backend
{
    public class SampleData
    {
        public SampleData(ModelBuilder modelBuilder)
        {
            var orte = new List<RoboOrt>();
            var activities = new List<RoboActivity>();

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
                modelBuilder.Entity<RoboOrt>().HasData(ort);
            }

            #region Activities
            activities.Add(new RoboActivity() {Id = Guid.NewGuid().ToString(), Name = "warten"});
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "einfahrt" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "verlassen" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "Medikament abgabe" });
            activities.Add(new RoboActivity() { Id = Guid.NewGuid().ToString(), Name = "Medikament aufnahme" });
            #endregion
        }
    }
}
