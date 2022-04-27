using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface IMedikamentService
    {
        IEnumerable<Medikament> GetMedikaments();
        IEnumerable<Medikament> GetMedikamentById(Guid id);
        void Delete(Guid id);
        Medikament Insert(Medikament entity);
        Medikament Update(Medikament entity);
    }
}
