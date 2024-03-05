using ProductApplication.API.Controllers;
using ProductApplication.Application.DTO;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ProductApplication.API.Controllers
{
    public class ProdutoController : BaseController<Produto, ProdutoDTO>
    {
        private readonly IProdutoApplicationService _service;

        public ProdutoController(IProdutoApplicationService service) : base(service)
        {
            _service = service;
        }

    }
}
