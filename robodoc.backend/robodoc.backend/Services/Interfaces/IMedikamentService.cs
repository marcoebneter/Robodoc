using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface IMedikamentService
    {
        IEnumerable<Medikament> GetMedikaments();
        Medikament GetMedikamentById(string id);
    }
}
