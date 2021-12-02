using System;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos.DTOsComandos;
using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.ClienteComandos
{
    [CollectionDefinition(nameof(ClienteComandosCollection))]
    public class ClienteComandosCollection : ICollectionFixture<ClienteComandosTestesFixture>
    { }

    public class ClienteComandosTestesFixture : IDisposable
    {
        public AdicionarClienteComando GerarAdicionarClienteComandoValido() => new AdicionarClienteComando(
            Guid.NewGuid(), 
            "Gustavo Rodrigues da Silveira", 
            "17996817461", 
            new EnderecoClienteComando
            {
                CEP = "15085360",
                Logradouro = "Rua Otávio Pinto Cesar",
                Numero = "915",
                Cidade = "São José do Rio Preto",
                Estado = "SP",
                Bairro = "Cidade Nova",
                Complemento = "AP. 23"
            },
            new PetComando
            {
                Nome = "Marquinhos Pet",
                IdPetCaracteristica = Guid.NewGuid(),
                TipoPet = 0
            });

        public AdicionarClienteComando GerarAdicionarClienteComandoInvalido() => new AdicionarClienteComando(
            Guid.NewGuid(),
            "Gustavo Rodrigues da Silveira",
            "17996817461",
            new EnderecoClienteComando(),
            new PetComando()
        );

        public AlterarClienteComando GerarAlterarClienteComandoValido() => new AlterarClienteComando(
            Guid.NewGuid(),
            Guid.NewGuid(),
            "Gustavo Rodrigues da Silveira",
            "17996817461",
            new EnderecoClienteComando
            {
                CEP = "15085360",
                Logradouro = "Rua Otávio Pinto Cesar",
                Numero = "915",
                Cidade = "São José do Rio Preto",
                Estado = "SP",
                Bairro = "Cidade Nova",
                Complemento = "AP. 23"
            },
            new PetComando
            {
                Nome = "Marquinhos Pet",
                IdPetCaracteristica = Guid.NewGuid(),
                TipoPet = 0
            });

        public AlterarClienteComando GerarAlterarClienteComandoInvalido() => new AlterarClienteComando(
            Guid.NewGuid(),
            Guid.NewGuid(),
            string.Empty,
            "17996817461",
            new EnderecoClienteComando(),
            new PetComando()
        );

        public void Dispose()
        {
            
        }
    }
}
