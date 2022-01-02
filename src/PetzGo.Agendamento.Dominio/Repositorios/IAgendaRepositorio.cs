using PetzGo.Agendamento.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Agendamento.Dominio.Repositorios
{
    public interface IAgendaRepositorio : IRepositorio<Agenda>
    {
        void AdicionarAgendamento(Agenda agenda);
    }
}
