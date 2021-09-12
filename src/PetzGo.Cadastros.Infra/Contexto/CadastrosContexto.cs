using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.Mensagens.Eventos;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Infra.Contexto
{
    public class CadastrosContexto : DbContext, IUnidadeDeTrabalho
    {
        private readonly IMediatorManipulador _mediatorManipulador;

        public CadastrosContexto(DbContextOptions<CadastrosContexto> opcoes, IMediatorManipulador mediatorManipulador) : base(opcoes)
        {
            _mediatorManipulador = mediatorManipulador;
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<TipoNegocio> TipoNegocio { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoPetCaracteristica> ServicoPetCaracteristicas { get; set; }
        public DbSet<DiaSemana> DiasSemana { get; set; }
        public DbSet<PetCaracteristica> PetCaracteristicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Evento>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CadastrosContexto).Assembly);
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            if (sucesso) await _mediatorManipulador.PublicarEventos(this);

            return sucesso;
        }
    }
}
