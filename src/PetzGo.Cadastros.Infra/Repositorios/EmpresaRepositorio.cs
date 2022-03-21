using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Cadastros.Infra.Contexto;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Infra.Repositorios
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly CadastrosContexto _contexto;
        public IUnidadeDeTrabalho UnidadeDeTrabalho => _contexto;

        public EmpresaRepositorio(CadastrosContexto contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<TipoNegocio> ObterTiposNegocios() =>
            _contexto.TipoNegocio
                .AsNoTrackingWithIdentityResolution()
                .AsQueryable();

        public async Task<TipoNegocio> ObterTipoNegocioPorId(Guid tipoNegocioId) =>
            await _contexto.TipoNegocio
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Id == tipoNegocioId);

        public IQueryable<Servico> ObterServicos() =>
            _contexto.Servico
                .AsNoTrackingWithIdentityResolution()
                .OrderBy(x => x.Nome)
                .AsQueryable();

        public async Task<EmpresaServico> ObterServicoEmpresaPetCaracteristica(Guid empresaId, Guid servicoId, Guid petCaracteristicaId) =>
            await _contexto.EmpresaServico
                .Include(x => x.ServicoPetCaracteristica)
                .Where(x => x.EmpresaId == empresaId)
                .Where(x => x.ServicoPetCaracteristica.ServicoId == servicoId)
                .Where(x => x.ServicoPetCaracteristica.PetCaracteristicaId == petCaracteristicaId)
                .FirstOrDefaultAsync();

        public Task<Servico> ObterServicoPorId(Guid servicoId) => _contexto.Servico
            .AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync(x => x.Id == servicoId);

        public IQueryable<ServicoPetCaracteristica> ObterPetCaracteristicasPorServicoId(Guid servicoId) =>
            _contexto.ServicoPetCaracteristicas
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.PetCaracteristica)
                .Where(x => x.ServicoId == servicoId)
                .OrderBy(x => x.PetCaracteristica.TipoPetCaracteristica)
                .AsQueryable();

        public IQueryable<PetCaracteristica> ObterPetCaracteristicas() =>
            _contexto.PetCaracteristicas
                .AsNoTrackingWithIdentityResolution()
                .OrderBy(x => x.TipoPetCaracteristica)
                .AsQueryable();

        public IQueryable<DiaSemana> ObterDiasSemana() => 
            _contexto.DiasSemana
                .AsNoTrackingWithIdentityResolution()
                .OrderBy(x => x.TipoDiaSemana)
                .AsQueryable();

        public async Task<Empresa> ObterEmpresaPorCNPJ(string CNPJ) =>
            await _contexto.Empresa.FirstOrDefaultAsync(x => x.CNPJ == CNPJ);

        public async Task<Empresa> ObterEmpresaPorId(Guid empresaId) => await _contexto.Empresa
            .AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync(x => x.Id == empresaId);

        public async Task<Cliente> ObterClientePetPorEmpresaId(Guid empresaId, Guid clienteId, Guid petId) =>
            await _contexto.Cliente
                .AsNoTrackingWithIdentityResolution()
                .Include(c => c.Empresa)
                .Include(c => c.Pet).ThenInclude(p => p.PetCaracteristica)
                .Where(x => x.EmpresaId == empresaId)
                .Where(x => x.Id == clienteId)
                .Where(x => x.Pet.Id == petId)
                .FirstOrDefaultAsync();

        public async Task<ServicoPetCaracteristica> ObterServicoPetCaracteristica(Guid servicoId, Guid petPetCaracteristicaId) =>
            await _contexto.ServicoPetCaracteristicas
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.PetCaracteristica)
                .Include(x => x.Servico)
                .Where(x => x.ServicoId == servicoId)
                .Where(x => x.PetCaracteristicaId == petPetCaracteristicaId)
                .FirstOrDefaultAsync();

        public void AdicionarEmpresa(Empresa empresa) => _contexto.Empresa.Add(empresa);

        public void AdicionarEmpresaServico(EmpresaServico empresaServico) =>
            _contexto.EmpresaServico.Add(empresaServico);

        public void Dispose() => _contexto?.Dispose();
    }
}
