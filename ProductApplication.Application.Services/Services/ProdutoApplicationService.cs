using AutoMapper;
using ProductApplication.Application.DTO;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Services;

namespace ProductApplication.Application.Services.Services
{
    public class ProdutoApplicationService : ApplicationServiceBase<Produto, ProdutoDTO>, IProdutoApplicationService
    {
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;

        public ProdutoApplicationService(IProdutoService service , IMapper mapper) : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }

    }
       
   
}
