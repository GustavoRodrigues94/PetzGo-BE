using System.Threading.Tasks;
using Flunt.Notifications;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Core.Mensagens.Comandos;
using PetzGo.Core.Mensagens.EventoIntegracao;
using PetzGo.Core.Utilitarios.MensagensPadrao;

namespace PetzGo.Cadastros.Aplicacao.Manipuladores
{
    public class EmpresaComandoManipulador : Notifiable,
    IComandoManipulador<CriarEmpresaComando>
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaComandoManipulador(IEmpresaRepositorio empresaRepositorio) =>
            _empresaRepositorio = empresaRepositorio;

        public async Task<ComandoResultado> Manipular(CriarEmpresaComando comando)
        {
            comando.Validar();
            if(comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var tipoNegocio = await _empresaRepositorio.ObterTipoNegocioPorId(comando.PrimeiraEtapaComando.TipoNegocioId);
            if(tipoNegocio is null)
                return new ComandoResultado(false, RetornoComando.MensagemComandoCampoInexistente("TipoNegocioId"), null);

            var empresaExistente = await _empresaRepositorio.ObterEmpresaPorRotuloLink(comando.PrimeiraEtapaComando.RotuloLink);
            if(!(empresaExistente is null))
                return new ComandoResultado(false, RetornoComando.MensagemComandoCampoExistente("Empresa"), null);

            var empresa = new Empresa(comando.PrimeiraEtapaComando.TipoNegocioId,
                comando.PrimeiraEtapaComando.NomeFantasia, comando.PrimeiraEtapaComando.CNPJ,
                comando.PrimeiraEtapaComando.RazaoSocial, comando.PrimeiraEtapaComando.WhatsApp,
                comando.PrimeiraEtapaComando.RotuloLink);

            empresa.AdicionarEndereco(comando.SegundaEtapaComando.CEP, comando.SegundaEtapaComando.Rua,
                comando.SegundaEtapaComando.Numero, comando.SegundaEtapaComando.Bairro,
                comando.SegundaEtapaComando.Complemento, comando.SegundaEtapaComando.Cidade,
                comando.SegundaEtapaComando.Estado);

            comando.TerceiraEtapaComando.ForEach(x =>
                empresa.AdicionarEmpresaServico(empresa.Id, x.ServicoPetCaracteristicaId, x.TipoPet, x.Valor, x.Tempo));

            comando.QuartaEtapaComando.ForEach(x =>
                empresa.AdicionarEmpresaHorario(empresa.Id, x.Id, x.HoraInicio, x.HoraFim));

            empresa.AdicionarEvento(new EmpresaAdicionadaEvento(empresa.Id, empresa.RotuloLink,
                comando.QuintaEtapaComando.Email, comando.QuintaEtapaComando.Senha));

            _empresaRepositorio.AdicionarEmpresa(empresa);

            var commitou = await _empresaRepositorio.UnidadeDeTrabalho.Commit();
            return commitou 
                ? new ComandoResultado(true, "Sucesso ao criar empresa.", empresa) 
                : new ComandoResultado(false, "Ocorreu um erro ao criar empresa.", null);
        }
    }
}
