using System;
using PetzGo.Core.DominioBase;

namespace PetzGo.Agendamento.Dominio.Entidades
{
    public class AgendaCliente : Entidade
    {
        public AgendaCliente(Guid agendaId, string nome)
        {
            AgendaId = agendaId;
            Nome = nome;
        }

        public Guid AgendaId { get; private set; }
        public Agenda Agenda { get; private set; }

        public string Nome { get; private set; }
    }
}
