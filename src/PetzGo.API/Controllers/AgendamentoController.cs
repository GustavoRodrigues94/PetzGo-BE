using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.API.Controllers
{
    [Route("v1/agendamento")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public async Task<ActionResult<ComandoResultado>> AdicionarAgendamento(
            [FromBody] AdicionarAgendamentoComando comando,
            [FromServices] AgendamentoComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);
    }
}
