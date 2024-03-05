
using ProductApplication.Domain.Entities;

namespace ProductApplication.Application.DTO
{
    public class ProdutoDTO : DTOBase
    {
        public string Descricao { get; set; } = null!;

        public DateTime? DataFabricacao { get; set; }

        public DateTime? DataValidade { get; set; }

        public int IdFornecedor { get; set; }

        public sbyte Situacao { get; set; } = 1;

        public virtual FornecedorDTO IdFornecedorNavigation { get; set; } = null!;

    }
}
