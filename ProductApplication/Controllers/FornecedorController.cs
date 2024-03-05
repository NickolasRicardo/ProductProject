using ProductApplication.Application.DTO;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.Domain.Entities;

namespace ProductApplication.API.Controllers
{
    public class FornecedorController : BaseController<Fornecedor, FornecedorDTO>
    {
        private readonly IFornecedorApplicationService _service;

        public FornecedorController(IFornecedorApplicationService service) : base(service)
        {
            _service = service;
        }

    }
}
