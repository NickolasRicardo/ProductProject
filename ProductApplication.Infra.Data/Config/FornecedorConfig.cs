using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Infra.Data.Config
{
    public class FornecedorConfig : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("Fornecedor");

            builder.Property(e => e.Cnpj)
                .HasMaxLength(45)
                .HasColumnName("CNPJ");

            builder.Property(e => e.Descricao).HasMaxLength(45);
            builder.Navigation(p => p.Produtos).AutoInclude();
        }
    }
}
