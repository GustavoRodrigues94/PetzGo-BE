using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Agendamento.Aplicacao.Comandos
{
    public class FinalizarAgendamentoComando : Notifiable, IComando
    {
        public FinalizarAgendamentoComando(Guid agendaId, Guid empresaId, string nomeCliente, string nomePet, string tipoPet, string tipoPetCaracteristica, string nomeServico, decimal valorServico, int tempoEmMinutosServico)
        {
            AgendaId = agendaId;
            EmpresaId = empresaId;
            NomeCliente = nomeCliente;
            NomePet = nomePet;
            TipoPet = tipoPet;
            TipoPetCaracteristica = tipoPetCaracteristica;
            NomeServico = nomeServico;
            ValorServico = valorServico;
            TempoEmMinutosServico = tempoEmMinutosServico;
        }

        public Guid AgendaId { get; private set; }
        public Guid EmpresaId { get; private set; }
        public string NomeCliente { get; private set; }
        public string NomePet { get; private set; }
        public string TipoPet { get; private set; }
        public string TipoPetCaracteristica { get; private set; }
        public string NomeServico { get; private set; }
        public decimal ValorServico { get; private set; }
        public int TempoEmMinutosServico { get; private set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(AgendaId, "AgendaId", "Campo obrigatório.")
        );
    }
}
