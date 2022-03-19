using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos;
using PetzGo.Core.Mensagens.EventoIntegracao;

namespace PetzGo.Cadastros.Aplicacao.Manipuladores
{
    public class EmpresaEventoManipulador : INotificationHandler<AgendamentoIniciadoEvento>
    {
        private readonly EmpresaComandoManipulador _empresaComandoManipulador;

        public EmpresaEventoManipulador(
            EmpresaComandoManipulador empresaComandoManipulador)
        {
            _empresaComandoManipulador = empresaComandoManipulador;
        }

        public async Task Handle(AgendamentoIniciadoEvento evento, CancellationToken cancellationToken)
        {
            await _empresaComandoManipulador.Manipular(
                new CompletarCadastroServicoEmpresaComando(
                    evento.AgregacaoId,
                    evento.EmpresaId,
                    evento.PetId,
                    evento.ClienteId,
                    evento.ServicoId,
                    evento.ValorServico,
                    evento.TempoEmMinutos)
            );

            await Task.CompletedTask;
        }
    }
}
