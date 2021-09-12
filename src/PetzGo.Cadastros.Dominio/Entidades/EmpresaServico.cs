using System;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class EmpresaServico : Entidade
    {
        protected EmpresaServico() { }

        public EmpresaServico(Guid empresaId, Guid servicoPetCaracteristicaId, TipoPetEnum tipoPet, decimal valor, int tempoEmMinutos)
        {
            EmpresaId = empresaId;
            TipoPet = tipoPet;
            ServicoPetCaracteristicaId = servicoPetCaracteristicaId;
            Valor = valor;
            TempoEmMinutos = tempoEmMinutos;
        }

        public Guid EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }

        public TipoPetEnum TipoPet { get; private set; }

        public Guid ServicoPetCaracteristicaId { get; private set; }
        public ServicoPetCaracteristica ServicoPetCaracteristica { get; private set; }

        public decimal Valor { get; private set; }
        public int TempoEmMinutos { get; private set; }
    }
}
