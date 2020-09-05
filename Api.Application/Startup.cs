using System;
using Api.CrossCutting.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Api.CrossCutting.Mappings;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace application
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            _environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment _environment { get; }
        public void ConfigureServices(IServiceCollection services)
        {
 
            services.AddControllers();

            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelProfile());
                cfg.AddProfile(new EntityToDtoProfile());
                cfg.AddProfile(new ModelToEntityProfile());
            });

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;

            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            //var signingConfigurations = new SigningConfigurations();
            //services.AddSingleton(signingConfigurations);

            //services.AddAuthentication(authOptions =>
            //{
            //    authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(bearerOptions =>
            //{
            //    var paramsValidation = bearerOptions.TokenValidationParameters;
            //    paramsValidation.IssuerSigningKey = signingConfigurations.Key;
            //    paramsValidation.ValidAudience = Environment.GetEnvironmentVariable("Audience");
            //    paramsValidation.ValidIssuer = Environment.GetEnvironmentVariable("Issuer");

            //    // Valida a assinatura de um token recebido
            //    paramsValidation.ValidateIssuerSigningKey = true;

            //    // Verifica se um token recebido ainda é válido
            //    paramsValidation.ValidateLifetime = true;

            //    // Tempo de tolerância para a expiração de um token (utilizado
            //    // caso haja problemas de sincronismo de horário entre diferentes
            //    // computadores envolvidos no processo de comunicação)
            //    paramsValidation.ClockSkew = TimeSpan.Zero;
            //});

            //// Ativa o uso do token como forma de autorizar o acesso
            //// a recursos deste projeto
            //services.AddAuthorization(auth =>
            //{
            //    auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
            //        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
            //        .RequireAuthenticatedUser().Build());
            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Prova Registro Ponto",
                    Description = "API REST criada com o ASP.NET Core 3.0 para consulta de Registros de Pontos dos colaboradores",
                    Contact = new OpenApiContact
                    {
                        Name = "Sabrina Santos da Silva",
                        Email = "sabrinassantos.silva@gmail.com",
                        Url = new Uri("https://github.com/sabrinassantos")
                    }
                });

                //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    Description = "Entre com o Token JWT",
                //    Name = "Authorization",
                //    In = ParameterLocation.Header,
                //    Type = SecuritySchemeType.ApiKey
                //});

                //c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                //    {
                //        new OpenApiSecurityScheme {
                //            Reference = new OpenApiReference {
                //                Id = "Bearer",
                //                Type = ReferenceType.SecurityScheme
                //            }
                //        }, new List<string>()
                //    }
                //});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prova Técnica");
                //c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //if (Environment.GetEnvironmentVariable("MIGRATION").ToLower() == "APLICAR".ToLower())
            //{
            //    using (var service = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            //                                                .CreateScope())
            //    {
            //        using (var context = service.ServiceProvider.GetService<MyContext>())
            //        {
            //            context.Database.Migrate();
            //        }
            //    }
            //}
        }
    }
}
