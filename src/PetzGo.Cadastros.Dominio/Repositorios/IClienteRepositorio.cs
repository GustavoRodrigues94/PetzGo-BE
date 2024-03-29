﻿using System;
using System.Linq;
using System.Threading.Tasks;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.RepositorioBase;

namespace PetzGo.Cadastros.Dominio.Repositorios
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);

        IQueryable<Cliente> ObterClienteCompleto(Guid empresaId, Guid clienteId);
        IQueryable<Cliente> ObterClientePorWhatsApp(Guid empresaId, string whatsApp);
        IQueryable<Cliente> ObterClientes(Guid empresaId);

        Task<Cliente> ObterClienteTrack(Guid empresaId, Guid clienteId);
        Task<Cliente> ObterClienteCompletoTrack(Guid empresaId, Guid clienteId);
    }
}
