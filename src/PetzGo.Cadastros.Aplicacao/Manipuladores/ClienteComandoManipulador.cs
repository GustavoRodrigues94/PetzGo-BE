﻿using System.Threading.Tasks;
using Flunt.Notifications;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Core.Mensagens.Comandos;
using PetzGo.Core.Utilitarios.MensagensPadrao;

namespace PetzGo.Cadastros.Aplicacao.Manipuladores
{
    public class ClienteComandoManipulador : Notifiable,
        IComandoManipulador<AdicionarClienteComando>,
        IComandoManipulador<DesativarAtivarClienteComando>
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteComandoManipulador(IClienteRepositorio clienteRepositorio) =>
            _clienteRepositorio = clienteRepositorio;

        public async Task<ComandoResultado> Manipular(AdicionarClienteComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var cliente = new Cliente(comando.WhatsApp, comando.Nome, comando.EmpresaId);

            cliente.AdicionarEndereco(comando.Endereco.CEP, comando.Endereco.Logradouro, comando.Endereco.Numero,
                comando.Endereco.Bairro, comando.Endereco.Complemento, comando.Endereco.Cidade,
                comando.Endereco.Estado);

            cliente.AdicionarPet(comando.Pet.TipoPet, comando.Pet.Nome, comando.Pet.IdPetCaracteristica);

            _clienteRepositorio.AdicionarCliente(cliente);

            var commitou = await _clienteRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao adicionar cliente", cliente)
                : new ComandoResultado(false, "Ocorreu um erro ao adicionar cliente", null);
        }

        public async Task<ComandoResultado> Manipular(AlterarClienteComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var cliente = await _clienteRepositorio.ObterClienteCompletoTrack(comando.EmpresaId, comando.ClienteId);
            if(cliente is null)
                return new ComandoResultado(false, RetornoComando.MensagemComandoCampoInexistente("Cliente"), null);

            cliente.Alterar(comando.WhatsApp, comando.Nome, comando.Endereco.CEP, comando.Endereco.Logradouro,
                comando.Endereco.Numero, comando.Endereco.Bairro, comando.Endereco.Complemento,
                comando.Endereco.Cidade, comando.Endereco.Estado, comando.Pet.TipoPet, comando.Pet.Nome,
                comando.Pet.IdPetCaracteristica);

            _clienteRepositorio.AtualizarCliente(cliente);

            var commitou = await _clienteRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao alterar cliente", cliente)
                : new ComandoResultado(false, "Ocorreu um erro ao alterar cliente", null);
        }

        public async Task<ComandoResultado> Manipular(DesativarAtivarClienteComando comando)
        {
            comando.Validar();
            if (comando.Invalid)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            var cliente = await _clienteRepositorio.ObterClienteTrack(comando.EmpresaId, comando.ClienteId);
            if(cliente is null)
                return new ComandoResultado(false, RetornoComando.MensagemComandoInvalido(comando), comando.Notifications);

            cliente.AtivarDesativar(comando.Ativo);

            _clienteRepositorio.AtualizarCliente(cliente);

            var commitou = await _clienteRepositorio.UnidadeDeTrabalho.Commit();
            return commitou
                ? new ComandoResultado(true, "Sucesso ao atualizar cliente", cliente)
                : new ComandoResultado(false, "Ocorreu um erro ao atualizar cliente", null);
        }
    }
}
