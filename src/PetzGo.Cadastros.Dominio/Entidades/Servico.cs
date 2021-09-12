using System;
using System.Collections.Generic;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class Servico : Entidade
    {
        protected Servico() { }

        public Servico(string nome, ServicoPetCaracteristica servicoPetCaracteristica)
        {
            Nome = nome;
            _servicoPetCaracteristicas = new List<ServicoPetCaracteristica>();
        }

        public string Nome { get; private set; }

        private readonly List<ServicoPetCaracteristica> _servicoPetCaracteristicas;
        public IEnumerable<ServicoPetCaracteristica> ServicoPetCaracteristica { get; private set; }
    }
}
