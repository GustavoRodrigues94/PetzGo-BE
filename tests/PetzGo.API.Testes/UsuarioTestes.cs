using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using PetzGo.API.Testes.Config;
using PetzGo.ControleAcesso.Aplicacao.Comandos;
using PetzGo.Core.Mensagens.Comandos;
using Xunit;

namespace PetzGo.API.Testes
{
    [Collection(nameof(IntegracaoApiTestesFixtureCollection))]
    public class UsuarioTestes
    {
        private readonly TesteIntegracaoFixture<StartupApiTests> _testesFixture;

        public UsuarioTestes(TesteIntegracaoFixture<StartupApiTests> testesFixture)
        {
            _testesFixture = testesFixture;
        }

        [Fact(DisplayName = "Autenticar usuário admin com sucesso")]
        [Trait("PetzGo.API", "Usuario")]
        public async void Usuario_AutenticarUsuarioAdmin_DeveExecutarComSucesso()
        {
            // Arrange
            var autenticarUsuarioAdminCommand =
                new AutenticarUsuarioAdministradorComando("gustavorodriguestsi@gmail.com", "1234");

            // Act
            var postResponse =
                await _testesFixture.HttpClient.PostAsJsonAsync("v1/usuario/admin/autenticar",
                    autenticarUsuarioAdminCommand);

            //Assert
            var comandoResultado = JsonConvert.DeserializeObject<ComandoResultado>(await postResponse.Content.ReadAsStringAsync());
            Assert.True(comandoResultado.Sucesso);
            Assert.Contains("token", comandoResultado.Dado.ToString());
            Assert.Contains("usuario", comandoResultado.Dado.ToString());
        }

        [Fact(DisplayName = "Autenticar usuário admin incorreto")]
        [Trait("PetzGo.API", "Usuario")]
        public async void Usuario_AutenticarUsuarioAdmin_DeveRetornarUsuarioNaoEncontrado()
        {
            // Arrange
            var autenticarUsuarioAdminCommand =
                new AutenticarUsuarioAdministradorComando("gustavorodriguestsi@gmail.com", "123456");

            // Act
            var postResponse =
                await _testesFixture.HttpClient.PostAsJsonAsync("v1/usuario/admin/autenticar",
                    autenticarUsuarioAdminCommand);

            //Assert
            var comandoResultado = JsonConvert.DeserializeObject<ComandoResultado>(await postResponse.Content.ReadAsStringAsync());
            Assert.False(comandoResultado.Sucesso);
            Assert.Null(comandoResultado.Dado);
        }
    }
}
