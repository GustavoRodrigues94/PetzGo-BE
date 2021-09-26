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

        public void Dispose() => _contexto?.Dispose();

    }
}
