using System;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public class PetViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid IdPetCaracteristica { get; set; }
        public string TipoPet { get; set; }
    }
}
