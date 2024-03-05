using ProductApplication.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Internal;

namespace ProductApplication.Application.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(ConfigurationMapping));
        }
    }
}
