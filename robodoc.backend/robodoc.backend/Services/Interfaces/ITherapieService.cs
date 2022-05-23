using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface ITherapieService
    {
        IEnumerable<Therapie> GetTherapies();
        IEnumerable<Therapie> GetTherapieById(Guid id);
        void Delete(Guid id);
        Therapie Insert(Therapie entity);
        Therapie Update(Therapie entity);

    }
}
