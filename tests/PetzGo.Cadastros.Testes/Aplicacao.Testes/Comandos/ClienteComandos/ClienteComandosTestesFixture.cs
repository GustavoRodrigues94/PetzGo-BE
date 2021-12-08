using System;
using Bogus;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos;
using PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos.DTOsComandos;
using PetzGo.Cadastros.Dominio.Entidades;
using Xunit;

namespace PetzGo.Cadastros.Aplicacao.Testes.Comandos.ClienteComandos
{
    [CollectionDefinition(nameof(ClienteComandosCollection))]
    public class ClienteComandosCollection : ICollectionFixture<ClienteComandosTestesFixture>
    { }

    public class ClienteComandosTestesFixture : IDisposable
    {
        public AdicionarClienteComando GerarAdicionarClienteComandoValido() =>
            new Faker<AdicionarClienteComando>("pt_BR").CustomInstantiator(f =>
                new AdicionarClienteComando(
                    Guid.NewGuid(),
                    f.Name.FullName(),
                    f.Phone.PhoneNumber("###########"),
                    new EnderecoClienteComando
                    {
                        CEP = f.Address.ZipCode("########"),
                        Logradouro = f.Address.StreetName(),
                        Numero = f.Address.BuildingNumber(),
                        Cidade = f.Address.City(),
                        Estado = f.Address.State(),
                        Bairro = f.Address.StreetAddress(),
                        Complemento = "AP. 23"
                    },
                    new PetComando
                    {
                        Nome = "Marquinhos Pet",
                        IdPetCaracteristica = Guid.NewGuid(),
                        TipoPet = 0
                    }));

        public AdicionarClienteComando GerarAdicionarClienteComandoInvalido() => new AdicionarClienteComando(
            Guid.NewGuid(),
            "Gustavo Rodrigues da Silveira",
            "17996817461",
            new EnderecoClienteComando(),
            new PetComando()
        );

        public AlterarClienteComando GerarAlterarClienteComandoValido() =>
            new Faker<AlterarClienteComando>("pt_BR").CustomInstantiator(f => new AlterarClienteComando(
                Guid.NewGuid(),
                Guid.NewGuid(),
                f.Name.FullName(),
                f.Phone.PhoneNumber("###########"),
                new EnderecoClienteComando
                {
                    CEP = f.Address.ZipCode("########"),
                    Logradouro = f.Address.StreetName(),
                    Numero = f.Address.BuildingNumber(),
                    Cidade = f.Address.City(),
                    Estado = f.Address.State(),
                    Bairro = f.Address.StreetAddress(),
                    Complemento = "AP. 23"
                },
                new PetComando
                {
                    Nome = "Marquinhos Pet",
                    IdPetCaracteristica = Guid.NewGuid(),
                    TipoPet = 0
                }));

        public AlterarClienteComando GerarAlterarClienteComandoInvalido() => new AlterarClienteComando(
            Guid.NewGuid(),
            Guid.NewGuid(),
            string.Empty,
            "17996817461",
            new EnderecoClienteComando(),
            new PetComando()
        );

        public Cliente GerarClienteValido(AlterarClienteComando alterarClienteComando)
        {
            var cliente = new Cliente(alterarClienteComando.WhatsApp, alterarClienteComando.Nome, alterarClienteComando.EmpresaId);
            cliente.AdicionarEndereco(alterarClienteComando.Endereco.CEP, alterarClienteComando.Endereco.Logradouro,
                alterarClienteComando.Endereco.Numero,
                alterarClienteComando.Endereco.Bairro, alterarClienteComando.Endereco.Complemento,
                alterarClienteComando.Endereco.Cidade,
                alterarClienteComando.Endereco.Estado);

            cliente.AdicionarPet(alterarClienteComando.Pet.TipoPet, alterarClienteComando.Pet.Nome,
                alterarClienteComando.Pet.IdPetCaracteristica);

            return cliente;
        }

        public void Dispose()
        {
            
        }
    }
}
