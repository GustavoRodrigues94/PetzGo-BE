using System.Collections.Generic;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class DiaSemana : Entidade
    {
        protected DiaSemana() { }

        public TipoDiaSemanaEnum TipoDiaSemana { get; private set; }

        private readonly List<EmpresaHorario> _empresaHorarios;
        public IEnumerable<EmpresaHorario> EmpresaHorarios => _empresaHorarios;
    }
}
