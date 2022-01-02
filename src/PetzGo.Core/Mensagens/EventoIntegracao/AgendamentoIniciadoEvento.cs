using System;

namespace PetzGo.Core.Mensagens.EventoIntegracao
{
    public class AgendamentoIniciadoEvento : EventoIntegracao
    {
        public AgendamentoIniciadoEvento(Guid agendaId, Guid empresaId, Guid petId, Guid clienteId, Guid servicoId,
            decimal valorServico, int tempoEmMinutos)
        {
            AgregacaoId = agendaId;
            EmpresaId = empresaId;
            PetId = petId;
            ClienteId = clienteId;
            ServicoId = servicoId;
            ValorServico = valorServico;
            TempoEmMinutos = tempoEmMinutos;
        }

        public Guid EmpresaId { get; private set; }
        public Guid PetId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid ServicoId { get; private set; }
        public decimal ValorServico { get; private set; }
        public int TempoEmMinutos { get; private set; }
    }
}
