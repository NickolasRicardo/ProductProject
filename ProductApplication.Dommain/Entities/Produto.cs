namespace ProductApplication.Domain.Entities;

public partial class Produto : BaseEntity
{
    public string Descricao { get; set; } = null!;

    public DateTime? DataFabricacao { get; set; }

    public DateTime? DataValidade { get; set; }

    public int IdFornecedor { get; set; }

    public sbyte Situacao { get; set; }

    public virtual Fornecedor IdFornecedorNavigation { get; set; } = null!;
}
