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
        Task<Servico> ObterServicoPorId(Guid servicoId);

        IQueryable<ServicoPetCaracteristica> ObterPetCaracteristicasPorServicoId(Guid servicoId);
        IQueryable<PetCaracteristica> ObterPetCaracteristicas();
        Task<ServicoPetCaracteristica> ObterServicoPetCaracteristica(Guid servicoId, Guid petPetCaracteristicaId);

        IQueryable<DiaSemana> ObterDiasSemana();

        Task<Empresa> ObterEmpresaPorCNPJ(string CNPJ);
        Task<Empresa> ObterEmpresaPorId(Guid empresaId);

        Task<Cliente> ObterClientePetPorEmpresaId(Guid empresaId, Guid clienteId, Guid petId);

        void AdicionarEmpresa(Empresa empresa);

        void AdicionarEmpresaServico(EmpresaServico empresaServico);
    }
}
