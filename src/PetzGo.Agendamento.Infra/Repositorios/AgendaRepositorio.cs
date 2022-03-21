using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Agendamento.Dominio.Entidades;
using PetzGo.Agendamento.Dominio.Repositorios;
using PetzGo.Agendamento.Infra.Contexto;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Agendamento.Infra.Repositorios
{
    public class AgendaRepositorio : IAgendaRepositorio
    {
        private readonly AgendamentoContexto _contexto;
        public IUnidadeDeTrabalho UnidadeDeTrabalho => _contexto;

        public AgendaRepositorio(AgendamentoContexto contexto) => _contexto = contexto;

        public async Task<Agenda> ObterAgendamentoPorId(Guid agendaId) =>
            await _contexto.Agenda.FirstOrDefaultAsync(x => x.Id == agendaId);

        public void AdicionarAgendamento(Agenda agenda) => _contexto.Agenda.Add(agenda);

        public void AtualizarAgendamento(Agenda agenda) => _contexto.Agenda.Update(agenda);

        public void AdicionarClienteAgendamento(AgendaCliente agendaCliente) =>
            _contexto.AgendaCliente.Add(agendaCliente);

        public void AdicionarPetAgendamento(AgendaPet agendaPet) => 
            _contexto.AgendaPet.Add(agendaPet);

        public void AdicionarServicoAgendamento(AgendaServico agendaServico) =>
            _contexto.AgendaServico.Add(agendaServico);

        public void Dispose() => _contexto?.Dispose();
    }
}
