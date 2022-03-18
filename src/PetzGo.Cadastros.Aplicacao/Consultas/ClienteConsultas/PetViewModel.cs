using System;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public class PetViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid IdPetCaracteristica { get; set; }
        public TipoPetEnum TipoPet { get; set; }
        public string PetCaracteristica { get; set; }
        public string TipoPetDescricao { get; set; }
    }
}
