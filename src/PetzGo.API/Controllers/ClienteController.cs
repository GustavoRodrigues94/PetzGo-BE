using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.API.Controllers
{
    [Route("v1/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public async Task<ActionResult<ComandoResultado>> AdicionarCliente(
            [FromBody] AdicionarClienteComando comando,
            [FromServices] ClienteComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);
    }
}
