using System;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class EmpresaHorario : Entidade
    {
        public EmpresaHorario(Guid diaSemanaId, Guid empresaId, string horaInicio, string horaFim)
        {
            DiaSemanaId = diaSemanaId;
            EmpresaId = empresaId;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
        }

        public Guid DiaSemanaId { get; private set; }
        public DiaSemana DiaSemana { get; private set; }

        public Guid EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }

        public string HoraInicio { get; private set; }
        public string HoraFim { get; private set; }
    }
}
