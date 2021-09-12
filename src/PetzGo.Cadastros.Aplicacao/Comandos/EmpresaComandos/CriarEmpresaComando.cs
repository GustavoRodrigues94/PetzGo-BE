using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using Flunt.Br.Extensions;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos
{
    public class CriarEmpresaComando : Notifiable, IComando
    {
        public CriarEmpresaComando(
            PrimeiraEtapaComando primeiraEtapaComando, 
            SegundaEtapaComando segundaEtapaComando,
            List<TerceiraEtapaComando> terceiraEtapaComando,
            List<QuartaEtapaComando> quartaEtapaComando,
            QuintaEtapaComando quintaEtapaComando)
        {
            PrimeiraEtapaComando = primeiraEtapaComando;
            SegundaEtapaComando = segundaEtapaComando;
            TerceiraEtapaComando = terceiraEtapaComando;
            QuartaEtapaComando = quartaEtapaComando;
            QuintaEtapaComando = quintaEtapaComando;
        }

        public PrimeiraEtapaComando PrimeiraEtapaComando { get; private set; }
        public SegundaEtapaComando SegundaEtapaComando { get; private set; }
        public List<TerceiraEtapaComando> TerceiraEtapaComando { get; private set; }
        public List<QuartaEtapaComando> QuartaEtapaComando { get; private set; }
        public QuintaEtapaComando QuintaEtapaComando { get; private set; }

        public void Validar() => AddNotifications(new Contract()
            .IsNotEmpty(PrimeiraEtapaComando.TipoNegocioId, "TipoNegocio", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(PrimeiraEtapaComando.NomeFantasia, "NomeFantasia", "Campo obrigatório.")
            .IsCnpj(PrimeiraEtapaComando.CNPJ, "CNPJ", "Campo inválido.")
            .IsNotNullOrWhiteSpace(PrimeiraEtapaComando.RazaoSocial, "RazaoSocial", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(PrimeiraEtapaComando.WhatsApp, "WhatsApp", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(PrimeiraEtapaComando.RotuloLink, "RotuloLink", "Campo obrigatório.")

            .IsCep(SegundaEtapaComando.CEP, "CEP", "Campo inválido.")
            .IsNotNullOrWhiteSpace(SegundaEtapaComando.Rua, "Rua", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(SegundaEtapaComando.Numero, "Numero", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(SegundaEtapaComando.Bairro, "Bairro", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(SegundaEtapaComando.Cidade, "Cidade", "Campo obrigatório.")
            .IsNotNullOrWhiteSpace(SegundaEtapaComando.Estado, "Estado", "Campo obrigatório.")

            .IsEmailOrEmpty(QuintaEtapaComando.Email, "Email", "Campo inválido.")
            .IsNotNullOrWhiteSpace(QuintaEtapaComando.Senha, "Senha", "Campo obrigatório.")
            .HasMinLen("Senha", 4, QuintaEtapaComando.Senha, "Campo inválido, mínimo 4 dígitos.")
        );
    }

    public class PrimeiraEtapaComando : IComando
    {
        public Guid TipoNegocioId { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get;set; }
        public string RazaoSocial { get; set; }
        public string WhatsApp { get; set; }
        public string RotuloLink { get; set; }
    }

    public class SegundaEtapaComando : IComando
    {
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }

    public class TerceiraEtapaComando : IComando
    {
        public Guid ServicoPetCaracteristicaId { get; set; }
        public TipoPetEnum TipoPet { get; set; }
        public decimal Valor { get; set; }
        public int Tempo { get; set; }
    }

    public class QuartaEtapaComando : IComando
    {
        public Guid Id { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
    }

    public class QuintaEtapaComando : IComando
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
