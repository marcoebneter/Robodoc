using Robodoc.Data.Models;

namespace robodoc.backend.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Guid id);
        void Delete(T entity);
        void Delete(Guid id);
        T Insert(T entity);
        T Update(T entity);
    }
}
