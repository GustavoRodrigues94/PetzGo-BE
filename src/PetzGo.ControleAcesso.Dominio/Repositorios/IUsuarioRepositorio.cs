using System;
using System.Threading.Tasks;
using PetzGo.ControleAcesso.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.ControleAcesso.Dominio.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        void AdicionarUsuario(Usuario usuario);

        Task<Usuario> ObterUsuarioAdminPorEmailSenha(string email, string senha);
    }
}
