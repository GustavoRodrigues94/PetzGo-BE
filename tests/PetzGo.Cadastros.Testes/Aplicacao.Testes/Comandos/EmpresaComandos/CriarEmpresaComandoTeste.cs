using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.EmpresaComandos
{
    [Collection(nameof(EmpresaComandosCollection))]
    public class CriarEmpresaComandoTeste
    {
        private readonly EmpresaComandosTestesFixture _empresaComandosTestesFixture;

        public CriarEmpresaComandoTeste(EmpresaComandosTestesFixture empresaComandosTestesFixture)
        {
            _empresaComandosTestesFixture = empresaComandosTestesFixture;
        }

        [Fact(DisplayName = "Adicionar empresa comando válido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Comandos", "Empresa")]
        public void CriarEmpresaComando_DeveSerValido()
        {
            // Arrange
            var criarEmpresaComando = _empresaComandosTestesFixture.GerarCriarEmpresaComandoValido();

            // Act
            criarEmpresaComando.Validar();

            // Assert
            Assert.True(criarEmpresaComando.Valid);
            Assert.Equal(0, criarEmpresaComando.Notifications.Count);
        }

        [Fact(DisplayName = "Adicionar empresa comando inválido")]
        [Trait("PetzGo.Cadastros.Aplicacao.Comandos", "Empresa")]
        public void CriarEmpresaComando_DeveSerInvalido()
        {
            // Arrange
            var criarEmpresaComando = _empresaComandosTestesFixture.GerarCriarEmpresaComandoInvalido();

            // Act
            criarEmpresaComando.Validar();

            // Assert
            Assert.True(criarEmpresaComando.Invalid);
            Assert.NotEqual(0, criarEmpresaComando.Notifications.Count);
        }
    }
}
