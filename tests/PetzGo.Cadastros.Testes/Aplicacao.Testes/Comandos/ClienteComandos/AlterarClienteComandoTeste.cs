using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.ClienteComandos
{
    [Collection(nameof(ClienteComandosCollection))]
    public class AlterarClienteComandoTeste
    {
        private readonly ClienteComandosTestesFixture _clienteComandosTestesFixture;

        public AlterarClienteComandoTeste(ClienteComandosTestesFixture clienteComandosTestesFixture)
        {
            _clienteComandosTestesFixture = clienteComandosTestesFixture;
        }

        [Fact(DisplayName = "Alterar cliente comando válido")]
        [Trait("Categoria", "PetzGo.Cadastros.Aplicacao.Cliente")]
        public void AlterarClienteComando_DeveSerValido()
        {
            // Arrange
            var alterarClienteComando = _clienteComandosTestesFixture.GerarAlterarClienteComandoValido();

            // Act
            alterarClienteComando.Validar();

            // Assert
            Assert.True(alterarClienteComando.Valid);
            Assert.Equal(0, alterarClienteComando.Notifications.Count);
        }

        [Fact(DisplayName = "Alterar cliente comando inválido")]
        [Trait("Categoria", "PetzGo.Cadastros.Aplicacao.Cliente")]
        public void AlterarClienteComando_DeveSerInvalido()
        {
            // Arrange
            var alterarClienteComando = _clienteComandosTestesFixture.GerarAlterarClienteComandoInvalido();

            // Act
            alterarClienteComando.Validar();

            // Assert
            Assert.True(alterarClienteComando.Invalid);
            Assert.NotEqual(0, alterarClienteComando.Notifications.Count);
        }
    }
}
