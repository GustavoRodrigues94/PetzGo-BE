using System;
using System.Linq;
using System.Threading.Tasks;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Dominio.Repositorios
{
    public interface IEmpresaRepositorio : IRepositorio<Empresa>
    {
        IQueryable<TipoNegocio> ObterTiposNegocios();
        Task<TipoNegocio> ObterTipoNegocioPorId(Guid tipoNegocioId);

        IQueryable<Servico> ObterServicos();

        IQueryable<ServicoPetCaracteristica> ObterPetCaracteristicasPorServicoId(Guid servicoId);
        IQueryable<PetCaracteristica> ObterPetCaracteristicas();

        IQueryable<DiaSemana> ObterDiasSemana();

        Task<Empresa> ObterEmpresaPorRotuloLink(string rotuloLink);

        void AdicionarEmpresa(Empresa empresa);
    }
}
