using System;

namespace PetzGo.Core.Mensagens.EventoIntegracao
{
    public class EmpresaAdicionadaEvento : EventoIntegracao
    {
        public Guid EmpresaId { get; private set; }
        public string EmpresaRotuloLink { get; private set; }

        public string Email { get; private set; }
        public string Senha { get; private set; }

        public EmpresaAdicionadaEvento(Guid empresaId, string empresaRotuloLink, string email, string senha)
        {
            AgregacaoId = empresaId;
            EmpresaId = empresaId;
            EmpresaRotuloLink = empresaRotuloLink;
            Email = email;
            Senha = senha;
        }
    }
}
