using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Agendamento.Aplicacao.Comandos
{
    public class IniciarAgendamentoComando : Notifiable, IComando
    {
        public IniciarAgendamentoComando(Guid empresaId, Guid clienteId, Guid petId, Guid servicoId, DateTime dataHoraInicio, int tempoEmMinutos, decimal valorServico)
        {
            EmpresaId = empresaId;
            ClienteId = clienteId;
            PetId = petId;
            ServicoId = servicoId;
            DataHoraInicio = dataHoraInicio;
            TempoEmMinutos = tempoEmMinutos;
            ValorServico = valorServico;
        }

        public Guid EmpresaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid PetId { get; private set; }
        public Guid ServicoId { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public int TempoEmMinutos { get; private set; }
        public decimal ValorServico { get; private set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotEmpty(ClienteId, "ClienteId", "Campo obrigatório.")
            .IsNotEmpty(PetId, "PetId", "Campo obrigatório.")
            .IsNotEmpty(ServicoId, "ServicoId", "Campo obrigatório.")
            .IsBetween(DataHoraInicio, DateTime.Now.AddDays(-31), DateTime.Now.AddDays(31), "DataHoraInicio", "Data de início inválida, mínimo 1 mês atrás e máximo 1 mês a frente.")
            .IsBetween(TempoEmMinutos, 5, int.MaxValue, "TempoEmMinutos", "Mínimo 5 minutos.")
            .IsBetween(ValorServico, 1, 99999, "ValorServico", "Mínimo 1 e máximo 99999.")
        );
    }
}
