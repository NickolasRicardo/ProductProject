using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Repository;
using ProductApplication.Domain.Interfaces.Services;

namespace ProductApplication.Domain.Services.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
