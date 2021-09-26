using System;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class Cliente : Entidade, IRaizAgregacao
    {
        protected Cliente() { }

        public Cliente(string whatsApp, string nome, Guid empresaId)
        {
            WhatsApp = whatsApp;
            Nome = nome;
            EmpresaId = empresaId;
        }

        public string WhatsApp { get; private set; }
        public string Nome { get; private set; }

        public Guid EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }

        public Guid PetId { get; private set; }
        public Pet Pet { get; private set; }

        public Guid? EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }

        public void AdicionarEndereco(string cep, string logradouro, string numero, string bairro, string complemento, string cidade, string estado)
        {
            var clienteEndereco = new Endereco(cep, logradouro, numero, bairro, complemento, cidade, estado);
            Endereco = clienteEndereco;
            EnderecoId = clienteEndereco.Id;
        }

        public void AdicionarPet(TipoPetEnum tipoPet, string nome, Guid idPetCaracteristica)
        {
            var clientePet = new Pet(tipoPet, nome, idPetCaracteristica);
            Pet = clientePet;
            PetId = clientePet.Id;
        }
    }
}
