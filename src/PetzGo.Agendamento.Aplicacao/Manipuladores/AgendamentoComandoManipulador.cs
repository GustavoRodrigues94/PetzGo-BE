using System.Threading.Tasks;
using Flunt.Notifications;
using PetzGo.Agendamento.Aplicacao.Comandos;
using PetzGo.Core.Mensagens.Comandos;
using PetzGo.Core.Utilitarios.MensagensPadrao;
using PetzGo.Agendamento.Dominio.Entidades;
using PetzGo.Agendamento.Dominio.Repositorios;
using PetzGo.Core.Mensagens.EventoIntegracao;

namespace PetzGo.Agendamento.Aplicacao.Manipuladores
{
    public class AgendamentoComandoManipulador : Notifiable,
        IComandoManipulador<IniciarAgendamentoComando>,
        IComandoManipulador<FinalizarAgendamentoComando>
    {
        private readonly IAgendaRepositorio _agendaRepositorio;

        public AgendamentoComandoManipulador(IAgendaRepositorio agendaRepositorio) =>
            _agendaRepositorio = agendaRepositorio;

        public async Task<ComandoResultado> Manipular(IniciarAgendamentoComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando),
                    comando.Notifications);

            var agenda = Agenda.AgendaFactory.NovoAgendamentoIniciado(comando.EmpresaId,
                comando.DataInicio, comando.TempoEmMinutos);

            _agendaRepositorio.AdicionarAgendamento(agenda);

            agenda.AdicionarEvento(new AgendamentoIniciadoEvento(agenda.Id, comando.EmpresaId, comando.PetId, comando.ClienteId,
                comando.ServicoId, comando.ValorServico, comando.TempoEmMinutos));

            var commitou = await _agendaRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao adicionar agendamento", agenda)
                : new ComandoResultado(false, "Ocorreu um erro ao adicionar agendamento", null);
        }

        public async Task<ComandoResultado> Manipular(FinalizarAgendamentoComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var agendamento = await _agendaRepositorio.ObterAgendamentoPorId(comando.AgendaId);
            if(agendamento is null)
                return new ComandoResultado(false, "Agendamento não encontrado", null);

            var agendaParaFinalizar = Agenda.AgendaFactory.FinalizarAgendamentoIniciado(agendamento,
                comando.NomeCliente,
                comando.NomePet, comando.TipoPet, comando.TipoPetCaracteristica,
                comando.NomeServico, comando.ValorServico, comando.TempoEmMinutosServico);

            _agendaRepositorio.AtualizarAgendamento(agendaParaFinalizar);

            var commitou = await _agendaRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao finalizar agendamento", agendamento)
                : new ComandoResultado(false, "Ocorreu um erro ao finalizar agendamento", null);
        }
    }
}
