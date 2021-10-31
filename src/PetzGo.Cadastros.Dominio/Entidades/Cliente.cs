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
            Ativo = true;
            WhatsApp = whatsApp;
            Nome = nome;
            EmpresaId = empresaId;
        }

        public bool Ativo { get; private set; }
        public string WhatsApp { get; private set; }
        public string Nome { get; private set; }

        public Guid EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }

        public Pet Pet { get; private set; }

        public Guid EmpresaId { get; private set; }
        public Empresa Empresa { get; private set; }

        public void AdicionarEndereco(string cep, string logradouro, string numero, string bairro, string complemento, string cidade, string estado)
        {
            Endereco = new Endereco(cep, logradouro, numero, bairro, complemento, cidade, estado);
        }

        public void AdicionarPet(TipoPetEnum tipoPet, string nome, Guid idPetCaracteristica)
        {
            Pet = new Pet(tipoPet, nome, idPetCaracteristica);
        }

        public void AtivarDesativar(bool ativo)
        {
            Ativo = ativo;
        }

        public void Alterar(string whatsApp, string nomeCliente, 
                            string cep, string logradouro, string numero, string bairro, string complemento, string cidade, string estado,
                            TipoPetEnum tipoPet, string nomePet, Guid idPetCaracteristica)
        {
            WhatsApp = whatsApp;
            Nome = nomeCliente;
            Endereco.Alterar(cep, logradouro, numero, bairro, complemento, cidade, estado);
            Pet.Alterar(tipoPet, nomePet, idPetCaracteristica);
        }
    }
}
