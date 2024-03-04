namespace ProductApplication.Domain.Entities;

public partial class Fornecedor : BaseEntity
{

    public string? Descricao { get; set; }

    public string? Cnpj { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
