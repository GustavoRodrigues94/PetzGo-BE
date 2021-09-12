using System;
using MediatR;

namespace PetzGo.Core.Mensagens.Eventos
{
    public abstract class Evento : MensagemBase, INotification
    {
        public DateTime DataHora { get; private set; }

        protected Evento() => DataHora = DateTime.Now;
    }
}
