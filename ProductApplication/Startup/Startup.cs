
using ProductApplication.Application.Configuration;
using ProductApplication.CrossCutting.IoC.DependencyInjection;

namespace ProductApplication.API
{
    public class Startup : IStartup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ConfigurationIoC.RegisterServices(services, Configuration);
            
            //services.AddHttpContextAccessor();

            services.AddJsonConfiguration();
            services.AddAutoMapperConfiguration();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddFluentValidationConfiguration();
       
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();
        }
    }
}
