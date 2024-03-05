using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Repository;
using ProductApplication.Domain.Interfaces.Services;

namespace ProductApplication.Domain.Services.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
