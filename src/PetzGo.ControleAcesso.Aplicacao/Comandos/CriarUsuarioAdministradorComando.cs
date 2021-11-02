using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.ControleAcesso.Dominio.Enums;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.ControleAcesso.Aplicacao.Comandos
{
    public class CriarUsuarioAdministradorComando : Notifiable, IComando
    {
        public CriarUsuarioAdministradorComando(string email, string senha, TipoUsuarioEnum tipoUsuario, Guid empresaId, string empresaNomeFantasia)
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

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EmpresaNomeFantasia, "EmpresaNomeFantasia", "Campo obrigatório.")
            .IsEmailOrEmpty(Email, "Email", "Campo inválido.")
            .IsNotNullOrEmpty(Senha, "Senha", "Campo inválido.")
            .AreEquals(TipoUsuario, TipoUsuarioEnum.Administrador, "TipoUsuario", "Campo inválido.")
        );
    }
}
