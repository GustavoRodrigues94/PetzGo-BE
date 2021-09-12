using System.ComponentModel;

namespace PetzGo.Cadastros.Dominio.Enums
{
    public enum TipoNegocioEnum
    {
        [Description("Pet Shop")] PetShop,
        [Description("Clínica Veterinária")] ClinicaVeterinaria,
        [Description("Pet Shop & Clínica Veterinária")] PetShopClinicaVeterinaria
    }
}
