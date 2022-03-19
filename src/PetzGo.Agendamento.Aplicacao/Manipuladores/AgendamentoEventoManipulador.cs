using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PetzGo.Agendamento.Aplicacao.Comandos;
using PetzGo.Core.Mensagens.EventoIntegracao;

namespace PetzGo.Agendamento.Aplicacao.Manipuladores
{
    public class AgendamentoEventoManipulador : INotificationHandler<ServicoPetCaracteristicaAdicionadoEvento>
    {
        private readonly AgendamentoComandoManipulador _agendamentoComandoManipulador;

        public AgendamentoEventoManipulador(AgendamentoComandoManipulador agendamentoComandoManipulador)
        {
            _agendamentoComandoManipulador = agendamentoComandoManipulador;
        }

        public async Task Handle(ServicoPetCaracteristicaAdicionadoEvento evento, CancellationToken cancellationToken)
        {
            await _agendamentoComandoManipulador.Manipular(
                new FinalizarAgendamentoComando(
                    evento.AgregacaoId,
                    evento.EmpresaId,
                    evento.AgendaCliente.Nome,
                    evento.AgendaPet.Nome,
                    evento.AgendaPet.TipoPet,
                    evento.AgendaPet.PetCaracteristica,
                    evento.AgendaServico.Nome,
                    evento.AgendaServico.Valor,
                    evento.AgendaServico.TempoEmMinutos)
            );

            await Task.CompletedTask;
        }
    }
}
