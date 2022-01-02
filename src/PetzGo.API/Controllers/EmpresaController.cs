using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos;
using PetzGo.Cadastros.Aplicacao.Consultas.EmpresaConsultas;
using PetzGo.Cadastros.Aplicacao.Manipuladores;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.API.Controllers
{
    [Route("v1/empresa")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaConsultas _empresaConsultas;

        public EmpresaController(IEmpresaConsultas empresaConsultas) => _empresaConsultas = empresaConsultas;

        [Route("")]
        [HttpPost]
        public async Task<ActionResult<ComandoResultado>> CriarEmpresa(
            [FromBody] CriarEmpresaComando comando,
            [FromServices] EmpresaComandoManipulador manipulador) =>
            await manipulador.Manipular(comando);

        [Route("tipos-negocios/todos")]
        [HttpGet]
        public async Task<IEnumerable<TipoNegocioViewModel>> ObterTodosTiposNegocios() =>
            await _empresaConsultas.ObterTodosTiposNegocios();

        [Route("servicos/{empresaId}/{servicoId}/{idPetCaracteristica}")]
        [HttpGet]
        public async Task<EmpresaServicoViewModel> ObterServicoEmpresaPetCaracteristica(
            Guid empresaId, Guid servicoId, Guid idPetCaracteristica) =>
            await _empresaConsultas.ObterServicoEmpresaPetCaracteristica(empresaId, servicoId, idPetCaracteristica);

        [Route("servicos/todos")]
        [HttpGet]
        public async Task<IEnumerable<ServicoViewModel>> ObterTodosServicos() =>
            await _empresaConsultas.ObterTodosServicos();

        [Route("servicos/{servicoId:Guid}/caracteristicas")]
        [HttpGet]
        public async Task<IEnumerable<ServicoPetCaracteristicaViewModel>> ObterPetCaracteristicasPorServicoId(Guid servicoId) =>
            await _empresaConsultas.ObterPetCaracteristicasPorServicoId(servicoId);

        [Route("pet-caracteristicas/todos")]
        [HttpGet]
        public async Task<IEnumerable<PetCaracteristicaViewModel>> ObterPetCaracteristicas() =>
            await _empresaConsultas.ObterPetCaracteristicas();

        [Route("dias-semana/todos")]
        [HttpGet]
        public async Task<IEnumerable<DiaSemanaViewModel>> ObterTodosDiasSemana() =>
            await _empresaConsultas.ObterTodosDiasSemana();
    }
}
