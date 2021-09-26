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
        [HttpPatch]
        public async Task<ActionResult<ComandoResultado>> DesativarCliente(
            [FromBody] DesativarAtivarClienteComando comando,
            [FromServices] ClienteComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);

        [Route("{empresaId:Guid}/todos")]
        [HttpGet]
        public async Task<IEnumerable<ClienteViewModel>> ObterTodosTiposNegocios(Guid empresaId) =>
            await _clienteConsultas.ObterClientes(empresaId);
    }
}
