using System;

namespace PetzGo.Core.Mensagens
{
    public abstract class MensagemBase
    {
        public string TipoMensagem { get; protected set; }

        public Guid AgregacaoId { get; protected set; }

        protected MensagemBase() => TipoMensagem = GetType().Name;
    }
}
