using System.Linq.Expressions;

namespace learn.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Remove(T entity);

        IEnumerable<T> GetAll(Expression<Func<T,bool>>? filter = null);

        T Get(Expression<Func<T,bool>>? filter = null);
    }
}
