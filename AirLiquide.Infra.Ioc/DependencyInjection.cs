using AirLiquide.Application.Interfaces;
using AirLiquide.Application.Services;
using AirLiquide.Domain.Interfaces.Repositories;
using AirLiquide.Domain.Interfaces.Services;
using AirLiquide.Domain.Services;
using AirLiquide.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AirLiquide.Infra.Ioc
{
    public class DependencyInjection
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IBaseApp<,>), typeof(BaseServiceApp<,>));
            svcCollection.AddScoped<IClienteApp, ClienteApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            svcCollection.AddScoped<IClienteService, ClienteService>();

            //Repositorio
            svcCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            svcCollection.AddScoped<IClienteRepository, ClienteRepository>();


        }
    }
}
