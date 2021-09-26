using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos
{
    public class DesativarAtivarClienteComando : Notifiable, IComando
    {
        public DesativarAtivarClienteComando(Guid empresaId, Guid clienteId, bool ativo)
        {
            EmpresaId = empresaId;
            ClienteId = clienteId;
            Ativo = ativo;
        }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotEmpty(ClienteId, "ClienteId", "Campo obrigatório.")
        );

        public Guid EmpresaId { get; set; }
        public Guid ClienteId { get; set; }
        public bool Ativo { get; set; }
    }
}
