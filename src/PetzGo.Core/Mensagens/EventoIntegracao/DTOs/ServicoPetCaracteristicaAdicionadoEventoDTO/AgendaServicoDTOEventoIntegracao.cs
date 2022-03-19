namespace PetzGo.Core.Mensagens.EventoIntegracao.DTOs.ServicoPetCaracteristicaAdicionadoEventoDTO
{
    public class AgendaServicoDTOEventoIntegracao
    {
        public AgendaServicoDTOEventoIntegracao(string nome, decimal valor, int tempoEmMinutos)
        {
            Nome = nome;
            Valor = valor;
            TempoEmMinutos = tempoEmMinutos;
        }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public int TempoEmMinutos { get; private set; }
    }
}
