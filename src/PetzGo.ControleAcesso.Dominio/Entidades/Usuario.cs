using System;
using PetzGo.ControleAcesso.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.ControleAcesso.Dominio.Entidades
{
    public class Usuario : Entidade, IRaizAgregacao
    {
        protected Usuario() { }

        public Usuario(string email, string senha, TipoUsuarioEnum tipoUsuario, Guid empresaId, string empresaNomeFantasia)
        {
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
            EmpresaId = empresaId;
            EmpresaNomeFantasia = empresaNomeFantasia;
        }

        public string Email { get; private set; }
        public string Senha { get; private set; }
        public TipoUsuarioEnum TipoUsuario { get; private set; }

        public Guid EmpresaId { get; private set; }
        public string EmpresaNomeFantasia { get; private set; }

        public void EsconderSenha() => Senha = string.Empty;
    }
}
