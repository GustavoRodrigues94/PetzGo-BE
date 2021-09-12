using System.ComponentModel;

namespace PetzGo.ControleAcesso.Dominio.Enums
{
    public enum TipoUsuarioEnum
    {
        [Description("Administrador")] Administrador,
        [Description("Funcionário")] Funcionario,
        [Description("Consumidor")] Consumidor
    }
}
