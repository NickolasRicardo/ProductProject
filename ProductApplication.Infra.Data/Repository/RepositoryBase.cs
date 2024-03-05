using ProductApplication.CrossCutting.Conditions;
using ProductApplication.CrossCutting.Pagination;
using ProductApplication.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ProductApplication.Infra.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dataSet;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task Add(T item)
        {
            await _dataSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = await GetById(id);
            _dataSet.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Find(params object[] keys)
        {
            return await _dataSet.FindAsync(keys);
        }

        public async Task<PagedModel<T>> Get(Expression<Func<T, bool>> predicate, QueryParam param)
        {
            return await _dataSet.Where(predicate).PaginateAsync(param);
        }

        public async Task<PagedModel<T>> GetAll(QueryParam param)
        {
            return await _dataSet.AsNoTracking().PaginateAsync(param);
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return await _dataSet.FirstOrDefaultAsync(predicate, default);
        }

        public async Task<T> GetById(int id)
        {
            return await _dataSet.FindAsync(id);
        }
        public async Task Update(T item)
        {
            _dataSet.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}

