using System.ComponentModel;

namespace PetzGo.Core.Mensagens.EventoIntegracao.DTOs.ServicoPetCaracteristicaAdicionadoEventoDTO
{
    public class AgendaPetDTOEventoIntegracao
    {
        public AgendaPetDTOEventoIntegracao(string nome, string petCaracteristica, string tipoPet)
        {
            Nome = nome;
            PetCaracteristica = petCaracteristica;
            TipoPet = tipoPet;
        }

        public string Nome { get; private set; }
        public string PetCaracteristica { get; private set; }
        public string TipoPet { get; private set; }
    }

}
