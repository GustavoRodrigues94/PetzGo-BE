using System;
using PetzGo.Core.DominioBase;

namespace PetzGo.Agendamento.Dominio.Entidades
{
    public class AgendaServico : Entidade
    {
        public AgendaServico(Guid agendaId, string nome, decimal valor, int tempoEmMinutos)
        {
            AgendaId = agendaId;
            Nome = nome;
            Valor = valor;
            TempoEmMinutos = tempoEmMinutos;
        }

        public Guid AgendaId { get; private set; }
        public Agenda Agenda { get; private set; }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public int TempoEmMinutos { get; private set; }

    }
}
