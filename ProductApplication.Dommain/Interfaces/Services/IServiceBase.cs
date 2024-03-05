using ProductApplication.CrossCutting.Conditions;
using ProductApplication.CrossCutting.Pagination;
using System.Linq.Expressions;

namespace ProductApplication.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        Task Add(T item);
        Task Update(T item);
        Task Delete(int id);
        Task<T> GetById(int id);
        Task<T> GetByFilter(Expression<Func<T, bool>> predicate);
        Task<T> Find(params object[] keys);
        Task<PagedModel<T>> Get(Expression<Func<T, bool>> predicate, QueryParam param);
        Task<PagedModel<T>> GetAll(QueryParam param);       
    }
}
