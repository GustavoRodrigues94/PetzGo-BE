namespace PetzGo.Core.Mensagens.EventoIntegracao.DTOs.ServicoPetCaracteristicaAdicionadoEventoDTO
{
    public class AgendaClienteDTOEventoIntegracao
    {
        public AgendaClienteDTOEventoIntegracao(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
