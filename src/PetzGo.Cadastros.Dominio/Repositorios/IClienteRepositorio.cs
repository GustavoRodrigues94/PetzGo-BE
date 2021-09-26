using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Dominio.Repositorios
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        void AdicionarCliente(Cliente cliente);
    }
}
