using ProductApplication.CrossCutting.Conditions;
using ProductApplication.CrossCutting.Pagination;
using System.Linq.Expressions;

namespace ProductApplication.Application.Interfaces.Services
{
    public interface IApplicationServiceBase<TEntity, TDto> where TEntity : class
                                                            where TDto : class
    {
        Task Add(TDto item);
        Task Update(TDto item);
        Task Delete(int id);
        Task<TDto> GetById(int id);
        Task<TDto> GetByFilter(Expression<Func<TEntity, bool>> predicate);
        Task<TDto> Find(params object[] keys);
        Task<PagedModel<TDto>> Get(Expression<Func<TEntity, bool>> predicate, QueryParam param);
        Task<PagedModel<TDto>> GetAll(QueryParam param);

    }
}
