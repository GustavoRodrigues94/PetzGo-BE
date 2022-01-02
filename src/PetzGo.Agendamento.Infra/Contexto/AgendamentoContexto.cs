using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Agendamento.Dominio.Entidades;
using PetzGo.Core.Mensagens.Eventos;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Agendamento.Infra.Contexto
{
    public class AgendamentoContexto : DbContext, IUnidadeDeTrabalho
    {
        private readonly IMediatorManipulador _mediatorManipulador;

        public AgendamentoContexto(DbContextOptions<AgendamentoContexto> opcoes,
            IMediatorManipulador mediatorManipulador) : base(opcoes) => _mediatorManipulador = mediatorManipulador;

        public DbSet<Agenda> Agenda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Evento>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AgendamentoContexto).Assembly);
        }

        public async Task<bool> Commit()
        {
            try
            {
                var sucesso = await base.SaveChangesAsync() > 0;
                if (sucesso) await _mediatorManipulador.PublicarEventos(this);

                return sucesso;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
