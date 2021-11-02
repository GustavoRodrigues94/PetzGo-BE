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

            var tipoNegocio = await _empresaRepositorio.ObterTipoNegocioPorId(comando.EmpresaComando.TipoNegocioId);
            if(tipoNegocio is null)
                return new ComandoResultado(false, RetornoComando.MensagemComandoCampoInexistente("TipoNegocioId"), null);

            var empresaExistente = await _empresaRepositorio.ObterEmpresaPorCNPJ(comando.EmpresaComando.CNPJ);
            if(!(empresaExistente is null))
                return new ComandoResultado(false, RetornoComando.MensagemComandoCampoExistente("Empresa"), null);

            var empresa = new Empresa(comando.EmpresaComando.TipoNegocioId,
                comando.EmpresaComando.NomeFantasia, comando.EmpresaComando.CNPJ, comando.EmpresaComando.WhatsApp);

            empresa.AdicionarEndereco(comando.EnderecoComando.CEP, comando.EnderecoComando.Rua,
                comando.EnderecoComando.Numero, comando.EnderecoComando.Bairro,
                comando.EnderecoComando.Complemento, comando.EnderecoComando.Cidade,
                comando.EnderecoComando.Estado);

            empresa.AdicionarEvento(new EmpresaAdicionadaEvento(empresa.Id, empresa.NomeFantasia,
                comando.LoginComando.Email, comando.LoginComando.Senha));

            _empresaRepositorio.AdicionarEmpresa(empresa);

            var commitou = await _empresaRepositorio.UnidadeDeTrabalho.Commit();
            return commitou 
                ? new ComandoResultado(true, "Sucesso ao criar empresa.", empresa) 
                : new ComandoResultado(false, "Ocorreu um erro ao criar empresa.", null);
        }
    }
}
