using System;
using PetzGo.Agendamento.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Agendamento.Dominio.Entidades
{
    public class AgendaPet : Entidade
    {
        public AgendaPet(Guid agendaId, string nome, string petCaracteristica, string tipoPet)
        {
            AgendaId = agendaId;
            Nome = nome;
            PetCaracteristica = petCaracteristica;
            TipoPet = tipoPet;
        }

        public Guid AgendaId { get; private set; }
        public Agenda Agenda { get; private set; }

        public string Nome { get; private set; }
        public string PetCaracteristica { get; private set; }
        public string TipoPet { get; private set; }
    }
}
