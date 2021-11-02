using System.Threading.Tasks;
using Flunt.Notifications;
using PetzGo.ControleAcesso.Aplicacao.Comandos;
using PetzGo.ControleAcesso.Aplicacao.Services;
using PetzGo.ControleAcesso.Dominio.Entidades;
using PetzGo.ControleAcesso.Dominio.Repositorios;
using PetzGo.Core.Mensagens.Comandos;
using PetzGo.Core.Utilitarios.MensagensPadrao;

namespace PetzGo.ControleAcesso.Aplicacao.Manipuladores
{
    public class ControleAcessoComandoManipulador : Notifiable,
        IComandoManipulador<CriarUsuarioAdministradorComando>,
        IComandoManipulador<AutenticarUsuarioAdministradorComando>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ControleAcessoComandoManipulador(IUsuarioRepositorio usarioRepositorio) => _usuarioRepositorio = usarioRepositorio;

        public async Task<ComandoResultado> Manipular(CriarUsuarioAdministradorComando comando)
        {
            comando.Validar();
            if(comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var usuario = new Usuario(comando.Email, comando.Senha, comando.TipoUsuario, comando.EmpresaId, comando.EmpresaNomeFantasia);

            _usuarioRepositorio.AdicionarUsuario(usuario);

            var commitou = await _usuarioRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao criar usuário.", usuario)
                : new ComandoResultado(false, "Ocorreu um erro ao criar usuario.", null);
        }

        public async Task<ComandoResultado> Manipular(AutenticarUsuarioAdministradorComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var usuario = await _usuarioRepositorio.ObterUsuarioAdminPorEmailSenha(comando.Email, comando.Senha);
            if (usuario is null)
                return new ComandoResultado(false, "Usuário não encontrado.", null);

            var token = TokenService.GerarToken(usuario);

            usuario.EsconderSenha();

            return new ComandoResultado(true, "Usuário admin autenticado.", new
            {
                Token = token,
                Usuario = new
                {
                    email = usuario.Email, 
                    tipoUsuario = usuario.TipoUsuario, 
                    empresaId = usuario.EmpresaId,
                    empresaNomeFantasia = usuario.EmpresaNomeFantasia, 
                    id = usuario.Id
                }
            });
        }
    }
}
