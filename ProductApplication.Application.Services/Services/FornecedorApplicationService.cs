using AutoMapper;
using ProductApplication.Application.DTO;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.Domain.Entities;
using ProductApplication.Domain.Interfaces.Services;

namespace ProductApplication.Application.Services.Services
{
    public class FornecedorApplicationService : ApplicationServiceBase<Fornecedor, FornecedorDTO>, IFornecedorApplicationService
    {
        private readonly IFornecedorService _service;
        private readonly IMapper _mapper;

        public FornecedorApplicationService(IFornecedorService service , IMapper mapper) : base(service, mapper)
        {
            _service = service;
            _mapper = mapper;
        }

    }
       
   
}
