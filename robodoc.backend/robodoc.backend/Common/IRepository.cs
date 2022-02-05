using Robodoc.Data.Models;

namespace robodoc.backend.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Delete(string id);
        T Insert(T entity);
        T Update(T entity);
    }
}
