using System;
using System.Threading.Tasks;
using PetzGo.Agendamento.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Agendamento.Dominio.Repositorios
{
    public interface IAgendaRepositorio : IRepositorio<Agenda>
    {
        Task<Agenda> ObterAgendamentoPorId(Guid agendaId);

        void AdicionarAgendamento(Agenda agenda);
        void AtualizarAgendamento(Agenda agenda);
    }
}
