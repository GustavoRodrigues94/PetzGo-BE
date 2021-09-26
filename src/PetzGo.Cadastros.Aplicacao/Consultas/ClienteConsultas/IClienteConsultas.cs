using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public interface IClienteConsultas
    {
        Task<IEnumerable<ClienteViewModel>> ObterClientes(Guid empresaId);
    }
}
