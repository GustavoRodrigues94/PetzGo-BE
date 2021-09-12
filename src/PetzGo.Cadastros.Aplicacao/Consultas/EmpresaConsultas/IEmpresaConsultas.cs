using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetzGo.Cadastros.Aplicacao.Consultas.EmpresaConsultas
{
    public interface IEmpresaConsultas
    {
        Task<IEnumerable<TipoNegocioViewModel>> ObterTodosTiposNegocios();
        Task<IEnumerable<ServicoViewModel>> ObterTodosServicos();
        Task<IEnumerable<DiaSemanaViewModel>> ObterTodosDiasSemana();
        Task<IEnumerable<ServicoPetCaracteristicaViewModel>> ObterPetCaracteristicasPorServicoId(Guid servicoId);
        Task<IEnumerable<PetCaracteristicaViewModel>> ObterPetCaracteristicas();
    }
}
