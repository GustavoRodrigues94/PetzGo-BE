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
        Task<EmpresaServico> ObterServicoEmpresaPetCaracteristica(Guid empresaId, Guid servicoId, Guid petCaracteristicaId);

        IQueryable<ServicoPetCaracteristica> ObterPetCaracteristicasPorServicoId(Guid servicoId);
        IQueryable<PetCaracteristica> ObterPetCaracteristicas();

        IQueryable<DiaSemana> ObterDiasSemana();

        Task<Empresa> ObterEmpresaPorCNPJ(string CNPJ);

        void AdicionarEmpresa(Empresa empresa);
    }
}
