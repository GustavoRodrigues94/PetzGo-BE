using System.Collections.Generic;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class TipoNegocio : Entidade
    {
        protected TipoNegocio() { }

        public TipoNegocio(TipoNegocioEnum tipoNegocio)
        {
            NomeTipoNegocio = tipoNegocio;
        }

        public TipoNegocioEnum NomeTipoNegocio { get; private set; }

        private readonly List<Empresa> _empresas;
        public IReadOnlyCollection<Empresa> Empresas => _empresas;
    }
}
