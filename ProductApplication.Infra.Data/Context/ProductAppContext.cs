using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductApplication.Domain.Entities;
using ProductApplication.Infra.Data.Config;

namespace ProductApplication.Infra.Data.Context;

public partial class ProductAppContext : DbContext
{
    public ProductAppContext()
    {
    }

    public ProductAppContext(DbContextOptions<ProductAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
      
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Produto>(new ProdutoConfig().Configure);
        modelBuilder.Entity<Fornecedor>(new FornecedorConfig().Configure);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
