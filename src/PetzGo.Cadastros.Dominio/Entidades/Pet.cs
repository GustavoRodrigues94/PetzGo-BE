using System;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class Pet : Entidade
    {
        public Pet(TipoPetEnum tipoPet, string nome, Guid petCaracteristicaId)
        {
            TipoPet = tipoPet;
            Nome = nome;
            PetCaracteristicaId = petCaracteristicaId;
        }

        public TipoPetEnum TipoPet { get; private set; }
        public string Nome { get; private set; }
       
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }

        public Guid PetCaracteristicaId { get; private set; }
        public PetCaracteristica PetCaracteristica { get; private set; }
    }
}
