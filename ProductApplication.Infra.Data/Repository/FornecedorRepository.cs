using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Repository;
using ProductApplication.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ProductApplication.Infra.Data.Repository
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
    
        private readonly DbSet<Fornecedor> _dataSet;

        public FornecedorRepository(ProductAppContext context) : base(context)
        {
            _dataSet = _context.Set<Fornecedor>();
        }

    }
}