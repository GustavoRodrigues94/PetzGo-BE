using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PetzGo.ControleAcesso.Aplicacao.Comandos;
using PetzGo.Core.Mensagens.Comandos;
using Xunit;

namespace PetzGo.API.Testes.Config
{
    [CollectionDefinition(nameof(IntegracaoApiTestesFixtureCollection))]
    public class IntegracaoApiTestesFixtureCollection : ICollectionFixture<TesteIntegracaoFixture<StartupApiTests>> { }

    public class TesteIntegracaoFixture<TStartup> : IDisposable where TStartup : class
    {
        private readonly PetzGoAppFactory<TStartup> Factory;
        public readonly HttpClient HttpClient;
        private string UsuarioToken;
        public Guid EmpresaId;
        private object Usuario;

        public TesteIntegracaoFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions();
            Factory = new PetzGoAppFactory<TStartup>();
            HttpClient = Factory.CreateClient(clientOptions);
        }

        public async Task AutenticarUsuarioAdmin()
        {
            var autenticarUsuarioAdminCommand =
                new AutenticarUsuarioAdministradorComando("gustavorodriguestsi@gmail.com", "1234");

            var postResponse = await HttpClient.PostAsJsonAsync("v1/usuario/admin/autenticar",
                    autenticarUsuarioAdminCommand);

            var comandoResultado = JsonConvert.DeserializeObject<ComandoResultado>(await postResponse.Content.ReadAsStringAsync());
            var dadoRetorno = JObject.Parse(comandoResultado.Dado.ToString());

            UsuarioToken = dadoRetorno["token"].ToString();
            Usuario = dadoRetorno["usuario"];

            HttpClient.AtribuirToken(UsuarioToken);

            EmpresaId = (Guid) dadoRetorno["usuario"]["empresaId"];
        }

        public void Dispose()
        {
            HttpClient.Dispose();
            Factory.Dispose();
        }
    }
}
