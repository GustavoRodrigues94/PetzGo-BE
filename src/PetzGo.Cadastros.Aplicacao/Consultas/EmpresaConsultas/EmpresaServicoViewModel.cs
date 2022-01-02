using System;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Aplicacao.Consultas.EmpresaConsultas
{
    public class EmpresaServicoViewModel
    {
        public Guid Id { get; set; }
        public TipoPetEnum TipoPet { get; set; }
        public Guid ServicoPetCaracteristicaId { get; set; }
        public decimal Valor { get; set; }
        public int TempoMinutos { get; set; }
    }
}
