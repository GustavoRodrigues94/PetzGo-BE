using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos.DTOsComandos
{
    public class LoginComando : IComando
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
