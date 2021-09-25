using System;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class Cliente : Entidade, IRaizAgregacao
    {
        protected Cliente() { }

        public Cliente(string whatsApp, string nome, Endereco endereco, Pet pet, Guid empresaId)
        {
            WhatsApp = whatsApp;
            Nome = nome;
            Endereco = endereco;
            Pet = pet;
            EmpresaId = empresaId;
        }

        public string WhatsApp { get; private set; }
        public string Nome { get; private set; }

        public Guid EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }

        public Pet Pet { get; private set; }

        public Guid EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }
    }
}
