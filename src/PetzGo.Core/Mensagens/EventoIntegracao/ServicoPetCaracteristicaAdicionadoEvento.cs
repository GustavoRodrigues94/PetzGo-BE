using System;
using PetzGo.Core.Mensagens.EventoIntegracao.DTOs.ServicoPetCaracteristicaAdicionadoEventoDTO;

namespace PetzGo.Core.Mensagens.EventoIntegracao
{
    public class ServicoPetCaracteristicaAdicionadoEvento : EventoIntegracao
    {
        public Guid EmpresaId { get; private set; }
        public AgendaPetDTOEventoIntegracao AgendaPet { get; private set; }
        public AgendaClienteDTOEventoIntegracao AgendaCliente { get; private set; }
        public AgendaServicoDTOEventoIntegracao AgendaServico { get; private set; }

        public ServicoPetCaracteristicaAdicionadoEvento(Guid agendaId, Guid empresaId,
            AgendaPetDTOEventoIntegracao agendaPet, 
            AgendaClienteDTOEventoIntegracao agendaCliente,
            AgendaServicoDTOEventoIntegracao agendaServico)
        {
            AgregacaoId = agendaId;
            EmpresaId = empresaId;
            AgendaPet = agendaPet;
            AgendaCliente = agendaCliente;
            AgendaServico = agendaServico;
        }
    }
}
