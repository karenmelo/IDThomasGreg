using IDThomasGreg.Data;
using IDThomasGreg.Data.Repositories;
using IDThomasGreg.Domain.Repositories;
using IDThomasGreg.Domain.Services;
using IDThomasGreg.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IDThomasGreg.IoC
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {                    
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<DataContext>();
        }
    }
}
