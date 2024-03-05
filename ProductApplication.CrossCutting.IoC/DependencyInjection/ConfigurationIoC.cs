using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.Application.Services.Services;
using ProductApplication.Domain.Interfaces.Repository;
using ProductApplication.Domain.Interfaces.Services;
using ProductApplication.Domain.Services.Services;
using ProductApplication.Infra.Data.Context;
using ProductApplication.Infra.Data.Repository;

namespace ProductApplication.CrossCutting.IoC.DependencyInjection
{
    public class ConfigurationIoC
    {

        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            string conn = configuration.GetConnectionString("DefaultConnection"); ;
            
            services.AddDbContext<ProductAppContext>(options => options.UseMySql(conn, ServerVersion.AutoDetect(conn)));

            RegisterServices(services);
            RegisterApplication(services);
            RegisterRepositories(services);
        }


        private static void RegisterServices(IServiceCollection services)
        {
           services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
           services.AddScoped<IProdutoService, ProdutoService>();
           services.AddScoped<IFornecedorService, FornecedorService>();


        }

        private static void RegisterApplication(IServiceCollection services)
        {
            services.AddScoped(typeof(IApplicationServiceBase<,>), typeof(ApplicationServiceBase<,>));
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddScoped<IFornecedorApplicationService, FornecedorApplicationService>();
        }


        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        }

    }
}
