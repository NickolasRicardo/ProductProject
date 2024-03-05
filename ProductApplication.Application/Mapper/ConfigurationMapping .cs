using AutoMapper;
using ProductApplication.Application.DTO;
using ProductApplication.CrossCutting.Pagination;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Application.Mapper
{
    public class ConfigurationMapping: Profile
    {
        public ConfigurationMapping()
        {          
            CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
            CreateMap<PagedModel<Fornecedor>, PagedModel<FornecedorDTO>>().ReverseMap();

            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<PagedModel<Produto>, PagedModel<ProdutoDTO>>().ReverseMap();


        }
    }
}
