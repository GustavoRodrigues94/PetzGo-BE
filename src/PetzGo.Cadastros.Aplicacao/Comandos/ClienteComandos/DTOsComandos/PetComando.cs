using System;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Aplicacao.Comandos.ClienteComandos.DTOsComandos
{
    public class PetComando
    {
        public string Nome { get; set; }
        public Guid IdPetCaracteristica { get; set; }
        public TipoPetEnum TipoPet { get; set; }
    }
}
