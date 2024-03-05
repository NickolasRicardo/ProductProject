using ProductApplication.Application.DTO;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Application.Interfaces.Services
{
    public interface IProdutoApplicationService : IApplicationServiceBase<Produto, ProdutoDTO>
    {
    }
}
