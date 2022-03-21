using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos
{
    public class CompletarCadastroServicoEmpresaComando : Notifiable, IComando
    {
        public CompletarCadastroServicoEmpresaComando(Guid agendaId, Guid empresaId, Guid petId, Guid clienteId, Guid servicoId,
            decimal valorServico, int tempoEmMinutos)
        {
            AgendaId = agendaId;
            EmpresaId = empresaId;
            PetId = petId;
            ClienteId = clienteId;
            ServicoId = servicoId;
            ValorServico = valorServico;
            TempoEmMinutos = tempoEmMinutos;
        }

        public Guid AgendaId { get; private set; }
        public Guid EmpresaId { get; private set; }
        public Guid PetId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid ServicoId { get; private set; }
        public decimal ValorServico { get; private set; }
        public int TempoEmMinutos { get; private set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotEmpty(PetId, "PetId", "Campo obrigatório.")
            .IsNotEmpty(ClienteId, "ClienteId", "Campo obrigatório.")
            .IsNotEmpty(ServicoId, "ServicoId", "Campo obrigatório.")
            .IsGreaterThan(ValorServico,0 , "ValorServico", "Campo deve ser maior que 0")
            .IsGreaterThan(TempoEmMinutos,5, "TempoEmMinutos", "Campo deve ser maior que 5")
        );
    }
}
