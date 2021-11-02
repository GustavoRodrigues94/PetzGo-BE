using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetzGo.ControleAcesso.Aplicacao.Comandos;
using PetzGo.ControleAcesso.Aplicacao.Manipuladores;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.API.Controllers
{
    [ApiController]
    [Route("v1/usuario")]
    public class UsuarioController : ControllerBase
    {
        [Route("admin/autenticar")]
        [HttpPost]
        public async Task<ActionResult<ComandoResultado>> Autenticar(
            [FromBody] AutenticarUsuarioAdministradorComando comando,
            [FromServices] ControleAcessoComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);
    }
}
