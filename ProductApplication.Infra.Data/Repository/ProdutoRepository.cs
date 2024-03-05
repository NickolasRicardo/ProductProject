using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Repository;
using ProductApplication.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ProductApplication.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
    
        private readonly DbSet<Produto> _dataSet;

        public ProdutoRepository(ProductAppContext context) : base(context)
        {
            _dataSet = _context.Set<Produto>();
        }

        public new async Task Delete(int id)
        {
            var item = await GetById(id);

            item.Situacao = false;

            _dataSet.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}