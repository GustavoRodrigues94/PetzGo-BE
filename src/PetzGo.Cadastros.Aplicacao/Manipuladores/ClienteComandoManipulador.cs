using System.Threading.Tasks;
using Flunt.Notifications;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos;
using PetzGo.Core.Mensagens.Comandos;
using PetzGo.Core.Utilitarios.MensagensPadrao;

namespace PetzGo.Cadastros.Aplicacao.Manipuladores
{
    public class ClienteComandoManipulador : Notifiable,
        IComandoManipulador<AdicionarClienteComando>
    {
        public async Task<ComandoResultado> Manipular(AdicionarClienteComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);


            return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);
        }
    }
}
