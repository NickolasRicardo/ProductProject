using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Infra.Data.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("Produto");

            builder.HasIndex(e => e.IdFornecedor, "fk_Produto_Fornecedor_idx");

            builder.Property(e => e.DataFabricacao).HasColumnType("datetime");
            builder.Property(e => e.DataValidade).HasColumnType("datetime");
            builder.Property(e => e.Descricao).HasMaxLength(45);

            builder.HasOne(d => d.IdFornecedorNavigation).WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Produto_Fornecedor");
        }
    }
}
