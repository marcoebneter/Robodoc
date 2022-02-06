using Robodoc.Data.Models;

namespace robodoc.backend.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(string id);
        void Delete(T entity);
        void Delete(string id);
        T Insert(T entity);
        T Update(T entity);
    }
}
