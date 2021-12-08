using System.Threading.Tasks;
using Moq;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Cadastros.Aplicacao.Testes.Comandos.ClienteComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Repositorios;
using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Manipuladores
{
    [Collection(nameof(ClienteComandosCollection))]
    public class ClienteComandoManipuladorTestes
    {

        private readonly ClienteComandosTestesFixture _clienteComandosTestesFixture;

        public ClienteComandoManipuladorTestes(ClienteComandosTestesFixture clienteComandosTestesFixture)
        {
            _clienteComandosTestesFixture = clienteComandosTestesFixture;
        }

        [Fact(DisplayName = "Adicionar cliente manipulador válido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Cliente")]
        public async Task ClienteManipulador_Adicionar_DeveSerValido()
        {
            // Arrange
            var adicionarClienteComando = _clienteComandosTestesFixture.GerarAdicionarClienteComandoValido();
            var clienteRepositorio = new Mock<IClienteRepositorio>();
            clienteRepositorio.Setup(m => m.UnidadeDeTrabalho.Commit()).Returns(Task.FromResult(true));

            // Act
            var resultado = await new ClienteComandoManipulador(clienteRepositorio.Object).Manipular(adicionarClienteComando);

            // Assert
            Assert.True(resultado.Sucesso);
        }

        [Fact(DisplayName = "Adicionar cliente manipulador inválido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Cliente")]
        public async Task ClienteManipulador_Adicionar_DeveSerInvalido()
        {
            // Arrange
            var adicionarClienteComando = _clienteComandosTestesFixture.GerarAdicionarClienteComandoInvalido();
            var clienteRepositorio = new Mock<IClienteRepositorio>();

            // Act
            var resultado = await new ClienteComandoManipulador(clienteRepositorio.Object).Manipular(adicionarClienteComando);

            // Assert
            Assert.False(resultado.Sucesso);
        }

        [Fact(DisplayName = "Alterar cliente manipulador válido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Cliente")]
        public async Task ClienteManipulador_Alterar_DeveSerValido()
        {
            // Arrange
            var alterarClienteComando = _clienteComandosTestesFixture.GerarAlterarClienteComandoValido();
            var cliente = _clienteComandosTestesFixture.GerarClienteValido(alterarClienteComando);
            var clienteRepositorio = new Mock<IClienteRepositorio>();
            clienteRepositorio.Setup(m => m.UnidadeDeTrabalho.Commit()).Returns(Task.FromResult(true));
            clienteRepositorio
                .Setup(m => m.ObterClienteCompletoTrack(alterarClienteComando.EmpresaId,
                    alterarClienteComando.ClienteId)).Returns(Task.FromResult(cliente));

            // Act
            var resultado =
                await new ClienteComandoManipulador(clienteRepositorio.Object).Manipular(alterarClienteComando);

            // Assert
            Assert.True(resultado.Sucesso);
        }

        [Fact(DisplayName = "Alterar cliente manipulador inválido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Cliente")]
        public async Task ClienteManipulador_Alterar_DeveSerInvalido()
        {
            // Arrange
            var alterarClienteComando = _clienteComandosTestesFixture.GerarAlterarClienteComandoInvalido();
            var clienteRepositorio = new Mock<IClienteRepositorio>();

            // Act
            var resultado =
                await new ClienteComandoManipulador(clienteRepositorio.Object).Manipular(alterarClienteComando);

            // Assert
            Assert.False(resultado.Sucesso);
        }
    }
}
