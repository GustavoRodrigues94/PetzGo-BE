using System;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PetzGo.Cadastros.Aplicacao.Consultas.EmpresaConsultas;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Cadastros.Infra.Repositorios;
using PetzGo.ControleAcesso.Aplicacao.Manipuladores;
using PetzGo.ControleAcesso.Dominio.Repositorios;
using PetzGo.ControleAcesso.Infra.Repositorios;
using PetzGo.Core.Mensagens.EventoIntegracao;
using PetzGo.Core.Mensagens.Eventos;
using PetzGo.Core.Utilitarios.Configuracoes;

namespace PetzGo.API.Middlewares
{
    public static class MiddlewareService
    {
        public static void AdicionarSwagger(IServiceCollection services) => services.AddSwaggerGen(c =>
            c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "PetzGo API",
                    Version = "v1",
                    Description = "API para regras de negócios PetzGo",
                    Contact = new OpenApiContact
                    {
                        Name = "Gustavo Rodrigues da Silveira",
                        Url = new Uri("https://github.com/GustavoRodrigues94")
                    }
                }));

        public static void AdicionarJwt(IServiceCollection services) =>
            services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtConfig.Segredo)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

        public static void AdicionarInjecaoDependencia(IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IMediatorManipulador, MediatorManipulador>();

            services.AddScoped<EmpresaComandoManipulador, EmpresaComandoManipulador>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            services.AddScoped<IEmpresaConsultas, EmpresaConsultas>();

            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<ControleAcessoComandoManipulador, ControleAcessoComandoManipulador>();

            services.AddScoped<INotificationHandler<EmpresaAdicionadaEvento>, ControleAcessoEventoManipulador>();
        }
    }
}
