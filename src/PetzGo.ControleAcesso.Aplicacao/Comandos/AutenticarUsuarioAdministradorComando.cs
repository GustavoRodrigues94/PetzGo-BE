using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.ControleAcesso.Aplicacao.Comandos
{
    public class AutenticarUsuarioAdministradorComando : Notifiable, IComando
    {
        public AutenticarUsuarioAdministradorComando(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }

        public void Validar() => AddNotifications(new Contract()
            .IsEmailOrEmpty(Email, "Email", "Campo inválido.")
            .IsNotNullOrEmpty(Senha, "Senha", "Campo inválido.")
        );
    }
}
