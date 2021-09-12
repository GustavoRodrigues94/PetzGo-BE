using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PetzGo.ControleAcesso.Aplicacao.Comandos;
using PetzGo.ControleAcesso.Dominio.Enums;
using PetzGo.Core.Mensagens.EventoIntegracao;
using PetzGo.Core.Mensagens.Eventos;

namespace PetzGo.ControleAcesso.Aplicacao.Manipuladores
{
    public class ControleAcessoEventoManipulador : INotificationHandler<EmpresaAdicionadaEvento>
    {
        private readonly ControleAcessoComandoManipulador _comandoManipulador;
        private readonly IMediatorManipulador _mediatorManipulador;

        public ControleAcessoEventoManipulador(
            ControleAcessoComandoManipulador comandoManipulador,
            IMediatorManipulador mediatorManipulador)
        {
            _comandoManipulador = comandoManipulador;
            _mediatorManipulador = mediatorManipulador;
        }

        public async Task Handle(EmpresaAdicionadaEvento evento, CancellationToken cancellationToken)
        {
            await _comandoManipulador.Manipular(
                new CriarUsuarioAdministradorComando(
                    evento.Email,
                    evento.Senha,
                    TipoUsuarioEnum.Administrador,
                    evento.EmpresaId,
                    evento.EmpresaRotuloLink)
            );

            await Task.CompletedTask;
        }
    }

}
