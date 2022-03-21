using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PetzGo.Agendamento.Infra.Contexto;
using PetzGo.API.Middlewares;
using PetzGo.Cadastros.Infra.Contexto;
using PetzGo.ControleAcesso.Infra.Contexto;

namespace PetzGo.API
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            AdicionarMiddlewares(services);
            AdicionarContextos(services);
        }

        private void AdicionarContextos(IServiceCollection services)
        {
            services.AddDbContext<CadastrosContexto>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<UsuarioContexto>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<AgendamentoContexto>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        private static void AdicionarMiddlewares(IServiceCollection services)
        {
            MiddlewareService.AdicionarSwagger(services);
            MiddlewareService.AdicionarJwt(services);
            MiddlewareService.AdicionarInjecaoDependencia(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MeuControle V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
