using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.API.Controllers
{
    [Route("v1/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteConsultas _clienteConsultas;

        public ClienteController(IClienteConsultas clienteConsultas)
        {
            _clienteConsultas = clienteConsultas;
        }

        [Route("")]
        [HttpPost]
        public async Task<ActionResult<ComandoResultado>> AdicionarCliente(
            [FromBody] AdicionarClienteComando comando,
            [FromServices] ClienteComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);

        [Route("")]
        [HttpPut]
        public async Task<ActionResult<ComandoResultado>> AlterarCliente(
            [FromBody] AlterarClienteComando comando,
            [FromServices] ClienteComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);

        [Route("")]
        [HttpPatch]
        public async Task<ActionResult<ComandoResultado>> DesativarCliente(
            [FromBody] DesativarAtivarClienteComando comando,
            [FromServices] ClienteComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);

        [Route("{empresaId:Guid}/todos")]
        [HttpGet]
        public async Task<IEnumerable<ClienteViewModel>> ObterTodosClientesPorEmpresaId(Guid empresaId) =>
            await _clienteConsultas.ObterClientes(empresaId);

        [Route("{empresaId:Guid}/{clienteId:Guid}")]
        [HttpGet]
        public async Task<ClienteCompletoViewModel> ObterClientePorId(Guid empresaId, Guid clienteId) =>
            await _clienteConsultas.ObterClientePorId(empresaId, clienteId);

        [Route("{empresaId:Guid}/{whatsApp}")]
        [HttpGet]
        public async Task<ClienteCompletoViewModel> ObterClientePorWhatsApp(Guid empresaId, string whatsApp) =>
            await _clienteConsultas.ObterClientePorWhatsApp(empresaId, whatsApp);
    }
}
