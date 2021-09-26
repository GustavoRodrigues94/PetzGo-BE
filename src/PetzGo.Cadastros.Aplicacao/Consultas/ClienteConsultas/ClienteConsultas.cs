using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Core.Utilitarios.Conversores;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public class ClienteConsultas : IClienteConsultas
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteConsultas(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<IEnumerable<ClienteViewModel>> ObterClientes(Guid empresaId) =>
            await _clienteRepositorio.ObterClientes(empresaId).Select(cliente => new ClienteViewModel
            {
                Id = cliente.Id,
                Ativo = cliente.Ativo,
                NomeCliente = cliente.Nome,
                WhatsApp = cliente.WhatsApp,
                Endereco = $"{cliente.Endereco.Logradouro}, {cliente.Endereco.Numero}. {cliente.Endereco.Complemento} {cliente.Endereco.Cidade} - {cliente.Endereco.Estado}",
                PetId = cliente.Pet.Id,
                TipoPet = cliente.Pet.TipoPet.ObterDescricaoEnum(),
                NomePet = cliente.Pet.Nome
            }).ToListAsync();
    }
}
