﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dados.EntityFramework;
using Dados.Interface;
using Dados.Repositorio;
using Servico.Interface;
using Servico.Services;

    namespace Interno.Api.Configuracoes
    {
        public static class DependencyInjectionConfig
        {
            public static IServiceCollection ResolveDependencies(this IServiceCollection services)
            {
                services.AddScoped<ApplicationDbContext>();


                services.AddScoped<IAnimalRepositorio, AnimalRepositorio>();
                services.AddScoped<IRacaRepositorio, RacaRepositorio>();
                services.AddScoped<IPorteRepositorio, PorteRepositorio>();
                services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
                services.AddScoped<IAnimalService, AnimalService>();
                services.AddScoped<IRacaService, RacaService>();
                services.AddScoped<IPorteService, PorteService>();
                services.AddScoped<IUsuarioService, UsuarioService>();
                services.AddScoped<IMatchRepositorio, MatchRepositorio>();
                services.AddScoped<IMatchService, MatchService>();
                services.AddScoped<IAuthRepositorio, AuthRepositorio>();
                services.AddScoped<IAuthService, AuthService>();
                services.AddScoped<ICurtidaService, CurtidaService>();
                services.AddScoped<ICurtidaRepositorio, CurtidaRepositorio>();



            return services;
            }
        }
    }


