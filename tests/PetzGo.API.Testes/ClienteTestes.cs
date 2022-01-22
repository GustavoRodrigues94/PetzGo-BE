using System;
using System.Net.Http.Json;
using Newtonsoft.Json;
using PetzGo.API.Testes.Config;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos.DTOsComandos;
using PetzGo.Core.Mensagens.Comandos;
using Xunit;

namespace PetzGo.API.Testes
{
    [Collection(nameof(IntegracaoApiTestesFixtureCollection))]
    public class ClienteTestes
    {
        private readonly TesteIntegracaoFixture<StartupApiTests> _testesFixture;

        public ClienteTestes(TesteIntegracaoFixture<StartupApiTests> testesFixture)
        {
            _testesFixture = testesFixture;
        }

        [Fact(DisplayName = "Adicionar cliente para empresa logada")]
        [Trait("PetzGo.API", "Cliente")]
        public async void Cliente_AdicionarNovoCliente_DeveRetornarSucesso()
        {
            // Arrange
            await _testesFixture.AutenticarUsuarioAdmin();
            var enderecoComando = new EnderecoClienteComando
            {
                CEP = "15085360",
                Logradouro = "Rua Otávio Pinto César",
                Numero = "915",
                Cidade = "São José do Rio Preto",
                Estado = "SP",
                Bairro = "Cidade Nova",
                Complemento = "AP. 23"
            };
            var petComando = new PetComando
            {
                Nome = "Marquinhos Pet",
                IdPetCaracteristica = new Guid("B7BF1E6D-ECE5-486E-A966-1DAADF1B30F7"),
                TipoPet = 0
            };
            var adicionarClienteComando = new AdicionarClienteComando(_testesFixture.EmpresaId, "Douglinhas",
                "67999419457", enderecoComando, petComando);

            // Act
            var postResponse =
                await _testesFixture.HttpClient.PostAsJsonAsync("v1/cliente",
                    adicionarClienteComando);

            //Assert
            var comandoResultado = JsonConvert.DeserializeObject<ComandoResultado>(await postResponse.Content.ReadAsStringAsync());
            Assert.True(comandoResultado.Sucesso);
        }
    }
}
