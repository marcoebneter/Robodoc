using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface IMedikamentService
    {
        IEnumerable<Medikament> GetMedikaments();
        IEnumerable<Medikament> GetMedikamentById(string id);
        void Delete(string id);
        Medikament Insert(Medikament entity);
        Medikament Update(Medikament entity);
    }
}
