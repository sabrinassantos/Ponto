using Api.Domain.Interfaces.Services.Registro;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Service.Services;
using Domain.Extensions;
using Domain.Interfaces.Services.Notificador;
using Domain.Interfaces.Services.User;
using Domain.Notificacoes;
using Microsoft.AspNetCore.Http;
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

            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddScoped<IUser, AspNetUser>();



        }
    }
}
