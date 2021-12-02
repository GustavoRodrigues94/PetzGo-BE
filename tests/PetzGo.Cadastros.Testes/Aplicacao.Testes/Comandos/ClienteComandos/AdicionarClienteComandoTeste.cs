using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.ClienteComandos
{
    [Collection(nameof(ClienteComandosCollection))]
    public class AdicionarClienteComandoTeste
    {
        private readonly ClienteComandosTestesFixture _clienteComandosTestesFixture;

        public AdicionarClienteComandoTeste(ClienteComandosTestesFixture clienteComandosTestesFixture)
        {
            _clienteComandosTestesFixture = clienteComandosTestesFixture;
        }

        [Fact(DisplayName = "Adicionar cliente comando válido")]
        [Trait("Categoria", "PetzGo.Cadastros.Aplicacao.Cliente")]
        public void AdicionarClienteComando_DeveSerValido()
        {
            // Arrange
            var adicionarClienteComando = _clienteComandosTestesFixture.GerarAdicionarClienteComandoValido();

            // Act
            adicionarClienteComando.Validar();

            // Assert
            Assert.True(adicionarClienteComando.Valid);
            Assert.Equal(0, adicionarClienteComando.Notifications.Count);
        }

        [Fact(DisplayName = "Adicionar cliente comando inválido")]
        [Trait("Categoria", "PetzGo.Cadastros.Aplicacao.Cliente")]
        public void AdicionarClienteComando_DeveSerInvalido()
        {
            // Arrange
            var adicionarClienteComando = _clienteComandosTestesFixture.GerarAdicionarClienteComandoInvalido();

            // Act
            adicionarClienteComando.Validar();

            // Assert
            Assert.True(adicionarClienteComando.Invalid);
            Assert.NotEqual(0, adicionarClienteComando.Notifications.Count);
        }
    }
}
