using System.Threading.Tasks;
using Moq;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Cadastros.Aplicacao.Testes.Comandos.EmpresaComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Repositorios;
using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Manipuladores
{
    [Collection(nameof(EmpresaComandosCollection))]
    public class EmpresaComandoManipuladorTestes
    {
        private readonly EmpresaComandosTestesFixture _empresaComandosTestesFixture;

        public EmpresaComandoManipuladorTestes(EmpresaComandosTestesFixture empresaComandosTestesFixture)
        {
            _empresaComandosTestesFixture = empresaComandosTestesFixture;
        }

        [Fact(DisplayName = "Tentar adicionar empresa existente")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Empresa")]
        public async Task EmpresaManipulador_Adicionar_EmpresaExistente()
        {
            // Arrange
            var adicionarEmpresaComando = _empresaComandosTestesFixture.GerarCriarEmpresaComandoValido();
            var empresa = _empresaComandosTestesFixture.GerarEmpresaValida(adicionarEmpresaComando);
            var empresaRepositorio = new Mock<IEmpresaRepositorio>();
            empresaRepositorio.Setup(m => m.UnidadeDeTrabalho.Commit()).Returns(Task.FromResult(true));
            empresaRepositorio.Setup(r => r.ObterEmpresaPorCNPJ(adicionarEmpresaComando.EmpresaComando.CNPJ))
                .Returns(Task.FromResult(empresa));

            // Act
            var resultado = await new EmpresaComandoManipulador(empresaRepositorio.Object).Manipular(adicionarEmpresaComando);

            // Assert
            Assert.False(resultado.Sucesso);
        }

        [Fact(DisplayName = "Adicionar empresa manipulador valido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Manipuladores", "Empresa")]
        public async Task EmpresaManipulador_Adicionar_DeveSerValido()
        {
            // Arrange
            var adicionarEmpresaComando = _empresaComandosTestesFixture.GerarCriarEmpresaComandoValido();
            var empresaRepositorio = new Mock<IEmpresaRepositorio>();
            empresaRepositorio.Setup(m => m.UnidadeDeTrabalho.Commit()).Returns(Task.FromResult(true));
            empresaRepositorio.Setup(r => r.ObterEmpresaPorCNPJ(adicionarEmpresaComando.EmpresaComando.CNPJ))
                .Returns(Task.FromResult<Empresa>(null));

            // Act
            var resultado = await new EmpresaComandoManipulador(empresaRepositorio.Object).Manipular(adicionarEmpresaComando);

            // Assert
            Assert.True(resultado.Sucesso);
        }
    }
}
