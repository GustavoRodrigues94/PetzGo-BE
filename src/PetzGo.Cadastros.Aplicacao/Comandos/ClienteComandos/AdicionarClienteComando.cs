using System;
using Flunt.Br.Extensions;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos
{
    public class AdicionarClienteComando : Notifiable, IComando
    {
        public AdicionarClienteComando(Guid empresaId, string nome, string whatsApp, EnderecoComando endereco, PetComando pet)
        {
            EmpresaId = empresaId;
            Nome = nome;
            WhatsApp = whatsApp;
            Endereco = endereco;
            Pet = pet;
        }

        public Guid EmpresaId { get; set; }
        public string Nome { get; set; }
        public string WhatsApp { get; set; }

        public EnderecoComando Endereco { get; set; }
        public PetComando Pet { get; set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Nome, "Nome", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(WhatsApp, "WhatsApp", "Campo obrigatório.")

            .IsCep(Endereco.CEP, "Endereco.CEP", "Campo inválido.")
            .IsNotNullOrWhiteSpace(Endereco.Logradouro, "Endereco.Logradouro", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Endereco.Numero, "Endereco.Numero", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Endereco.Bairro, "Endereco.Bairro", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Endereco.Cidade, "Endereco.Cidade", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Endereco.Estado, "Endereco.Estado", "Campo obrigatório.")

            .IsNotNullOrWhiteSpace(Pet.Nome, "Pet.Nome", "Campo inválido.")
            .IsNotEmpty(Pet.IdPetCaracteristica, "Pet.IdPetCaracteristica", "Campo obrigatório.")
        );
    }

    public class EnderecoComando
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class PetComando
    {
        public string Nome { get; set; }
        public Guid IdPetCaracteristica { get; set; }
        public TipoPetEnum TipoPet { get; set; }
    }

}
