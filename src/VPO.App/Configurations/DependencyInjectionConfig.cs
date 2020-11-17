using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using VPO.App.Extensions;
using VPO.Business.Interfaces;
using VPO.Data.Context;
using VPO.Data.Repository;

namespace VPO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection  ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();
            
            return services;
        }
    }
}