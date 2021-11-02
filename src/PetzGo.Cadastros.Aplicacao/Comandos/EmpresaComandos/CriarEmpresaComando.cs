using Flunt.Notifications;
using Flunt.Validations;
using Flunt.Br.Extensions;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos.DTOsComandos;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos
{
    public class CriarEmpresaComando : Notifiable, IComando
    {
        public CriarEmpresaComando(
            EmpresaComando empresa, 
            EnderecoEmpresaComando endereco,
            LoginComando login)
        {
            EmpresaComando = empresa;
            EnderecoComando = endereco;
            LoginComando = login;
        }

        public EmpresaComando EmpresaComando { get; set; }
        public EnderecoEmpresaComando EnderecoComando { get; set; }
        public LoginComando LoginComando { get; set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(EmpresaComando.TipoNegocioId, "TipoNegocio", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EmpresaComando.NomeFantasia, "NomeFantasia", "Campo obrigatório.")
            .IsCnpj(EmpresaComando.CNPJ, "CNPJ", "Campo inválido.")
            .IsNotNullOrWhiteSpace(EmpresaComando.WhatsApp, "WhatsApp", "Campo obrigatório.")

            .IsCep(EnderecoComando.CEP, "CEP", "Campo inválido.")
            .IsNotNullOrWhiteSpace(EnderecoComando.Rua, "Rua", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EnderecoComando.Numero, "Numero", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EnderecoComando.Bairro, "Bairro", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EnderecoComando.Cidade, "Cidade", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(EnderecoComando.Estado, "Estado", "Campo obrigatório.")

            .IsEmailOrEmpty(LoginComando.Email, "Email", "Campo inválido.")
            .IsNotNullOrWhiteSpace(LoginComando.Senha, "Senha", "Campo obrigatório.")
            .HasMinLen("Senha", 4, LoginComando.Senha, "Campo inválido, mínimo 4 dígitos.")
        );
    }
}
