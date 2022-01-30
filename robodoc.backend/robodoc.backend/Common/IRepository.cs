namespace robodoc.backend.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Delete(string id);
        void Insert(T entity);
        void Update(T entity);
    }
}
