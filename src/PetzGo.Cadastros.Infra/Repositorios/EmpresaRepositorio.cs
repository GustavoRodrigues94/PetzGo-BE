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

        public void AdicionarEmpresa(Empresa empresa) => _contexto.Empresa.Add(empresa);

        public void Dispose() => _contexto?.Dispose();
    }
}
