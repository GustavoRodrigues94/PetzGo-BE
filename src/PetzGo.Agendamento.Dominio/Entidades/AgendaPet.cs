using System;
using PetzGo.Agendamento.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Agendamento.Dominio.Entidades
{
    public class AgendaPet : Entidade
    {
        public AgendaPet(Guid agendaId, string nome, PetCaracteristicaEnum petCaracteristica, TipoPetEnum tipoPet)
        {
            AgendaId = agendaId;
            Nome = nome;
            PetCaracteristica = petCaracteristica;
            TipoPet = tipoPet;
        }

        public Guid AgendaId { get; private set; }
        public Agenda Agenda { get; private set; }

        public string Nome { get; private set; }
        public PetCaracteristicaEnum PetCaracteristica { get; private set; }
        public TipoPetEnum TipoPet { get; private set; }
    }
}
