using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PetzGo.API.Middlewares;
using PetzGo.Cadastros.Infra.Contexto;
using PetzGo.ControleAcesso.Infra.Contexto;

namespace PetzGo.API
{
    public class StartupApiTests
    {
        private IConfiguration Configuration { get; }

        public StartupApiTests(IHostEnvironment environment)
        {
            var builder = new ConfigurationBuilder().SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

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
        }

        private static void AdicionarMiddlewares(IServiceCollection services)
        {
            MiddlewareService.AdicionarJwt(services);
            MiddlewareService.AdicionarInjecaoDependencia(services);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
