using System.Linq;
using System.Threading.Tasks;
using PetzGo.Core.DominioBase;
using PetzGo.Core.Mensagens.Eventos;

namespace PetzGo.Cadastros.Infra.Contexto
{
    public static class MediatorExtensao
    {
        public static async Task PublicarEventos(this IMediatorManipulador mediator, CadastrosContexto contexto)
        {
            var dominioEntidades = contexto.ChangeTracker.Entries<Entidade>()
                .Where(x => x.Entity.Eventos != null && x.Entity.Eventos.Any()).ToList();

            var dominioEventos = dominioEntidades.SelectMany(x => x.Entity.Eventos).ToList();

            dominioEntidades.ForEach(entidade => entidade.Entity.LimparEventos());

            var tarefas = dominioEventos.Select(async (dominioEvento) =>
            {
                await mediator.PublicarEvento(dominioEvento);
            });

            await Task.WhenAll(tarefas);
        }
    }
}
