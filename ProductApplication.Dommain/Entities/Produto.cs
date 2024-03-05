namespace ProductApplication.Domain.Entities;

public class Produto : BaseEntity
{
    public string Descricao { get; set; } = null!;

    public DateTime? DataFabricacao { get; set; }

    public DateTime? DataValidade { get; set; }

    public int IdFornecedor { get; set; }

    public bool Situacao { get; set; }

    public virtual Fornecedor IdFornecedorNavigation { get; set; } = null!;
}
