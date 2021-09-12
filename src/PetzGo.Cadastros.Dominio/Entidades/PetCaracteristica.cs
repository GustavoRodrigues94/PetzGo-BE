using System.Collections.Generic;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class PetCaracteristica : Entidade
    {
        public PetCaracteristica(TipoPetCaracteristica tipoPetCaracteristica)
        {
            TipoPetCaracteristica = tipoPetCaracteristica;
            _servicoPetCaracteristicas = new List<ServicoPetCaracteristica>();
        }

        public TipoPetCaracteristica TipoPetCaracteristica { get; private set; }

        private readonly List<ServicoPetCaracteristica> _servicoPetCaracteristicas;
        public IEnumerable<ServicoPetCaracteristica> ServicoPetCaracteristica => _servicoPetCaracteristicas;
    }
}
