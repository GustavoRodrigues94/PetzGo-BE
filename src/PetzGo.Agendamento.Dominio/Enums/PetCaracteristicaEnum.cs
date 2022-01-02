using System.ComponentModel;

namespace PetzGo.Agendamento.Dominio.Enums
{
    public enum PetCaracteristicaEnum
    {
        [Description("Pequeno c/ pelo curto")] PequenoComPeloCurto,
        [Description("Pequeno c/ pelo médio")] PequenoComPeloMedio,
        [Description("Pequeno c/ pelo longo")] PequenoComPeloLongo,
        [Description("Médio c/ pelo curto")] MedioComPeloCurto,
        [Description("Médio c/ pelo médio")] MedioComPeloMedio,
        [Description("Médio c/ pelo longo")] MedioComPeloLongo,
        [Description("Grande c/ pelo curto")] GrandeComPeloCurto,
        [Description("Grande c/ pelo médio")] GrandeComPeloMedio,
        [Description("Grande c/ pelo grande")] GrandeComPeloLongo,
    }
}
