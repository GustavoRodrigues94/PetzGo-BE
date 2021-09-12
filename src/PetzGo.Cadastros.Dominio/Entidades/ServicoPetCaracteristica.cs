using System;
using System.Collections.Generic;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class ServicoPetCaracteristica : Entidade
    {
        protected ServicoPetCaracteristica() { }

        public ServicoPetCaracteristica(Guid servicoId, Guid petCaracteristicaId)
        {
            ServicoId = servicoId;
            PetCaracteristicaId = petCaracteristicaId;
            _empresaServico = new List<EmpresaServico>();
        }

        public Guid ServicoId { get; private set; }
        public Servico Servico { get; private set; }

        public Guid PetCaracteristicaId { get; private set; }
        public PetCaracteristica PetCaracteristica { get; private set; }


        private readonly List<EmpresaServico> _empresaServico;
        public IReadOnlyCollection<EmpresaServico> EmpresaServico => _empresaServico;
    }
}
