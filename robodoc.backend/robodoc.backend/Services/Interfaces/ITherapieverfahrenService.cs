using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface ITherapieverfahrenService
    {
        IEnumerable<Therapieverfahren> GetTherapieverfahren();
        IEnumerable<Therapieverfahren> GetTherapieverfahrenById(Guid id);
        void Delete(Guid id);
        Therapieverfahren Insert(Therapieverfahren entity);
        Therapieverfahren Update(Therapieverfahren entity);

    }
}
