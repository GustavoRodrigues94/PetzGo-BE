using System;
using System.Linq;
using System.Threading.Tasks;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Dominio.Repositorios
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);

        IQueryable<Cliente> ObterClientes(Guid empresaId);
        Task<Cliente> ObterCliente(Guid empresaId, Guid clienteId);
    }
}
