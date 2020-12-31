using Microsoft.Extensions.DependencyInjection;
using Restaurant.Application.Interfaces;
using Restaurant.Application.Services;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Services;
using Restaurant.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Infra.IoC
{
    public class InjetorDependencies
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            //Aplication
            serviceCollection.AddScoped(typeof(IAppBase<,>), typeof(ServiceAppBase<,>));
            serviceCollection.AddScoped<IDishApp, DishApp>();
            //Domain
            serviceCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            serviceCollection.AddScoped<IDishService, DishService>();
            //Repository
            serviceCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IDishRepository, DishRepository>();
        }
    }
}
