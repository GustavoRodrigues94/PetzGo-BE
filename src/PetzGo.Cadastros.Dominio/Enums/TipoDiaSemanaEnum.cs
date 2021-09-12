using System.ComponentModel;

namespace PetzGo.Cadastros.Dominio.Enums
{
    public enum TipoDiaSemanaEnum
    {
        [Description("Segunda-feira")] SegundaFeira,
        [Description("Terça-feira")] TercaFeira,
        [Description("Quarta-feira")] QuartaFeira,
        [Description("Quinta-feira")] QuintaFeira,
        [Description("Sexta-feira")] SextaFeira,
        [Description("Sábado")] Sabado,
        [Description("Domingo")] Domingo
    }
}
