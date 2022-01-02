using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public interface IClienteConsultas
    {
        Task<IEnumerable<ClienteViewModel>> ObterClientes(Guid empresaId);
        Task<ClienteCompletoViewModel> ObterClientePorId(Guid empresaId, Guid clienteId);
        Task<ClienteCompletoViewModel> ObterClientePorWhatsApp(Guid empresaId, string whatsApp);
    }
}
