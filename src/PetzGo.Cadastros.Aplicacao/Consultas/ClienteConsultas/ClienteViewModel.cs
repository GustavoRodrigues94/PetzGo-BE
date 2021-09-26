using System;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public string NomeCliente { get; set; }
        public string WhatsApp { get; set; }
        public string Endereco { get; set; }

        public Guid PetId { get; set; }
        public string NomePet { get; set; }
        public string TipoPet { get; set; }
    }
}
