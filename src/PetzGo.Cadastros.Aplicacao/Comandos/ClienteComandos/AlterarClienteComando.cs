﻿using System;
using Flunt.Notifications;
using Flunt.Validations;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos.DTOsComandos;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos
{
    public class AlterarClienteComando : Notifiable, IComando
    {
        public AlterarClienteComando(Guid id, Guid empresaId, string nome, string whatsApp, EnderecoClienteComando endereco, PetComando pet)
        {
            ClienteId = id;
            EmpresaId = empresaId;
            Nome = nome;
            WhatsApp = whatsApp;
            Endereco = endereco;
            Pet = pet;
        }
        
        public Guid ClienteId { get; set; }
        public Guid EmpresaId { get; set; }
        public string Nome { get; set; }
        public string WhatsApp { get; set; }

        public EnderecoClienteComando Endereco { get; set; }
        public PetComando Pet { get; set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(ClienteId, "ClienteId", "Campo obrigatório.")
            .IsNotEmpty(EmpresaId, "EmpresaId", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(Nome, "Nome", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(WhatsApp, "WhatsApp", "Campo obrigatório.")

            .IsNotNullOrWhiteSpace(Pet.Nome, "Pet.Nome", "Campo inválido.")
            .IsNotEmpty(Pet.IdPetCaracteristica, "Pet.IdPetCaracteristica", "Campo obrigatório.")
        );
    }
}
