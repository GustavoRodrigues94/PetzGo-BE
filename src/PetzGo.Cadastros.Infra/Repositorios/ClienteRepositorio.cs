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
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly CadastrosContexto _contexto;
        public IUnidadeDeTrabalho UnidadeDeTrabalho => _contexto;

        public ClienteRepositorio(CadastrosContexto contexto)
        {
            _contexto = contexto;
        }

        public void AdicionarCliente(Cliente cliente) => _contexto.Cliente.Add(cliente);

        public void AtualizarCliente(Cliente cliente) => _contexto.Cliente.Update(cliente);

        public IQueryable<Cliente> ObterClientes(Guid empresaId) =>
            _contexto.Cliente
                .AsNoTrackingWithIdentityResolution()
                .Where(x => x.EmpresaId == empresaId)
                .Include(c => c.Pet)
                .OrderBy(x => x.Nome)
                .AsQueryable();

        public IQueryable<Cliente> ObterClienteCompleto(Guid empresaId, Guid clienteId) =>
            _contexto.Cliente
                .AsNoTrackingWithIdentityResolution()
                .Where(x => x.EmpresaId == empresaId && x.Id == clienteId)
                .Include(c => c.Endereco)
                .Include(c => c.Pet).ThenInclude(p => p.PetCaracteristica)
                .AsQueryable();

        public async Task<Cliente> ObterClienteTrack(Guid empresaId, Guid clienteId) => await _contexto.Cliente
            .AsNoTrackingWithIdentityResolution()
            .FirstOrDefaultAsync(x => x.EmpresaId == empresaId && x.Id == clienteId);

        public async Task<Cliente> ObterClienteCompletoTrack(Guid empresaId, Guid clienteId) => await _contexto.Cliente
            .Include(c => c.Endereco)
            .Include(c => c.Pet).ThenInclude(p => p.PetCaracteristica)
            .FirstOrDefaultAsync(x => x.EmpresaId == empresaId && x.Id == clienteId);

        public void Dispose() => _contexto?.Dispose();

    }
}
