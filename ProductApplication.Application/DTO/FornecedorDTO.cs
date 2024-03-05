using ProductApplication.Domain.Entities;

namespace ProductApplication.Application.DTO
{
    public class FornecedorDTO : DTOBase
    {
        public string? Descricao { get; set; }

        public string? Cnpj { get; set; }

        public virtual ICollection<ProdutoDTO> Produtos { get; set; } = new List<ProdutoDTO>();
    }
}
