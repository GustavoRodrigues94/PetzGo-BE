using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.ControleAcesso.Dominio.Entidades;
using PetzGo.Core.Mensagens.Eventos;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.ControleAcesso.Infra.Contexto
{
    public class UsuarioContexto : DbContext, IUnidadeDeTrabalho
    {
        private readonly IMediatorManipulador _mediatorManipulador;

        public UsuarioContexto(DbContextOptions<UsuarioContexto> opcoes, IMediatorManipulador mediatorManipulador) : base(opcoes)
        {
            _mediatorManipulador = mediatorManipulador;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Ignore<Evento>();
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            if (sucesso) await _mediatorManipulador.PublicarEventos(this);

            return sucesso;
        }
    }
}
