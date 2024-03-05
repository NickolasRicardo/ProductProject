using ProductApplication.Application.DTO.Validation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductApplication.Application.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(ProdutoDTOValidation)));
                x.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            });
        }
    }
}