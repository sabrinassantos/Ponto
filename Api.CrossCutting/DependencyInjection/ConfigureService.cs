using Api.Domain.Interfaces.Services.Registro;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Service.Services;
using Domain.Interfaces.Services.Notificador;
using Domain.Notificacoes;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<IRegistroService, RegistroService>();
            serviceCollection.AddScoped<INotificador, Notificador>();
           

        }
    }
}
