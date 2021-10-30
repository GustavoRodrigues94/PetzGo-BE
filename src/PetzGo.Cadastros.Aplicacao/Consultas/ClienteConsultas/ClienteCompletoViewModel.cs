using System;

namespace PetzGo.Cadastros.Aplicacao.Consultas.ClienteConsultas
{
    public class ClienteCompletoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string WhatsApp { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public PetViewModel Pet { get; set; }
    }
}
