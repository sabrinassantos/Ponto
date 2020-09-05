using System;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        /// <summary>
        /// inje��o de depend�ncia para que os m�dulos dependam somente de abstra��o
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IUsuarioRepository, UsuarioImplementation>();
            serviceCollection.AddScoped<IRegistroRepository, RegistroImplementation>();
            

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=.\\SQLEXPRESS2019;Initial Catalog=dbApi;MultipleActiveResultSets=true; User=sa;Password=210380")
            );

        }
    }
}
