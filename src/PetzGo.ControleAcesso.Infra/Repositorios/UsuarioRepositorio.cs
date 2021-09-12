using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.ControleAcesso.Dominio.Entidades;
using PetzGo.ControleAcesso.Dominio.Enums;
using PetzGo.ControleAcesso.Dominio.Repositorios;
using PetzGo.ControleAcesso.Infra.Contexto;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.ControleAcesso.Infra.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly UsuarioContexto _contexto;
        public IUnidadeDeTrabalho UnidadeDeTrabalho => _contexto;

        public UsuarioRepositorio(UsuarioContexto contexto)
        {
            _contexto = contexto;
        }

        public void AdicionarUsuario(Usuario usuario) => _contexto.Usuarios.Add(usuario);

        public async Task<Usuario> ObterUsuarioAdminPorEmailSenha(string email, string senha) =>
            await _contexto.Usuarios
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Email == email &&
                                          x.Senha == senha &&
                                          x.TipoUsuario == TipoUsuarioEnum.Administrador);

        public void Dispose() => _contexto?.Dispose();
    }
}
