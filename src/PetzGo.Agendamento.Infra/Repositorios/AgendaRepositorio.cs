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

        public void AdicionarAgendamento(Agenda agenda) => _contexto.Agenda.Add(agenda);

        public void Dispose() => _contexto?.Dispose();
    }
}
