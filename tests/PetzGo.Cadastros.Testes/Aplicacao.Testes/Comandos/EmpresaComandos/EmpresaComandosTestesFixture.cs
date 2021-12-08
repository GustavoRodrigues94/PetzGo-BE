using System;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos;
using PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos.DTOsComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Core.Mensagens.EventoIntegracao;
using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.EmpresaComandos
{
    [CollectionDefinition(nameof(EmpresaComandosCollection))]
    public class EmpresaComandosCollection : ICollectionFixture<EmpresaComandosTestesFixture>
    { }

    public class EmpresaComandosTestesFixture : IDisposable
    {
        public CriarEmpresaComando GerarCriarEmpresaComandoValido() => new CriarEmpresaComando(
            new EmpresaComando
            {
                CNPJ = "21075365000155",
                NomeFantasia = "Petz & Cia",
                TipoNegocioId = Guid.NewGuid(),
                WhatsApp = "67999419457"
            }, 
            new EnderecoEmpresaComando
            {
                CEP = "15085360",
                Rua = "Rua Otávio Pinto Cesar",
                Numero = "915",
                Cidade = "São José do Rio Preto",
                Estado = "SP",
                Bairro = "Cidade Nova",
                Complemento = "AP. 23"
            }, 
            new LoginComando
            {
                Email = "gustavorodriguestsi@gmail.com",
                Senha = "123456"
            });

        public CriarEmpresaComando GerarCriarEmpresaComandoInvalido() => new CriarEmpresaComando(
            new EmpresaComando
            {
                CNPJ = "35945730874",
                NomeFantasia = "Petz & Cia",
                TipoNegocioId = Guid.NewGuid(),
                WhatsApp = "67999419457"
            },
            new EnderecoEmpresaComando
            {
                CEP = "15085",
                Rua = "Rua Otávio Pinto Cesar",
                Numero = "915",
                Cidade = "São José do Rio Preto",
                Estado = "SP",
                Bairro = "Cidade Nova",
                Complemento = "AP. 23"
            },
            new LoginComando
            {
                Email = "gustavorodriguestsi",
                Senha = "123456"
            });


        public void Dispose()
        {

        }

        public Empresa GerarEmpresaValida(CriarEmpresaComando adicionarEmpresaComando)
        {
            var empresa = new Empresa(adicionarEmpresaComando.EmpresaComando.TipoNegocioId,
                adicionarEmpresaComando.EmpresaComando.NomeFantasia, adicionarEmpresaComando.EmpresaComando.CNPJ, adicionarEmpresaComando.EmpresaComando.WhatsApp);

            empresa.AdicionarEndereco(adicionarEmpresaComando.EnderecoComando.CEP, adicionarEmpresaComando.EnderecoComando.Rua,
                adicionarEmpresaComando.EnderecoComando.Numero, adicionarEmpresaComando.EnderecoComando.Bairro,
                adicionarEmpresaComando.EnderecoComando.Complemento, adicionarEmpresaComando.EnderecoComando.Cidade,
                adicionarEmpresaComando.EnderecoComando.Estado);

            return empresa;
        }
    }
}
