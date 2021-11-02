using System;

namespace PetzGo.Core.Mensagens.EventoIntegracao
{
    public class EmpresaAdicionadaEvento : EventoIntegracao
    {
        public Guid EmpresaId { get; private set; }
        public string EmpresaNomeFantasia { get; private set; }

        public string Email { get; private set; }
        public string Senha { get; private set; }

        public EmpresaAdicionadaEvento(Guid empresaId, string empresaNomeFantasia, string email, string senha)
        {
            AgregacaoId = empresaId;
            EmpresaId = empresaId;
            EmpresaNomeFantasia = empresaNomeFantasia;
            Email = email;
            Senha = senha;
        }
    }
}
